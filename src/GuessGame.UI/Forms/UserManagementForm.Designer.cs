namespace GuessGame.UI.Forms;

partial class UserManagementForm
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
        this.txtAd = new System.Windows.Forms.TextBox();
        this.txtSoyad = new System.Windows.Forms.TextBox();
        this.txtTelefon = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.txtUnvan = new System.Windows.Forms.TextBox();
        this.txtNotlar = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.listUsers = new System.Windows.Forms.ListView();
        this.colId = new System.Windows.Forms.ColumnHeader();
        this.colUsername = new System.Windows.Forms.ColumnHeader();
        this.colAd = new System.Windows.Forms.ColumnHeader();
        this.colSoyad = new System.Windows.Forms.ColumnHeader();
        this.colEmail = new System.Windows.Forms.ColumnHeader();
        this.colUnvan = new System.Windows.Forms.ColumnHeader();
        this.SuspendLayout();
        // 
        // txtAd
        // 
        this.txtAd.Location = new System.Drawing.Point(12, 12);
        this.txtAd.Name = "txtAd";
        this.txtAd.PlaceholderText = "Ad";
        this.txtAd.Size = new System.Drawing.Size(180, 23);
        this.txtAd.TabIndex = 0;
        // 
        // txtSoyad
        // 
        this.txtSoyad.Location = new System.Drawing.Point(198, 12);
        this.txtSoyad.Name = "txtSoyad";
        this.txtSoyad.PlaceholderText = "Soyad";
        this.txtSoyad.Size = new System.Drawing.Size(180, 23);
        this.txtSoyad.TabIndex = 1;
        // 
        // txtTelefon
        // 
        this.txtTelefon.Location = new System.Drawing.Point(12, 41);
        this.txtTelefon.Name = "txtTelefon";
        this.txtTelefon.PlaceholderText = "Telefon";
        this.txtTelefon.Size = new System.Drawing.Size(180, 23);
        this.txtTelefon.TabIndex = 2;
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(198, 41);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.PlaceholderText = "E-posta";
        this.txtEmail.Size = new System.Drawing.Size(180, 23);
        this.txtEmail.TabIndex = 3;
        // 
        // txtUsername
        // 
        this.txtUsername.Location = new System.Drawing.Point(12, 70);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.PlaceholderText = "Kullanıcı adı";
        this.txtUsername.Size = new System.Drawing.Size(180, 23);
        this.txtUsername.TabIndex = 4;
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(198, 70);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PlaceholderText = "Parola";
        this.txtPassword.Size = new System.Drawing.Size(180, 23);
        this.txtPassword.TabIndex = 5;
        this.txtPassword.UseSystemPasswordChar = true;
        // 
        // txtUnvan
        // 
        this.txtUnvan.Location = new System.Drawing.Point(12, 99);
        this.txtUnvan.Name = "txtUnvan";
        this.txtUnvan.PlaceholderText = "Ünvan";
        this.txtUnvan.Size = new System.Drawing.Size(180, 23);
        this.txtUnvan.TabIndex = 6;
        // 
        // txtNotlar
        // 
        this.txtNotlar.Location = new System.Drawing.Point(198, 99);
        this.txtNotlar.Name = "txtNotlar";
        this.txtNotlar.PlaceholderText = "Ek notlar";
        this.txtNotlar.Size = new System.Drawing.Size(180, 23);
        this.txtNotlar.TabIndex = 7;
        // 
        // btnSave
        // 
        this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
        this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSave.ForeColor = System.Drawing.Color.White;
        this.btnSave.Location = new System.Drawing.Point(12, 128);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(366, 30);
        this.btnSave.TabIndex = 8;
        this.btnSave.Text = "Kaydet";
        this.btnSave.UseVisualStyleBackColor = false;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // listUsers
        // 
        this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colUsername,
            this.colAd,
            this.colSoyad,
            this.colEmail,
            this.colUnvan});
        this.listUsers.FullRowSelect = true;
        this.listUsers.GridLines = true;
        this.listUsers.Location = new System.Drawing.Point(12, 172);
        this.listUsers.Name = "listUsers";
        this.listUsers.Size = new System.Drawing.Size(366, 220);
        this.listUsers.TabIndex = 9;
        this.listUsers.UseCompatibleStateImageBehavior = false;
        this.listUsers.View = System.Windows.Forms.View.Details;
        // 
        // colId
        // 
        this.colId.Text = "#";
        this.colId.Width = 30;
        // 
        // colUsername
        // 
        this.colUsername.Text = "Kullanıcı";
        this.colUsername.Width = 80;
        // 
        // colAd
        // 
        this.colAd.Text = "Ad";
        this.colAd.Width = 60;
        // 
        // colSoyad
        // 
        this.colSoyad.Text = "Soyad";
        this.colSoyad.Width = 60;
        // 
        // colEmail
        // 
        this.colEmail.Text = "E-posta";
        this.colEmail.Width = 80;
        // 
        // colUnvan
        // 
        this.colUnvan.Text = "Ünvan";
        this.colUnvan.Width = 60;
        // 
        // UserManagementForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(390, 404);
        this.Controls.Add(this.listUsers);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.txtNotlar);
        this.Controls.Add(this.txtUnvan);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.txtTelefon);
        this.Controls.Add(this.txtSoyad);
        this.Controls.Add(this.txtAd);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "UserManagementForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Kullanıcı Yönetimi";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtAd;
    private System.Windows.Forms.TextBox txtSoyad;
    private System.Windows.Forms.TextBox txtTelefon;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtUnvan;
    private System.Windows.Forms.TextBox txtNotlar;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.ListView listUsers;
    private System.Windows.Forms.ColumnHeader colId;
    private System.Windows.Forms.ColumnHeader colUsername;
    private System.Windows.Forms.ColumnHeader colAd;
    private System.Windows.Forms.ColumnHeader colSoyad;
    private System.Windows.Forms.ColumnHeader colEmail;
    private System.Windows.Forms.ColumnHeader colUnvan;
}

