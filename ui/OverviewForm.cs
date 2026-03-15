using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.Services;
using InventorySystem.Models;

namespace InventorySystem.UI
{
    public partial class OverviewForm : Form
    {
        private ProductService _productService;
        private SupplierService _supplierService;
        private StockService _stockService;
        private User _user;

        public OverviewForm(User user = null)
        {
            _user = user;
            _productService = new ProductService();
            _supplierService = new SupplierService();
            _stockService = new StockService();
            InitializeComponent();
            SetupAesthetics();
            RefreshStats();

            // Ensure stats refresh every time the dashboard is shown
            this.VisibleChanged += (s, e) => { if (this.Visible) RefreshStats(); };
            this.Activated += (s, e) => RefreshStats();
        }

        private void SetupAesthetics()
        {
            // Add a beautiful gradient to the Hero panel
            pnlHero.Paint += (s, e) => {
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    pnlHero.ClientRectangle, 
                    Color.FromArgb(37, 99, 235), 
                    Color.FromArgb(15, 23, 42), 
                    45F))
                {
                    e.Graphics.FillRectangle(brush, pnlHero.ClientRectangle);
                }
            };

            // Modern hover effects for cards
            StyleCard(card1, Color.FromArgb(37, 99, 235));
            StyleCard(card2, Color.FromArgb(16, 185, 129));
            StyleCard(card3, Color.FromArgb(245, 158, 11));
            StyleCard(card4, Color.FromArgb(139, 92, 246));
        }

        private void StyleCard(Panel pnl, Color accentColor)
        {
            pnl.BackColor = Color.White;
            pnl.Paint += (s, e) => {
                using (var pen = new Pen(accentColor, 3))
                {
                    e.Graphics.DrawLine(pen, 0, 0, pnl.Width, 0); // Top accent border
                }
            };

            pnl.MouseEnter += (s, e) => {
                pnl.BackColor = Color.FromArgb(248, 250, 252);
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.Cursor = Cursors.Hand;
            };
            pnl.MouseLeave += (s, e) => {
                pnl.BackColor = Color.White;
                pnl.BorderStyle = BorderStyle.None;
                pnl.Cursor = Cursors.Default;
            };
        }

        public void RefreshStats()
        {
            var products = _productService.GetAllProducts();
            var suppliers = _supplierService.GetAllSuppliers();
            var lowStock = _productService.GetLowStockProducts();
            var transactions = _stockService.GetAllTransactions();

            lblTotalProducts.Text = products.Count.ToString();
            lblTotalSuppliers.Text = suppliers.Count.ToString();
            lblLowStockCount.Text = lowStock.Count.ToString();
            lblTotalTransactions.Text = transactions.Count.ToString();
            
            if (_user != null)
            {
                lblWelcome.Text = $"Welcome Back, {_user.Username}!";
            }
        }
    }
}

// UI Update phase 2 - Author: ousmanseid

// UI Update phase 3 - Author: ousmanseid

// UI Update phase 4 - Author: ousmanseid
