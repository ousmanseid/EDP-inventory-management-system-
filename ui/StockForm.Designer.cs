namespace InventorySystem.UI
{
    partial class StockForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label lblSecurityInfo;
        private System.Windows.Forms.Button btnDeleteHistory;

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
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            
            // gbForm
            this.gbForm.BackColor = System.Drawing.Color.White;
            this.gbForm.Controls.Add(this.btnSave);
            this.gbForm.Controls.Add(this.txtQuantity);
            this.gbForm.Controls.Add(this.lblQuantity);
            this.gbForm.Controls.Add(this.cbType);
            this.gbForm.Controls.Add(this.lblType);
            this.gbForm.Controls.Add(this.cbProduct);
            this.gbForm.Controls.Add(this.lblProduct);
            this.gbForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbForm.Location = new System.Drawing.Point(30, 20);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(890, 160);
            this.gbForm.Text = "Manage Stock Adjustments";
            
            // lblProduct
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProduct.Location = new System.Drawing.Point(30, 50);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(74, 23);
            this.lblProduct.Text = "Product:";
            
            // cbProduct
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbProduct.Location = new System.Drawing.Point(120, 46);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(260, 33);
            
            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblType.Location = new System.Drawing.Point(440, 50);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 23);
            this.lblType.Text = "Type:";
            
            // cbType
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] { "ADD", "REMOVE" });
            this.cbType.SelectedIndex = 0;
            this.cbType.Location = new System.Drawing.Point(520, 46);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(280, 33);
            
            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(30, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 23);
            this.lblQuantity.Text = "Quantity:";
            
            // txtQuantity
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(120, 96);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 32);
            
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(520, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "Save Transaction";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            
            // dgvTransactions
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransactions.Location = new System.Drawing.Point(30, 220);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowTemplate.Height = 30;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(890, 430);
            
            // lblSecurityInfo
            this.lblSecurityInfo = new System.Windows.Forms.Label();
            this.lblSecurityInfo.AutoSize = true;
            this.lblSecurityInfo.ForeColor = System.Drawing.Color.Red;
            this.lblSecurityInfo.Location = new System.Drawing.Point(30, 180);
            this.lblSecurityInfo.Name = "lblSecurityInfo";
            this.lblSecurityInfo.Size = new System.Drawing.Size(0, 20);

            // btnDeleteHistory
            this.btnDeleteHistory = new System.Windows.Forms.Button();
            this.btnDeleteHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHistory.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHistory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHistory.Location = new System.Drawing.Point(740, 182);
            this.btnDeleteHistory.Name = "btnDeleteHistory";
            this.btnDeleteHistory.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteHistory.Text = "🗑 Clear All History";
            this.btnDeleteHistory.Visible = false;
            this.btnDeleteHistory.Click += new System.EventHandler(this.btnDeleteHistory_Click);

            // StockForm
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 680);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.lblSecurityInfo);
            this.Controls.Add(this.btnDeleteHistory);
            this.Name = "StockForm";
            this.Text = "Stock Form";
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
