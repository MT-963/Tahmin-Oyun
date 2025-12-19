using System;
using System.Windows.Forms;
using GuessGameSingle.Data;
using GuessGameSingle.Helpers;
using GuessGameSingle.Repositories;
using GuessGameSingle.Services;
using GuessGameSingle.Forms;
using Microsoft.Extensions.Configuration;

namespace GuessGameSingle;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var connectionString = config.GetConnectionString("Default")
            ?? throw new InvalidOperationException("Connection string yok");

        var factory = new SqlConnectionFactory(connectionString);
        var userRepo = new SqlUserRepository(factory);
        var scoreRepo = new SqlScoreRepository(factory);

        var authService = new AuthService(userRepo);
        var userService = new UserService(userRepo);
        var scoreService = new ScoreService(scoreRepo);
        var gameService = new GameService();

        Application.Run(new LoginForm(authService, userService, scoreService, gameService));
    }
}

