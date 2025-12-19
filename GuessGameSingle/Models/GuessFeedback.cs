using System.Collections.Generic;

namespace GuessGameSingle.Models;

public class GuessFeedback
{
    public bool IsCorrect { get; init; }
    public IReadOnlyList<FeedbackColor> Colors { get; init; } = new List<FeedbackColor>();
    public string Secret { get; init; } = string.Empty;
}

