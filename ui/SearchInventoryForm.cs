using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.Services;

namespace InventorySystem.UI
{
    public partial class SearchInventoryForm : Form
    {
        private ProductService _productService;

        public SearchInventoryForm()
        {
            _productService = new ProductService();
            InitializeComponent();
            RefreshTable();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var results = _productService.SearchProducts(txtSearchName.Text, txtSearchCategory.Text);
            dataGridView.DataSource = null;
            dataGridView.DataSource = results;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtSearchCategory.Clear();
            RefreshTable();
        }

        public void RefreshTable()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _productService.GetAllProducts();
        }
    }
}

// UI Update phase 2 - Author: ousmanseid

// UI Update phase 3 - Author: ousmanseid

// UI Update phase 4 - Author: ousmanseid
