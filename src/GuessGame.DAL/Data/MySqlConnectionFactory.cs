using System.Data;
using MySql.Data.MySqlClient;

namespace GuessGame.DAL.Data;

public class MySqlConnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;

    public MySqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        var conn = new MySqlConnection(_connectionString);
        conn.Open();
        return conn;
    }
}

