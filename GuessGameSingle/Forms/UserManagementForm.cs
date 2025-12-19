using System;
using System.Windows.Forms;
using GuessGameSingle.Services;

namespace GuessGameSingle.Forms;

public partial class UserManagementForm : Form
{
    private readonly UserService _userService;

    public UserManagementForm(UserService userService)
    {
        _userService = userService;
        InitializeComponent();
        LoadUsers();
    }

    private void LoadUsers()
    {
        listUsers.Items.Clear();
        foreach (var u in _userService.GetAll())
        {
            listUsers.Items.Add(new ListViewItem(new[] { u.Id.ToString(), u.Username, u.Ad, u.Soyad, u.Email, u.Unvan ?? string.Empty }));
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            _userService.CreateUser(
                txtUsername.Text.Trim(),
                txtPassword.Text,
                txtAd.Text.Trim(),
                txtSoyad.Text.Trim(),
                txtTelefon.Text.Trim(),
                txtEmail.Text.Trim(),
                txtUnvan.Text.Trim(),
                txtNotlar.Text.Trim());
            MessageBox.Show("Kullanıcı eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

