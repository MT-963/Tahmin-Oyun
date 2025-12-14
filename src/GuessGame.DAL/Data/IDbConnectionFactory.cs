using System.Data;

namespace GuessGame.DAL.Data;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}

