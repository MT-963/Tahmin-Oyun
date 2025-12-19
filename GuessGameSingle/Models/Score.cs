using System;

namespace GuessGameSingle.Models;

public class Score
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Points { get; set; }
    public TimeSpan Sure { get; set; }
    public DateTime OyunTarihi { get; set; } = DateTime.UtcNow;
    public string Username { get; set; } = string.Empty;
}

