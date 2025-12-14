using GuessGame.Core.Models;
using GuessGame.DAL.Interfaces;

namespace GuessGame.BLL.Services;

public class ScoreService
{
    private readonly IScoreRepository _scoreRepository;

    public ScoreService(IScoreRepository scoreRepository)
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

