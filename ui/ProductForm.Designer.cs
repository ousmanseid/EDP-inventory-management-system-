namespace InventorySystem.UI
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblSecurityWarning;

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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblSecurityWarning = new System.Windows.Forms.Label();
            this.gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            
            // lblSecurityWarning
            this.lblSecurityWarning.AutoSize = true;
            this.lblSecurityWarning.ForeColor = System.Drawing.Color.Red;
            this.lblSecurityWarning.Location = new System.Drawing.Point(40, 310);
            this.lblSecurityWarning.Name = "lblSecurityWarning";
            this.lblSecurityWarning.Size = new System.Drawing.Size(0, 20);
            this.lblSecurityWarning.Visible = false;

            // gbForm
            this.gbForm.BackColor = System.Drawing.Color.White;
            this.gbForm.Controls.Add(this.btnClear);
            this.gbForm.Controls.Add(this.btnDelete);
            this.gbForm.Controls.Add(this.btnUpdate);
            this.gbForm.Controls.Add(this.btnAdd);
            this.gbForm.Controls.Add(this.txtQuantity);
            this.gbForm.Controls.Add(this.lblQuantity);
            this.gbForm.Controls.Add(this.txtPrice);
            this.gbForm.Controls.Add(this.lblPrice);
            this.gbForm.Controls.Add(this.txtCategory);
            this.gbForm.Controls.Add(this.lblCategory);
            this.gbForm.Controls.Add(this.txtName);
            this.gbForm.Controls.Add(this.lblName);
            this.gbForm.Controls.Add(this.txtId);
            this.gbForm.Controls.Add(this.lblId);
            this.gbForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.gbForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbForm.Location = new System.Drawing.Point(30, 20);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(890, 260);
            this.gbForm.Text = "Manage Product Details";
            
            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(30, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(96, 23);
            this.lblId.Text = "Product ID:";
            
            // txtId
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtId.Location = new System.Drawing.Point(130, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 32);
            
            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.Location = new System.Drawing.Point(450, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 23);
            this.lblPrice.Text = "Price:";
            
            // txtPrice
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrice.Location = new System.Drawing.Point(550, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 32);

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(30, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 23);
            this.lblName.Text = "Name:";
            
            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(130, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 32);
            
            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(450, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 23);
            this.lblQuantity.Text = "Quantity:";
            
            // txtQuantity
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(550, 96);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 32);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(30, 150);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 23);
            this.lblCategory.Text = "Category:";
            
            // txtCategory
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCategory.Location = new System.Drawing.Point(130, 146);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(250, 32);
            
            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(130, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            
            // btnUpdate
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(270, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            
            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(410, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            
            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(550, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            
            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.Location = new System.Drawing.Point(30, 300);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(890, 350);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            
            // ProductForm
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 680);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.lblSecurityWarning);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

// UI Update phase 2 - Author: ousmanseid

// UI Update phase 3 - Author: ousmanseid
