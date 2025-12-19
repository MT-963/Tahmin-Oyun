using GuessGameSingle.Data;
using GuessGameSingle.Models;
using Microsoft.Data.SqlClient;

namespace GuessGameSingle.Repositories;

public class SqlScoreRepository
{
    private readonly SqlConnectionFactory _factory;

    public SqlScoreRepository(SqlConnectionFactory factory)
    {
        _factory = factory;
    }

    public int AddScore(Score score)
    {
        const string sql = @"INSERT INTO scores (user_id, score, sure, oyun_tarihi)
                             VALUES (@user_id, @score, @sure, @oyun_tarihi);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";
        using var conn = _factory.CreateConnection();
        using var cmd = new SqlCommand(sql, (SqlConnection)conn);
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
                             OFFSET 0 ROWS FETCH NEXT @take ROWS ONLY;";
        using var conn = _factory.CreateConnection();
        using var cmd = new SqlCommand(sql, (SqlConnection)conn);
        cmd.Parameters.AddWithValue("@take", take);
        using var reader = cmd.ExecuteReader();
        var list = new List<Score>();
        while (reader.Read())
        {
            list.Add(new Score
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                Points = reader.GetInt32(reader.GetOrdinal("score")),
                Sure = TimeSpan.FromSeconds(reader.GetDouble(reader.GetOrdinal("sure"))),
                OyunTarihi = reader.GetDateTime(reader.GetOrdinal("oyun_tarihi")),
                Username = reader.GetString(reader.GetOrdinal("username"))
            });
        }
        return list;
    }
}

