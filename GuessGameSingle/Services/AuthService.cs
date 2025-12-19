using GuessGameSingle.Helpers;
using GuessGameSingle.Models;
using GuessGameSingle.Repositories;

namespace GuessGameSingle.Services;

public class AuthService
{
    private readonly SqlUserRepository _userRepository;

    public AuthService(SqlUserRepository userRepository)
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

