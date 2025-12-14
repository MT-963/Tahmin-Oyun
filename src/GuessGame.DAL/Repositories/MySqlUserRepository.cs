using GuessGame.Core.Models;
using GuessGame.DAL.Data;
using GuessGame.DAL.Interfaces;
using MySql.Data.MySqlClient;

namespace GuessGame.DAL.Repositories;

public class MySqlUserRepository : IUserRepository
{
    private readonly IDbConnectionFactory _factory;

    public MySqlUserRepository(IDbConnectionFactory factory)
    {
        _factory = factory;
    }

    public User? GetByUsername(string username)
    {
        const string sql = @"SELECT id, username, password_hash, ad, soyad, telefon, email, kayit_tarihi, unvan, notlar
                             FROM users WHERE username = @username LIMIT 1;";

        using var conn = _factory.CreateConnection();
        using var cmd = new MySqlCommand(sql, (MySqlConnection)conn);
        cmd.Parameters.AddWithValue("@username", username);
        using var reader = cmd.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public User? GetById(int id)
    {
        const string sql = @"SELECT id, username, password_hash, ad, soyad, telefon, email, kayit_tarihi, unvan, notlar
                             FROM users WHERE id = @id LIMIT 1;";
        using var conn = _factory.CreateConnection();
        using var cmd = new MySqlCommand(sql, (MySqlConnection)conn);
        cmd.Parameters.AddWithValue("@id", id);
        using var reader = cmd.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public IEnumerable<User> GetAll()
    {
        const string sql = @"SELECT id, username, password_hash, ad, soyad, telefon, email, kayit_tarihi, unvan, notlar
                             FROM users ORDER BY kayit_tarihi DESC;";
        using var conn = _factory.CreateConnection();
        using var cmd = new MySqlCommand(sql, (MySqlConnection)conn);
        using var reader = cmd.ExecuteReader();
        var list = new List<User>();
        while (reader.Read())
        {
            list.Add(Map(reader));
        }
        return list;
    }

    public int Add(User user)
    {
        const string sql = @"INSERT INTO users (username, password_hash, ad, soyad, telefon, email, kayit_tarihi, unvan, notlar)
                             VALUES (@username, @password_hash, @ad, @soyad, @telefon, @email, @kayit_tarihi, @unvan, @notlar);
                             SELECT LAST_INSERT_ID();";
        using var conn = _factory.CreateConnection();
        using var cmd = new MySqlCommand(sql, (MySqlConnection)conn);
        cmd.Parameters.AddWithValue("@username", user.Username);
        cmd.Parameters.AddWithValue("@password_hash", user.PasswordHash);
        cmd.Parameters.AddWithValue("@ad", user.Ad);
        cmd.Parameters.AddWithValue("@soyad", user.Soyad);
        cmd.Parameters.AddWithValue("@telefon", user.Telefon);
        cmd.Parameters.AddWithValue("@email", user.Email);
        cmd.Parameters.AddWithValue("@kayit_tarihi", user.KayitTarihi);
        cmd.Parameters.AddWithValue("@unvan", user.Unvan ?? string.Empty);
        cmd.Parameters.AddWithValue("@notlar", user.Notlar ?? string.Empty);
        var result = cmd.ExecuteScalar();
        return Convert.ToInt32(result);
    }

    private static User Map(MySqlDataReader reader)
    {
        string SafeString(string column) =>
            reader.IsDBNull(reader.GetOrdinal(column)) ? string.Empty : reader.GetString(column);

        return new User
        {
            Id = reader.GetInt32("id"),
            Username = SafeString("username"),
            PasswordHash = SafeString("password_hash"),
            Ad = SafeString("ad"),
            Soyad = SafeString("soyad"),
            Telefon = SafeString("telefon"),
            Email = SafeString("email"),
            KayitTarihi = reader.GetDateTime("kayit_tarihi"),
            Unvan = SafeString("unvan"),
            Notlar = SafeString("notlar")
        };
    }
}

