using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GuessGameSingle.Models;
using GuessGameSingle.Services;

namespace GuessGameSingle.Forms;

public partial class MainForm : Form
{
    private readonly User _user;
    private readonly ScoreService _scoreService;
    private readonly GameService _gameService;
    private GameLevel _currentLevel = GameLevel.Easy3;
    private int _attempts;

    public MainForm(User user, ScoreService scoreService, GameService gameService)
    {
        _user = user;
        _scoreService = scoreService;
        _gameService = gameService;
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        lblUser.Text = $"Oyuncu: {_user.Username}";
        radio3.Checked = true;
        StartGame();
        RefreshScores();
    }

    private void StartGame()
    {
        _attempts = 0;
        var level = _currentLevel;
        _gameService.Start(level);
        txtGuess.Text = string.Empty;
        panelFeedback.Controls.Clear();
        lblSecret.Text = $"Hedef: {((int)level)} haneli";
    }

    private void RefreshScores()
    {
        listScores.Items.Clear();
        var scores = _scoreService.GetTopScores(5);
        foreach (var s in scores)
        {
            var item = new ListViewItem(new[]
            {
                s.Username,
                s.Points.ToString(),
                $"{s.Sure.TotalSeconds:0.0} sn"
            });
            listScores.Items.Add(item);
        }
    }

    private void DifficultyChanged(object sender, EventArgs e)
    {
        if (radio3.Checked) _currentLevel = GameLevel.Easy3;
        else if (radio4.Checked) _currentLevel = GameLevel.Medium4;
        else _currentLevel = GameLevel.Hard5;
        StartGame();
    }

    private void DigitClick(object? sender, EventArgs e)
    {
        if (sender is not Button btn) return;
        var length = (int)_currentLevel;
        if (txtGuess.Text.Length >= length) return;
        if (txtGuess.Text.Length == 0 && btn.Text == "0") return; // leading zero yok
        txtGuess.Text += btn.Text;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        if (txtGuess.Text.Length > 0)
        {
            txtGuess.Text = txtGuess.Text[..^1];
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtGuess.Text = string.Empty;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        var guess = txtGuess.Text;
        if (guess.Length != (int)_currentLevel)
        {
            MessageBox.Show($"Lütfen {(int)_currentLevel} haneli bir sayı girin.", "Eksik tahmin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (guess.StartsWith('0'))
        {
            MessageBox.Show("Tahmin 0 ile başlayamaz.", "Geçersiz tahmin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _attempts++;
        var feedback = _gameService.Guess(guess);
        DrawFeedback(feedback);

        if (feedback.IsCorrect)
        {
            var elapsed = _gameService.Elapsed;
            var points = CalculatePoints(_currentLevel, _attempts, elapsed);
            _scoreService.AddScore(_user.Id, points, elapsed);
            MessageBox.Show($"Tebrikler! Süre: {elapsed.TotalSeconds:0.0} sn | Puan: {points}", "Doğru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshScores();
            StartGame();
        }
        else
        {
            txtGuess.Text = string.Empty;
        }
    }

    private void DrawFeedback(GuessFeedback feedback)
    {
        panelFeedback.Controls.Clear();
        for (int i = 0; i < feedback.Colors.Count; i++)
        {
            var color = ToDrawingColor(feedback.Colors[i]);
            var lbl = new Label
            {
                AutoSize = false,
                Width = 40,
                Height = 40,
                BackColor = color,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Text = (i < txtGuess.Text.Length ? txtGuess.Text[i] : '?').ToString()
            };
            panelFeedback.Controls.Add(lbl);
        }
    }

    private static Color ToDrawingColor(FeedbackColor feedbackColor) =>
        feedbackColor switch
        {
            FeedbackColor.Green => Color.MediumSeaGreen,
            FeedbackColor.Blue => Color.DodgerBlue,
            FeedbackColor.Yellow => Color.Goldenrod,
            _ => Color.IndianRed
        };

    private int CalculatePoints(GameLevel level, int attempts, TimeSpan elapsed)
    {
        var baseScore = ((int)level) * 200;
        var timePenalty = (int)elapsed.TotalSeconds * 2;
        var attemptPenalty = attempts * 20;
        var total = baseScore - timePenalty - attemptPenalty;
        return Math.Max(total, 10);
    }

    private void txtGuess_KeyPress(object? sender, KeyPressEventArgs e)
    {
        var lengthLimit = (int)_currentLevel;

        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            btnSubmit.PerformClick();
            return;
        }

        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
            return;
        }

        if (!char.IsControl(e.KeyChar))
        {
            if (txtGuess.SelectionStart == 0 && txtGuess.TextLength == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }

            var nextLength = txtGuess.TextLength - txtGuess.SelectionLength + 1;
            if (nextLength > lengthLimit)
            {
                e.Handled = true;
            }
        }
    }
}

