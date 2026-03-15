using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using InventorySystem.Models;

namespace InventorySystem.UI
{
    public partial class MainDashboard : Form
    {
        private User _currentUser;
        public User CurrentUser => _currentUser;
        private ProductForm productForm;
        private Button activeButton;
        private SupplierForm supplierForm;
        private StockForm stockForm;
        private SearchInventoryForm searchInventoryForm;
        private ReportView reportView;
        private OverviewForm overviewForm;
        private UserManagementForm userManagementForm;

        public MainDashboard(User user)
        {
            _currentUser = user;
            InitializeComponent();
            SetupViews();
            CheckLowStock();
            SetupAesthetics();
            ApplyRoleRestrictions();
        }

        private void ApplyRoleRestrictions()
        {
            lblUserRole.Text = $"👤 {_currentUser.Role}: {_currentUser.Username}";

            // Staff restrictions
            if (_currentUser.Role == "Staff")
            {
                btnManageSuppliers.Visible = false;
                btnReports.Visible = false;
                btnManageUsers.Visible = false;
                // Note: Staff can search and do stock entry (checkout/sales)
                // but we will restrict price changes in the forms themselves
            }
            // Admin restrictions
            else if (_currentUser.Role == "Admin")
            {
                btnManageUsers.Visible = false;
            }
            // SuperAdmin has everything
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ShowView(userManagementForm, btnManageUsers);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(overviewForm, btnDashboard);
        }

        private void SetupAesthetics()
        {
            // NEW 3-COLOR PALETTE:
            // 1. Midnight Blue (15, 23, 42)
            // 2. Ocean Blue (37, 99, 235)
            // 3. Pure White (255, 255, 255)

            sidebarTitlePanel.Paint += (s, e) => {
                using (var brush = new LinearGradientBrush(sidebarTitlePanel.ClientRectangle, 
                    Color.FromArgb(15, 23, 42), Color.FromArgb(30, 41, 59), 90F))
                {
                    e.Graphics.FillRectangle(brush, sidebarTitlePanel.ClientRectangle);
                }
            };

            topPanel.Paint += (s, e) => {
                using (var brush = new LinearGradientBrush(topPanel.ClientRectangle, 
                    Color.FromArgb(255, 255, 255), Color.FromArgb(248, 250, 252), 90F))
                {
                    e.Graphics.FillRectangle(brush, topPanel.ClientRectangle);
                }
                // Add a subtle bottom border line
                using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(pen, 0, topPanel.Height - 1, topPanel.Width, topPanel.Height - 1);
                }
            };

            // Style buttons to match the sleek dark theme
            foreach (Control ctrl in sidebarPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Cursor = Cursors.Hand;
                    btn.Font = new Font("Segoe UI Semibold", 12F);
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.Padding = new Padding(25, 0, 0, 0);

                    if (btn.Name == "btnLogout")
                    {
                        btn.BackColor = Color.FromArgb(30, 41, 59);
                        btn.ForeColor = Color.FromArgb(248, 113, 113); // Soft red
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
                    }
                    else
                    {
                        btn.ForeColor = Color.FromArgb(203, 213, 225); // Slate 300
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
                        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
                    }
                }
            }
        }

        private void SetActiveButton(Button btn)
        {
            sidebarPanel.BackColor = Color.FromArgb(15, 23, 42);

            if (activeButton != null)
            {
                activeButton.BackColor = Color.Transparent;
                activeButton.ForeColor = Color.White;
            }
            activeButton = btn;
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(30, 41, 59);
                activeButton.ForeColor = Color.FromArgb(37, 99, 235);
            }
        }

        private void SetupViews()
        {
            productForm = new ProductForm(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            supplierForm = new SupplierForm() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            stockForm = new StockForm(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            searchInventoryForm = new SearchInventoryForm() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            reportView = new ReportView(this) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            overviewForm = new OverviewForm(_currentUser) { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            userManagementForm = new UserManagementForm() { Dock = DockStyle.Fill, TopLevel = false, FormBorderStyle = FormBorderStyle.None };

            contentPanel.Controls.Add(productForm);
            contentPanel.Controls.Add(supplierForm);
            contentPanel.Controls.Add(stockForm);
            contentPanel.Controls.Add(searchInventoryForm);
            contentPanel.Controls.Add(reportView);
            contentPanel.Controls.Add(overviewForm);
            contentPanel.Controls.Add(userManagementForm);

            // Show home screen by default
            ShowView(overviewForm, btnDashboard);
        }

        private void ShowView(Form view, Button btn = null)
        {
            if (btn != null) SetActiveButton(btn);

            if (view is ProductForm frmP) frmP.RefreshTable();
            if (view is SupplierForm frmS) frmS.RefreshTable();
            if (view is StockForm frmSt) frmSt.RefreshProducts();
            if (view is SearchInventoryForm frmSr) frmSr.RefreshTable();
            if (view is ReportView frmR) frmR.RefreshReport();
            if (view is OverviewForm frmO) frmO.RefreshStats();
            if (view is UserManagementForm frmU) frmU.RefreshTable();

            view.BringToFront();
            view.Show();
        }

        public void CheckLowStock()
        {
            var lowStock = new Services.ProductService().GetLowStockProducts();
            if (lowStock != null && lowStock.Count > 0)
            {
                lblLowStockAlert.Text = $"⚠️ Low Stock: {lowStock.Count} Item(s)";
                lblLowStockAlert.Visible = true;
            }
            else
            {
                lblLowStockAlert.Visible = false;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void NavigateToProducts() => ShowView(productForm, btnManageProducts);
        public void NavigateToSuppliers() => ShowView(supplierForm, btnManageSuppliers);
        public void NavigateToStock() => ShowView(stockForm, btnStockEntry);
        public void NavigateToSearchInfo() => ShowView(searchInventoryForm, btnSearchInventory);

        private void btnManageProducts_Click(object sender, EventArgs e) => ShowView(productForm, (Button)sender);
        private void btnManageSuppliers_Click(object sender, EventArgs e) => ShowView(supplierForm, (Button)sender);
        private void btnStockEntry_Click(object sender, EventArgs e) => ShowView(stockForm, (Button)sender);
        private void btnSearchInventory_Click(object sender, EventArgs e) => ShowView(searchInventoryForm, (Button)sender);
        private void btnReports_Click(object sender, EventArgs e) => ShowView(reportView, (Button)sender);

        private void lblHeaderTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSidebarTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSidebarTitle_Click_1(object sender, EventArgs e)
        {

        }
    }
}

// UI Update phase 2 - Author: ousmanseid

// UI Update phase 3 - Author: ousmanseid
