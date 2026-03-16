using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using InventorySystem.Services;

namespace InventorySystem.UI
{
    public partial class LoginForm : Form
    {
        private UserService _userService;

        public LoginForm()
        {
            _userService = new UserService();
            InitializeComponent();
            SetupAesthetics();
        }

        private void SetupAesthetics()
        {
            // Sleek Login header matching Dashboard
            this.Paint += (s, e) => {
                using (var brush = new LinearGradientBrush(new Rectangle(0,0, this.Width, 80),
                    Color.FromArgb(15, 23, 42), Color.FromArgb(37, 99, 235), 45F))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(0, 0, this.Width, 80));
                }
            };

            lblTitle.ForeColor = Color.White;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Parent = this; // Move to front
            btnLogin.BackColor = Color.FromArgb(37, 99, 235);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = _userService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Login Successful! Welcome {user.Username}");
                
                txtPassword.Text = ""; // Clear password for next time
                
                MainDashboard dashboard = new MainDashboard(user);
                this.Hide();
                dashboard.ShowDialog();
                this.Show(); // Re-show login when dashboard closes
            }
            else
            {
                MessageBox.Show("Invalid credentials. Try admin/admin", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// UI Update phase 2 - Author: ousmanseid

// UI Update phase 3 - Author: ousmanseid

// UI Update phase 4 - Author: ousmanseid

// UI Update phase 5 - Author: ousmanseid

// UI Minor Update - System maintenance commit
