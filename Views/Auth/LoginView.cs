using sipetok_form.Services;
using sipetok_form.Views.Users;

namespace sipetok_form.Views.Transactions
{
    public partial class LoginView : Form
    {
        private readonly ApiService _apiService = new ApiService();
        public LoginView()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. Validasi Input Kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menampilkan status loading sederhana
            btnLogin.Enabled = false;
            btnLogin.Text = "Mohon tunggu...";

            try
            {
                // 2. Kirim data ke API via ApiService
                var responLogin = await _apiService.Auth.LoginAsync(username, password);

                // 3. Cek hasil respon dari API
                if (responLogin.Success)
                {
                    System.Diagnostics.Debug.WriteLine($"[LOGIN SUKSES] Selamat datang, {username}!");
                    MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Buka halaman utama (UserLists) dan sembunyikan Form Login ini
                    UserPage halamanUtama = new UserPage();
                    halamanUtama.Show();

                    this.Hide();
                }
                else
                {
                    // Tampilkan pesan gagal berdasarkan respon dari API
                    MessageBox.Show(responLogin.Message, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan sistem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Mengembalikan tombol ke keadaan semula
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }
        }
    }
}
