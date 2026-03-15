using System.Drawing;
using System.Windows.Forms;

namespace InventorySystem.UI
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblLowStockAlert;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel sidebarTitlePanel;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageSuppliers;
        private System.Windows.Forms.Button btnStockEntry;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSearchInventory;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel contentPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblLowStockAlert = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSearchInventory = new System.Windows.Forms.Button();
            this.btnStockEntry = new System.Windows.Forms.Button();
            this.btnManageSuppliers = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTitlePanel = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.sidebarTitlePanel.SuspendLayout();
            this.SuspendLayout();
            
            // topPanel
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.lblLowStockAlert);
            this.topPanel.Controls.Add(this.lblHeaderTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(300, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(900, 80);
            
            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(52, 58, 64);
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(168, 41);
            this.lblHeaderTitle.Text = "Dashboard";
            
            // lblLowStockAlert
            this.lblLowStockAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLowStockAlert.AutoSize = true;
            this.lblLowStockAlert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLowStockAlert.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblLowStockAlert.Location = new System.Drawing.Point(550, 25);
            this.lblLowStockAlert.Name = "lblLowStockAlert";
            this.lblLowStockAlert.Size = new System.Drawing.Size(0, 28);
            
            // sidebarPanel
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.sidebarPanel.Controls.Add(this.btnManageUsers);
            this.sidebarPanel.Controls.Add(this.btnReports);
            this.sidebarPanel.Controls.Add(this.btnSearchInventory);
            this.sidebarPanel.Controls.Add(this.btnStockEntry);
            this.sidebarPanel.Controls.Add(this.btnManageSuppliers);
            this.sidebarPanel.Controls.Add(this.btnManageProducts);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Controls.Add(this.sidebarTitlePanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(300, 750);
            
            // btnDashboard
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 120);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(300, 60);
            this.btnDashboard.Text = "🏠 Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // btnManageProducts
            this.btnManageProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageProducts.ForeColor = System.Drawing.Color.White;
            this.btnManageProducts.Location = new System.Drawing.Point(0, 120);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(300, 60);
            this.btnManageProducts.Text = "📦 Manage Products";
            this.btnManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);

            // btnManageSuppliers
            this.btnManageSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSuppliers.FlatAppearance.BorderSize = 0;
            this.btnManageSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnManageSuppliers.Location = new System.Drawing.Point(0, 180);
            this.btnManageSuppliers.Name = "btnManageSuppliers";
            this.btnManageSuppliers.Size = new System.Drawing.Size(300, 60);
            this.btnManageSuppliers.Text = "🏢 Manage Suppliers";
            this.btnManageSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSuppliers.Click += new System.EventHandler(this.btnManageSuppliers_Click);

            // btnStockEntry
            this.btnStockEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockEntry.FlatAppearance.BorderSize = 0;
            this.btnStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockEntry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStockEntry.ForeColor = System.Drawing.Color.White;
            this.btnStockEntry.Location = new System.Drawing.Point(0, 240);
            this.btnStockEntry.Name = "btnStockEntry";
            this.btnStockEntry.Size = new System.Drawing.Size(300, 60);
            this.btnStockEntry.Text = "✍️ Stock Entry";
            this.btnStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockEntry.Click += new System.EventHandler(this.btnStockEntry_Click);

            // btnSearchInventory
            this.btnSearchInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchInventory.FlatAppearance.BorderSize = 0;
            this.btnSearchInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInventory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchInventory.ForeColor = System.Drawing.Color.White;
            this.btnSearchInventory.Location = new System.Drawing.Point(0, 300);
            this.btnSearchInventory.Name = "btnSearchInventory";
            this.btnSearchInventory.Size = new System.Drawing.Size(300, 60);
            this.btnSearchInventory.Text = "🔍 Search Inventory";
            this.btnSearchInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchInventory.Click += new System.EventHandler(this.btnSearchInventory_Click);

            // btnReports
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 360);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(300, 60);
            this.btnReports.Text = "📊 Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // btnManageUsers
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 420);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(300, 60);
            this.btnManageUsers.Text = "👤 Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);

            // btnLogout
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 680);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 70);
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);

            // sidebarTitlePanel
            this.sidebarTitlePanel.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.sidebarTitlePanel.Controls.Add(this.lblSidebarTitle);
            this.sidebarTitlePanel.Controls.Add(this.lblUserRole);
            this.sidebarTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarTitlePanel.Name = "sidebarTitlePanel";
            this.sidebarTitlePanel.Size = new System.Drawing.Size(300, 120);
            
            // lblSidebarTitle
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(0, 20);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(300, 45);
            this.lblSidebarTitle.Text = "Inventory Panel";
            this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSidebarTitle.Click += new System.EventHandler(this.btnDashboard_Click);

            // lblUserRole
            this.lblUserRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(200, 225, 255);
            this.lblUserRole.Location = new System.Drawing.Point(0, 80);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(300, 40);
            this.lblUserRole.Text = "👤 Role";
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // contentPanel
            this.contentPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(300, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(900, 670);
            
            // MainDashboard
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Panel - Management System";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

// UI Update phase 2 - Author: ousmanseid
