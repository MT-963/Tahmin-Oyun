using GuessGameSingle.Helpers;
using GuessGameSingle.Models;
using GuessGameSingle.Repositories;

namespace GuessGameSingle.Services;

public class UserService
{
    private readonly SqlUserRepository _userRepository;

    public UserService(SqlUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User> GetAll() => _userRepository.GetAll();

    public int CreateUser(string username, string password, string ad, string soyad, string telefon, string email, string? unvan, string? notlar)
    {
        var existing = _userRepository.GetByUsername(username);
        if (existing != null)
        {
            throw new InvalidOperationException("Bu kullanıcı adı zaten kayıtlı.");
        }

        var user = new User
        {
            Username = username,
            PasswordHash = HashHelper.Sha256(password),
            Ad = ad,
            Soyad = soyad,
            Telefon = telefon,
            Email = email,
            KayitTarihi = DateTime.UtcNow,
            Unvan = unvan,
            Notlar = notlar
        };

        return _userRepository.Add(user);
    }
}

