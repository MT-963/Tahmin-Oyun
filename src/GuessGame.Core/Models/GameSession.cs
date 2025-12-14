using System;

namespace GuessGame.Core.Models;

public class GameSession
{
    public GameLevel Level { get; init; }
    public string Secret { get; init; } = string.Empty;
    public DateTime StartedAtUtc { get; init; } = DateTime.UtcNow;
}

