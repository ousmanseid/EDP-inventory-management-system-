using System;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Models;
using InventorySystem.Services;
using InventorySystem.Storage;

namespace InventorySystem.UI
{
    public partial class UserManagementForm : Form
    {
        private UserService _userService;

        public UserManagementForm()
        {
            InitializeComponent();
            _userService = new UserService();
            RefreshTable();
            cmbRole.SelectedIndex = 0;
        }

        public void RefreshTable()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _userService.GetAllUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            var newUser = new User(
                (MemoryStorage.Users.Count + 1).ToString(),
                txtUsername.Text,
                txtPassword.Text,
                cmbRole.SelectedItem.ToString()
            );

            _userService.AddUser(newUser);
            RefreshTable();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string userId = dgvUsers.SelectedRows[0].Cells["UserId"].Value.ToString();
                
                // Don't allow deleting yourself or first superadmin (optional safety)
                if (userId == "1") 
                {
                    MessageBox.Show("Cannot delete the primary SuperAdmin.");
                    return;
                }

                _userService.DeleteUser(userId);
                RefreshTable();
            }
        }
    }
}

// UI Update phase 2 - Author: ousmanseid
