using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.Services;

namespace InventorySystem.UI
{
    public partial class ReportView : Form
    {
        private MainDashboard _dashboard;
        private ProductService _productService;
        private SupplierService _supplierService;
        private StockService _stockService;

        public ReportView(MainDashboard dashboard)
        {
            _dashboard = dashboard;
            _productService = new ProductService();
            _supplierService = new SupplierService();
            _stockService = new StockService();

            InitializeComponent();
            SetupInteractivity();
        }

        private void SetupInteractivity()
        {
            // Panel hover effects and clicks for interactivity
            pnlProducts.MouseEnter += (s, e) => { pnlProducts.BackColor = Color.White; pnlProducts.Cursor = Cursors.Hand; };
            pnlProducts.MouseLeave += (s, e) => { pnlProducts.BackColor = Color.FromArgb(235, 245, 255); pnlProducts.Cursor = Cursors.Default; };
            pnlProducts.Click += (s, e) => _dashboard.NavigateToProducts();
            
            pnlSuppliers.MouseEnter += (s, e) => { pnlSuppliers.BackColor = Color.White; pnlSuppliers.Cursor = Cursors.Hand; };
            pnlSuppliers.MouseLeave += (s, e) => { pnlSuppliers.BackColor = Color.FromArgb(235, 250, 240); pnlSuppliers.Cursor = Cursors.Default; };
            pnlSuppliers.Click += (s, e) => _dashboard.NavigateToSuppliers();

            pnlStock.MouseEnter += (s, e) => { pnlStock.BackColor = Color.White; pnlStock.Cursor = Cursors.Hand; };
            pnlStock.MouseLeave += (s, e) => { pnlStock.BackColor = Color.FromArgb(255, 250, 235); pnlStock.Cursor = Cursors.Default; };
            pnlStock.Click += (s, e) => _dashboard.NavigateToStock();

            pnlLowStock.MouseEnter += (s, e) => { pnlLowStock.BackColor = Color.White; pnlLowStock.Cursor = Cursors.Hand; };
            pnlLowStock.MouseLeave += (s, e) => { pnlLowStock.BackColor = Color.FromArgb(255, 240, 240); pnlLowStock.Cursor = Cursors.Default; };
            pnlLowStock.Click += (s, e) => _dashboard.NavigateToSearchInfo(); 
        }

        public void RefreshReport()
        {
            var products = _productService.GetAllProducts();
            int totalStockUnits = 0;
            foreach (var p in products)
            {
                totalStockUnits += p.Quantity;
            }

            lblTotalProducts.Text = products.Count.ToString();
            lblTotalSuppliers.Text = _supplierService.GetAllSuppliers().Count.ToString();
            lblTotalStock.Text = totalStockUnits.ToString();
            lblLowStock.Text = _productService.GetLowStockProducts().Count.ToString();
        }
    }
}
