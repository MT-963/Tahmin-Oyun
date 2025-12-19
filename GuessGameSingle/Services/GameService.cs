using System.Diagnostics;
using GuessGameSingle.Models;

namespace GuessGameSingle.Services;

public class GameService
{
    private readonly Random _random = new();
    private GameSession? _current;
    private Stopwatch _stopwatch = new();

    public GameSession Start(GameLevel level)
    {
        var length = (int)level;
        var secret = GenerateSecret(length);
        _current = new GameSession
        {
            Level = level,
            Secret = secret,
            StartedAtUtc = DateTime.UtcNow
        };
        _stopwatch = Stopwatch.StartNew();
        return _current;
    }

    public GuessFeedback Guess(string guess)
    {
        if (_current is null)
        {
            throw new InvalidOperationException("Önce oyunu başlat.");
        }

        if (guess.Length != _current.Secret.Length)
        {
            throw new ArgumentException($"Tahmin uzunluğu {_current.Secret.Length} olmalı.");
        }

        var colors = new List<FeedbackColor>();
        var secret = _current.Secret;
        var secretCounts = secret.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var usedCounts = new Dictionary<char, int>();

        for (int i = 0; i < secret.Length; i++)
        {
            var g = guess[i];
            usedCounts.TryGetValue(g, out var used);

            if (g == secret[i])
            {
                colors.Add(FeedbackColor.Green);
                usedCounts[g] = used + 1;
            }
            else if (secret.Contains(g))
            {
                var allowed = secretCounts[g];
                if (used + 1 > allowed)
                {
                    colors.Add(FeedbackColor.Yellow); // rakam var ama fazla kullanıldı
                    usedCounts[g] = used + 1;
                }
                else
                {
                    colors.Add(FeedbackColor.Blue); // doğru rakam, yanlış yer
                    usedCounts[g] = used + 1;
                }
            }
            else
            {
                colors.Add(FeedbackColor.Red); // hiç yok
            }
        }

        var isCorrect = guess == secret;
        if (isCorrect) _stopwatch.Stop();

        return new GuessFeedback
        {
            IsCorrect = isCorrect,
            Colors = colors,
            Secret = secret
        };
    }

    public TimeSpan Elapsed => _stopwatch.Elapsed;

    private string GenerateSecret(int length)
    {
        var digits = Enumerable.Range(0, 10).Select(x => (char)('0' + x)).ToList();
        var result = new char[length];

        // ilk hane 0 olmasın
        var firstPool = digits.Where(d => d != '0').ToList();
        var firstIndex = _random.Next(firstPool.Count);
        var firstDigit = firstPool[firstIndex];
        result[0] = firstDigit;
        digits.Remove(firstDigit);

        for (int i = 1; i < length; i++)
        {
            var index = _random.Next(digits.Count);
            result[i] = digits[index];
            digits.RemoveAt(index); // benzersiz rakamlar
        }
        return new string(result);
    }
}

