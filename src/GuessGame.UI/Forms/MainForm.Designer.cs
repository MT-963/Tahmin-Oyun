namespace GuessGame.UI.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblUser = new System.Windows.Forms.Label();
        this.grpDifficulty = new System.Windows.Forms.GroupBox();
        this.radio5 = new System.Windows.Forms.RadioButton();
        this.radio4 = new System.Windows.Forms.RadioButton();
        this.radio3 = new System.Windows.Forms.RadioButton();
        this.lblSecret = new System.Windows.Forms.Label();
        this.txtGuess = new System.Windows.Forms.TextBox();
        this.btnSubmit = new System.Windows.Forms.Button();
        this.panelKeypad = new System.Windows.Forms.FlowLayoutPanel();
        this.btnBack = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.panelFeedback = new System.Windows.Forms.FlowLayoutPanel();
        this.listScores = new System.Windows.Forms.ListView();
        this.colUser = new System.Windows.Forms.ColumnHeader();
        this.colScore = new System.Windows.Forms.ColumnHeader();
        this.colTime = new System.Windows.Forms.ColumnHeader();
        this.lblTop = new System.Windows.Forms.Label();
        this.grpDifficulty.SuspendLayout();
        this.SuspendLayout();
        // 
        // lblUser
        // 
        this.lblUser.AutoSize = true;
        this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblUser.Location = new System.Drawing.Point(12, 9);
        this.lblUser.Name = "lblUser";
        this.lblUser.Size = new System.Drawing.Size(72, 19);
        this.lblUser.TabIndex = 0;
        this.lblUser.Text = "Oyuncu:";
        // 
        // grpDifficulty
        // 
        this.grpDifficulty.Controls.Add(this.radio5);
        this.grpDifficulty.Controls.Add(this.radio4);
        this.grpDifficulty.Controls.Add(this.radio3);
        this.grpDifficulty.Location = new System.Drawing.Point(12, 40);
        this.grpDifficulty.Name = "grpDifficulty";
        this.grpDifficulty.Size = new System.Drawing.Size(200, 55);
        this.grpDifficulty.TabIndex = 1;
        this.grpDifficulty.TabStop = false;
        this.grpDifficulty.Text = "Zorluk";
        // 
        // radio5
        // 
        this.radio5.AutoSize = true;
        this.radio5.Location = new System.Drawing.Point(138, 22);
        this.radio5.Name = "radio5";
        this.radio5.Size = new System.Drawing.Size(52, 19);
        this.radio5.TabIndex = 2;
        this.radio5.TabStop = true;
        this.radio5.Text = "5 hane";
        this.radio5.UseVisualStyleBackColor = true;
        this.radio5.CheckedChanged += new System.EventHandler(this.DifficultyChanged);
        // 
        // radio4
        // 
        this.radio4.AutoSize = true;
        this.radio4.Location = new System.Drawing.Point(74, 22);
        this.radio4.Name = "radio4";
        this.radio4.Size = new System.Drawing.Size(52, 19);
        this.radio4.TabIndex = 1;
        this.radio4.TabStop = true;
        this.radio4.Text = "4 hane";
        this.radio4.UseVisualStyleBackColor = true;
        this.radio4.CheckedChanged += new System.EventHandler(this.DifficultyChanged);
        // 
        // radio3
        // 
        this.radio3.AutoSize = true;
        this.radio3.Location = new System.Drawing.Point(10, 22);
        this.radio3.Name = "radio3";
        this.radio3.Size = new System.Drawing.Size(52, 19);
        this.radio3.TabIndex = 0;
        this.radio3.TabStop = true;
        this.radio3.Text = "3 hane";
        this.radio3.UseVisualStyleBackColor = true;
        this.radio3.CheckedChanged += new System.EventHandler(this.DifficultyChanged);
        // 
        // lblSecret
        // 
        this.lblSecret.AutoSize = true;
        this.lblSecret.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblSecret.Location = new System.Drawing.Point(12, 108);
        this.lblSecret.Name = "lblSecret";
        this.lblSecret.Size = new System.Drawing.Size(72, 19);
        this.lblSecret.TabIndex = 2;
        this.lblSecret.Text = "Hedef: ---";
        // 
        // txtGuess
        // 
        this.txtGuess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.txtGuess.Location = new System.Drawing.Point(12, 135);
        this.txtGuess.MaxLength = 5;
        this.txtGuess.Name = "txtGuess";
        this.txtGuess.PlaceholderText = "Tahmin";
        this.txtGuess.ReadOnly = false;
        this.txtGuess.Size = new System.Drawing.Size(200, 39);
        this.txtGuess.TabIndex = 3;
        this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
        // 
        // btnSubmit
        // 
        this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
        this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSubmit.ForeColor = System.Drawing.Color.White;
        this.btnSubmit.Location = new System.Drawing.Point(12, 180);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new System.Drawing.Size(200, 35);
        this.btnSubmit.TabIndex = 4;
        this.btnSubmit.Text = "Tahmin Et";
        this.btnSubmit.UseVisualStyleBackColor = false;
        this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
        // 
        // panelKeypad
        // 
        this.panelKeypad.Location = new System.Drawing.Point(12, 225);
        this.panelKeypad.Name = "panelKeypad";
        this.panelKeypad.Size = new System.Drawing.Size(200, 180);
        this.panelKeypad.TabIndex = 5;
        // 
        // btnBack
        // 
        this.btnBack.Location = new System.Drawing.Point(12, 415);
        this.btnBack.Name = "btnBack";
        this.btnBack.Size = new System.Drawing.Size(95, 30);
        this.btnBack.TabIndex = 6;
        this.btnBack.Text = "Sil";
        this.btnBack.UseVisualStyleBackColor = true;
        this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        // 
        // btnClear
        // 
        this.btnClear.Location = new System.Drawing.Point(117, 415);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(95, 30);
        this.btnClear.TabIndex = 7;
        this.btnClear.Text = "Temizle";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // panelFeedback
        // 
        this.panelFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        this.panelFeedback.AutoSize = true;
        this.panelFeedback.Location = new System.Drawing.Point(230, 40);
        this.panelFeedback.Name = "panelFeedback";
        this.panelFeedback.Size = new System.Drawing.Size(250, 50);
        this.panelFeedback.TabIndex = 8;
        // 
        // listScores
        // 
        this.listScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUser,
            this.colScore,
            this.colTime});
        this.listScores.FullRowSelect = true;
        this.listScores.GridLines = true;
        this.listScores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        this.listScores.Location = new System.Drawing.Point(230, 120);
        this.listScores.Name = "listScores";
        this.listScores.Size = new System.Drawing.Size(280, 325);
        this.listScores.TabIndex = 9;
        this.listScores.UseCompatibleStateImageBehavior = false;
        this.listScores.View = System.Windows.Forms.View.Details;
        // 
        // colUser
        // 
        this.colUser.Text = "Kullanıcı";
        this.colUser.Width = 110;
        // 
        // colScore
        // 
        this.colScore.Text = "Puan";
        this.colScore.Width = 70;
        // 
        // colTime
        // 
        this.colTime.Text = "Süre";
        this.colTime.Width = 80;
        // 
        // lblTop
        // 
        this.lblTop.AutoSize = true;
        this.lblTop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTop.Location = new System.Drawing.Point(230, 98);
        this.lblTop.Name = "lblTop";
        this.lblTop.Size = new System.Drawing.Size(91, 19);
        this.lblTop.TabIndex = 10;
        this.lblTop.Text = "En iyi 5 skor";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(524, 461);
        this.Controls.Add(this.lblTop);
        this.Controls.Add(this.listScores);
        this.Controls.Add(this.panelFeedback);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnBack);
        this.Controls.Add(this.panelKeypad);
        this.Controls.Add(this.btnSubmit);
        this.Controls.Add(this.txtGuess);
        this.Controls.Add(this.lblSecret);
        this.Controls.Add(this.grpDifficulty);
        this.Controls.Add(this.lblUser);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sayı Tahmin Oyunu";
        this.AcceptButton = this.btnSubmit;
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.grpDifficulty.ResumeLayout(false);
        this.grpDifficulty.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

        // dynamic keypad (10 buton)
        this.panelKeypad.WrapContents = true;
        this.panelKeypad.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
        for (int i = 0; i <= 9; i++)
        {
            var btn = new System.Windows.Forms.Button
            {
                Text = i.ToString(),
                Width = 60,
                Height = 40,
                Margin = new System.Windows.Forms.Padding(5),
                BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
            };
            btn.Click += new System.EventHandler(this.DigitClick);
            this.panelKeypad.Controls.Add(btn);
        }
    }

    #endregion

    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.GroupBox grpDifficulty;
    private System.Windows.Forms.RadioButton radio5;
    private System.Windows.Forms.RadioButton radio4;
    private System.Windows.Forms.RadioButton radio3;
    private System.Windows.Forms.Label lblSecret;
    private System.Windows.Forms.TextBox txtGuess;
    private System.Windows.Forms.Button btnSubmit;
    private System.Windows.Forms.FlowLayoutPanel panelKeypad;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.FlowLayoutPanel panelFeedback;
    private System.Windows.Forms.ListView listScores;
    private System.Windows.Forms.ColumnHeader colUser;
    private System.Windows.Forms.ColumnHeader colScore;
    private System.Windows.Forms.ColumnHeader colTime;
    private System.Windows.Forms.Label lblTop;
}

