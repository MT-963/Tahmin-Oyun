namespace GuessGame.UI.Forms;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.btnLogin = new System.Windows.Forms.Button();
        this.linkManageUsers = new System.Windows.Forms.LinkLabel();
        this.SuspendLayout();
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.Location = new System.Drawing.Point(56, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(259, 25);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Gelişmiş Sayı Tahmin Oyunu";
        // 
        // txtUsername
        // 
        this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtUsername.Location = new System.Drawing.Point(56, 70);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.PlaceholderText = "Kullanıcı adı";
        this.txtUsername.Size = new System.Drawing.Size(259, 27);
        this.txtUsername.TabIndex = 1;
        // 
        // txtPassword
        // 
        this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtPassword.Location = new System.Drawing.Point(56, 110);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PlaceholderText = "Parola";
        this.txtPassword.Size = new System.Drawing.Size(259, 27);
        this.txtPassword.TabIndex = 2;
        this.txtPassword.UseSystemPasswordChar = true;
        // 
        // btnLogin
        // 
        this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
        this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnLogin.ForeColor = System.Drawing.Color.White;
        this.btnLogin.Location = new System.Drawing.Point(56, 150);
        this.btnLogin.Name = "btnLogin";
        this.btnLogin.Size = new System.Drawing.Size(259, 35);
        this.btnLogin.TabIndex = 3;
        this.btnLogin.Text = "Giriş";
        this.btnLogin.UseVisualStyleBackColor = false;
        this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        // 
        // linkManageUsers
        // 
        this.linkManageUsers.AutoSize = true;
        this.linkManageUsers.Location = new System.Drawing.Point(56, 200);
        this.linkManageUsers.Name = "linkManageUsers";
        this.linkManageUsers.Size = new System.Drawing.Size(108, 15);
        this.linkManageUsers.TabIndex = 4;
        this.linkManageUsers.TabStop = true;
        this.linkManageUsers.Text = "Kullanıcı yönetimi";
        this.linkManageUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManageUsers_LinkClicked);
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(370, 240);
        this.Controls.Add(this.linkManageUsers);
        this.Controls.Add(this.btnLogin);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "LoginForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Giriş | Sayı Tahmin";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.LinkLabel linkManageUsers;
}

