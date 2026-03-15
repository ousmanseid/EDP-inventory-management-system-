namespace InventorySystem.UI
{
    partial class ReportView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label lblSuppliersTitle;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblStockTitle;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.lblSuppliersTitle = new System.Windows.Forms.Label();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.lblStockTitle = new System.Windows.Forms.Label();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlSuppliers.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(515, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Summary Report";
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.pnlProducts, 0, 0);
            this.tableLayout.Controls.Add(this.pnlSuppliers, 1, 0);
            this.tableLayout.Controls.Add(this.pnlStock, 0, 1);
            this.tableLayout.Controls.Add(this.pnlLowStock, 1, 1);
            this.tableLayout.Location = new System.Drawing.Point(30, 90);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayout.Size = new System.Drawing.Size(890, 560);
            this.tableLayout.TabIndex = 1;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.lblProductsTitle);
            this.pnlProducts.Controls.Add(this.lblTotalProducts);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(15, 15);
            this.pnlProducts.Margin = new System.Windows.Forms.Padding(15);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(415, 250);
            this.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.AutoSize = true;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblProductsTitle.Location = new System.Drawing.Point(30, 30);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(193, 37);
            this.lblProductsTitle.Text = "📦 Total Products";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalProducts.Location = new System.Drawing.Point(30, 80);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(91, 106);
            this.lblTotalProducts.Text = "0";
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.BackColor = System.Drawing.Color.White;
            this.pnlSuppliers.Controls.Add(this.lblSuppliersTitle);
            this.pnlSuppliers.Controls.Add(this.lblTotalSuppliers);
            this.pnlSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSuppliers.Location = new System.Drawing.Point(460, 15);
            this.pnlSuppliers.Margin = new System.Windows.Forms.Padding(15);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(415, 250);
            this.pnlSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblSuppliersTitle
            // 
            this.lblSuppliersTitle.AutoSize = true;
            this.lblSuppliersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSuppliersTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSuppliersTitle.Location = new System.Drawing.Point(30, 30);
            this.lblSuppliersTitle.Name = "lblSuppliersTitle";
            this.lblSuppliersTitle.Size = new System.Drawing.Size(199, 37);
            this.lblSuppliersTitle.Text = "🏢 Total Suppliers";
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = true;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
            this.lblTotalSuppliers.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalSuppliers.Location = new System.Drawing.Point(30, 80);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(91, 106);
            this.lblTotalSuppliers.Text = "0";
            // 
            // pnlStock
            // 
            this.pnlStock.BackColor = System.Drawing.Color.White;
            this.pnlStock.Controls.Add(this.lblStockTitle);
            this.pnlStock.Controls.Add(this.lblTotalStock);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(15, 295);
            this.pnlStock.Margin = new System.Windows.Forms.Padding(15);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(415, 250);
            this.pnlStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblStockTitle
            // 
            this.lblStockTitle.AutoSize = true;
            this.lblStockTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblStockTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStockTitle.Location = new System.Drawing.Point(30, 30);
            this.lblStockTitle.Name = "lblStockTitle";
            this.lblStockTitle.Size = new System.Drawing.Size(225, 37);
            this.lblStockTitle.Text = "📈 Total Stock Units";
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
            this.lblTotalStock.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalStock.Location = new System.Drawing.Point(30, 80);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(91, 106);
            this.lblTotalStock.Text = "0";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(460, 295);
            this.pnlLowStock.Margin = new System.Windows.Forms.Padding(15);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(415, 250);
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblLowStockTitle.Location = new System.Drawing.Point(30, 30);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(217, 37);
            this.lblLowStockTitle.Text = "⚠️ Low Stock Items";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblLowStock.Location = new System.Drawing.Point(30, 80);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(91, 106);
            this.lblLowStock.Text = "0";
            // 
            // ReportView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(950, 680);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportView";
            this.Text = "Report View";
            this.tableLayout.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            this.pnlSuppliers.ResumeLayout(false);
            this.pnlSuppliers.PerformLayout();
            this.pnlStock.ResumeLayout(false);
            this.pnlStock.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

// UI Update phase 2 - Author: ousmanseid
