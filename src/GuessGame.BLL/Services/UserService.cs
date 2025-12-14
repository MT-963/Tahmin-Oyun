using GuessGame.BLL.Helpers;
using GuessGame.Core.Models;
using GuessGame.DAL.Interfaces;

namespace GuessGame.BLL.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
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

