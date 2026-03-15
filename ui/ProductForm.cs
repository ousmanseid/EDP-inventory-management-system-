using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.Models;
using InventorySystem.Services;

namespace InventorySystem.UI
{
    public partial class ProductForm : Form
    {
        private ProductService _productService;
        private MainDashboard _dashboard;

        public ProductForm()
        {
            _productService = new ProductService();
            InitializeComponent();
        }

        public ProductForm(MainDashboard dashboard) : this()
        {
            _dashboard = dashboard;
            RefreshTable();
            ApplySecurityRestrictions();
        }

        private void ApplySecurityRestrictions()
        {
            if (_dashboard != null && _dashboard.CurrentUser.Role == "Staff")
            {
                txtPrice.Enabled = false;
                txtQuantity.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                lblSecurityWarning.Visible = true;
                lblSecurityWarning.Text = "⚠️ Staff: Price/Stock changes restricted.";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("ID and Name are required.");
                return;
            }

            if (_productService.GetProductById(txtId.Text) != null)
            {
                MessageBox.Show("Product ID already exists!");
                return;
            }

            if (double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtQuantity.Text, out int qty))
            {
                Product p = new Product(txtId.Text, txtName.Text, txtCategory.Text, price, qty);
                _productService.AddProduct(p);
                MessageBox.Show("Product Added!");
                RefreshTable();
                ClearFields();
                if (_dashboard != null) _dashboard.CheckLowStock();
            }
            else
            {
                MessageBox.Show("Invalid price or quantity.");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return;

            if (double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtQuantity.Text, out int qty))
            {
                Product p = new Product(txtId.Text, txtName.Text, txtCategory.Text, price, qty);
                _productService.UpdateProduct(p);
                MessageBox.Show("Product Updated!");
                RefreshTable();
                ClearFields();
                if (_dashboard != null) _dashboard.CheckLowStock();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return;

            if (MessageBox.Show($"Delete product {txtId.Text}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _productService.DeleteProduct(txtId.Text);
                RefreshTable();
                ClearFields();
                if (_dashboard != null) _dashboard.CheckLowStock();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtId.Enabled = true;
        }

        public void RefreshTable()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _productService.GetAllProducts();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var row = dataGridView.SelectedRows[0];
                txtId.Text = row.Cells["ProductId"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtId.Enabled = false; // Prevent modifying ID
            }
        }
    }
}

// UI Update phase 2 - Author: ousmanseid
