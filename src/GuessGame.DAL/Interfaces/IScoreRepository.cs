using GuessGame.Core.Models;

namespace GuessGame.DAL.Interfaces;

public interface IScoreRepository
{
    int AddScore(Score score);
    IEnumerable<Score> GetTopScores(int take = 5);
}

