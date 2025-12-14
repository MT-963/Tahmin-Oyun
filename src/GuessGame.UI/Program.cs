using System;
using System.Windows.Forms;
using GuessGame.BLL.Services;
using GuessGame.Core.Models;
using GuessGame.DAL.Data;
using GuessGame.DAL.Repositories;
using GuessGame.UI.Configuration;
using GuessGame.UI.Forms;
using Microsoft.Extensions.Configuration;

namespace GuessGame.UI;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var config = ConfigLoader.Load();
        var connectionString = config.GetConnectionString("Default")
            ?? throw new InvalidOperationException("Connection string yok");

        // DAL
        var factory = new MySqlConnectionFactory(connectionString);
        var userRepo = new MySqlUserRepository(factory);
        var scoreRepo = new MySqlScoreRepository(factory);

        // BLL
        var authService = new AuthService(userRepo);
        var userService = new UserService(userRepo);
        var scoreService = new ScoreService(scoreRepo);
        var gameService = new GameService();

        Application.Run(new LoginForm(authService, userService, scoreService, gameService));
    }
}

