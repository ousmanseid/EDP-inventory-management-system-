using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.Models;
using InventorySystem.Services;

namespace InventorySystem.UI
{
    public partial class SupplierForm : Form
    {
        private SupplierService _supplierService;

        public SupplierForm()
        {
            _supplierService = new SupplierService();
            InitializeComponent();
            RefreshTable();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier(txtId.Text, txtName.Text, txtContact.Text, txtAddress.Text);
            _supplierService.AddSupplier(s);
            RefreshTable();
            ClearFields();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier(txtId.Text, txtName.Text, txtContact.Text, txtAddress.Text);
            _supplierService.UpdateSupplier(s);
            RefreshTable();
            ClearFields();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _supplierService.DeleteSupplier(txtId.Text);
            RefreshTable();
            ClearFields();
        }

        private void BtnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtId.Enabled = true;
        }

        public void RefreshTable()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _supplierService.GetAllSuppliers();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var row = dataGridView.SelectedRows[0];
                txtId.Text = row.Cells["SupplierId"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtId.Enabled = false;
            }
        }
    }
}
