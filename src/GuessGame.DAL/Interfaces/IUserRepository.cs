using GuessGame.Core.Models;

namespace GuessGame.DAL.Interfaces;

public interface IUserRepository
{
    User? GetByUsername(string username);
    User? GetById(int id);
    int Add(User user);
    IEnumerable<User> GetAll();
}

