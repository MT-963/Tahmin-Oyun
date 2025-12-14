using System;

namespace GuessGame.Core.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Ad { get; set; } = string.Empty;
    public string Soyad { get; set; } = string.Empty;
    public string Telefon { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime KayitTarihi { get; set; } = DateTime.UtcNow;
    public string? Unvan { get; set; }
    public string? Notlar { get; set; }
}

