using GuessGameSingle.Models;
using GuessGameSingle.Repositories;

namespace GuessGameSingle.Services;

public class ScoreService
{
    private readonly SqlScoreRepository _scoreRepository;

    public ScoreService(SqlScoreRepository scoreRepository)
    {
        _scoreRepository = scoreRepository;
    }

    public int AddScore(int userId, int points, TimeSpan sure)
    {
        var score = new Score
        {
            UserId = userId,
            Points = points,
            Sure = sure,
            OyunTarihi = DateTime.UtcNow
        };
        return _scoreRepository.AddScore(score);
    }

    public IEnumerable<Score> GetTopScores(int take = 5) => _scoreRepository.GetTopScores(take);
}

