using System;
using System.Windows.Forms;
using GuessGameSingle.Services;
using GuessGameSingle.Models;

namespace GuessGameSingle.Forms;

public partial class LoginForm : Form
{
    private readonly AuthService _authService;
    private readonly UserService _userService;
    private readonly ScoreService _scoreService;
    private readonly GameService _gameService;

    public LoginForm(AuthService authService, UserService userService, ScoreService scoreService, GameService gameService)
    {
        _authService = authService;
        _userService = userService;
        _scoreService = scoreService;
        _gameService = gameService;
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var username = txtUsername.Text.Trim();
        var password = txtPassword.Text;
        var user = _authService.Login(username, password);
        if (user == null)
        {
            MessageBox.Show("Kullanıcı adı veya parola hatalı", "Giriş başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Hide();
        using var main = new MainForm(user, _scoreService, _gameService);
        main.ShowDialog();
        Show();
    }

    private void linkManageUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var frm = new UserManagementForm(_userService);
        frm.ShowDialog();
    }
}

