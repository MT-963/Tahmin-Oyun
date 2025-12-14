using GuessGame.BLL.Helpers;
using GuessGame.Core.Models;
using GuessGame.DAL.Interfaces;

namespace GuessGame.BLL.Services;

public class AuthService
{
    private readonly IUserRepository _userRepository;

    public AuthService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User? Login(string username, string password)
    {
        var user = _userRepository.GetByUsername(username);
        if (user is null) return null;
        var hash = HashHelper.Sha256(password);
        return user.PasswordHash.Equals(hash, StringComparison.OrdinalIgnoreCase) ? user : null;
    }
}

