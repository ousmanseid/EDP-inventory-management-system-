using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.Services;

namespace InventorySystem.UI
{
    public partial class StockForm : Form
    {
        private ProductService _productService;
        private StockService _stockService;
        private MainDashboard _dashboard;

        public StockForm()
        {
            _productService = new ProductService();
            _stockService = new StockService();
            InitializeComponent();
        }

        public StockForm(MainDashboard dashboard) : this()
        {
            _dashboard = dashboard;
            ApplySecurityRestrictions();
        }

        private void ApplySecurityRestrictions()
        {
            if (_dashboard != null)
            {
                // Staff restriction: Cannot manually increase stock (Only 'OUT' allowed)
                if (_dashboard.CurrentUser.Role == "Staff")
                {
                    cbType.Items.Clear();
                    cbType.Items.Add("OUT");
                    cbType.SelectedIndex = 0;
                    lblSecurityInfo.Text = "⚠️ Staff: Only 'OUT' transactions allowed.";
                }

                // SuperAdmin feature: Delete History
                btnDeleteHistory.Visible = (_dashboard.CurrentUser.Role == "SuperAdmin");
            }
        }

        private void btnDeleteHistory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to CLEAR ALL transaction history?", "DANGER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _stockService.ClearAllTransactions();
                RefreshTransactions();
            }
        }

        public void RefreshProducts()
        {
            cbProduct.DataSource = null;
            cbProduct.DataSource = _productService.GetAllProducts();
            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ProductId";
            RefreshTransactions();
        }

        private void RefreshTransactions()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = _stockService.GetAllTransactions();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cbProduct.SelectedValue == null) return;

            string productId = cbProduct.SelectedValue.ToString();
            string type = cbType.Text;

            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                bool success = _stockService.RecordTransaction(productId, quantity, type);
                if (success)
                {
                    MessageBox.Show("Transaction saved successfully!");
                    txtQuantity.Clear();
                    RefreshTransactions();
                    if (_dashboard != null) _dashboard.CheckLowStock();
                }
                else
                {
                    MessageBox.Show("Failed to save transaction (e.g. not enough stock to remove).");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Error");
            }
        }
    }
}
