using GuessGame.Core.Models;
using GuessGame.DAL.Data;
using GuessGame.DAL.Interfaces;
using MySql.Data.MySqlClient;

namespace GuessGame.DAL.Repositories;

public class MySqlScoreRepository : IScoreRepository
{
    private readonly IDbConnectionFactory _factory;

    public MySqlScoreRepository(IDbConnectionFactory factory)
    {
        _factory = factory;
    }

    public int AddScore(Score score)
    {
        const string sql = @"INSERT INTO scores (user_id, score, sure, oyun_tarihi)
                             VALUES (@user_id, @score, @sure, @oyun_tarihi);
                             SELECT LAST_INSERT_ID();";
        using var conn = _factory.CreateConnection();
        using var cmd = new MySqlCommand(sql, (MySqlConnection)conn);
        cmd.Parameters.AddWithValue("@user_id", score.UserId);
        cmd.Parameters.AddWithValue("@score", score.Points);
        cmd.Parameters.AddWithValue("@sure", score.Sure.TotalSeconds);
        cmd.Parameters.AddWithValue("@oyun_tarihi", score.OyunTarihi);
        var result = cmd.ExecuteScalar();
        return Convert.ToInt32(result);
    }

    public IEnumerable<Score> GetTopScores(int take = 5)
    {
        const string sql = @"SELECT s.id, s.user_id, s.score, s.sure, s.oyun_tarihi, u.username
                             FROM scores s
                             INNER JOIN users u ON u.id = s.user_id
                             ORDER BY s.score DESC, s.sure ASC
                             LIMIT @take;";
        using var conn = _factory.CreateConnection();
        using var cmd = new MySqlCommand(sql, (MySqlConnection)conn);
        cmd.Parameters.AddWithValue("@take", take);
        using var reader = cmd.ExecuteReader();
        var list = new List<Score>();
        while (reader.Read())
        {
            list.Add(new Score
            {
                Id = reader.GetInt32("id"),
                UserId = reader.GetInt32("user_id"),
                Points = reader.GetInt32("score"),
                Sure = TimeSpan.FromSeconds(reader.GetDouble("sure")),
                OyunTarihi = reader.GetDateTime("oyun_tarihi"),
                Username = reader.GetString("username")
            });
        }
        return list;
    }
}

