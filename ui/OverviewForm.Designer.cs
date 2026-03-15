namespace InventorySystem.UI
{
    partial class OverviewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHero;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHeroSubtext;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Label lblTitle4;

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
            this.pnlHero = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblHeroSubtext = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.card1 = new System.Windows.Forms.Panel();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Panel();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.card4 = new System.Windows.Forms.Panel();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.pnlHero.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHero
            // 
            this.pnlHero.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.pnlHero.Controls.Add(this.lblWelcome);
            this.pnlHero.Controls.Add(this.lblHeroSubtext);
            this.pnlHero.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHero.Location = new System.Drawing.Point(0, 0);
            this.pnlHero.Name = "pnlHero";
            this.pnlHero.Size = new System.Drawing.Size(950, 180);
            this.pnlHero.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(40, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(480, 60);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Back, Admin";
            // 
            // lblHeroSubtext
            // 
            this.lblHeroSubtext.AutoSize = true;
            this.lblHeroSubtext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHeroSubtext.ForeColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.lblHeroSubtext.Location = new System.Drawing.Point(45, 105);
            this.lblHeroSubtext.Name = "lblHeroSubtext";
            this.lblHeroSubtext.Size = new System.Drawing.Size(430, 28);
            this.lblHeroSubtext.TabIndex = 1;
            this.lblHeroSubtext.Text = "Manage your inventory efficiently and stay organized.";
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Controls.Add(this.card1);
            this.flowLayout.Controls.Add(this.card2);
            this.flowLayout.Controls.Add(this.card3);
            this.flowLayout.Controls.Add(this.card4);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.Location = new System.Drawing.Point(0, 180);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayout.Size = new System.Drawing.Size(950, 500);
            this.flowLayout.TabIndex = 1;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.Controls.Add(this.lblTitle1);
            this.card1.Controls.Add(this.lblTotalProducts);
            this.card1.Location = new System.Drawing.Point(45, 45);
            this.card1.Margin = new System.Windows.Forms.Padding(15);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(240, 160);
            this.card1.TabIndex = 0;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle1.Location = new System.Drawing.Point(20, 20);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(133, 25);
            this.lblTitle1.Text = "📦 Total Products";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalProducts.Location = new System.Drawing.Point(20, 65);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(53, 62);
            this.lblTotalProducts.Text = "0";
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.Controls.Add(this.lblTitle2);
            this.card2.Controls.Add(this.lblTotalSuppliers);
            this.card2.Location = new System.Drawing.Point(315, 45);
            this.card2.Margin = new System.Windows.Forms.Padding(15);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(240, 160);
            this.card2.TabIndex = 1;
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle2.Location = new System.Drawing.Point(20, 20);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(138, 25);
            this.lblTitle2.Text = "🏢 Total Suppliers";
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = true;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalSuppliers.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalSuppliers.Location = new System.Drawing.Point(20, 65);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(53, 62);
            this.lblTotalSuppliers.Text = "0";
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.Controls.Add(this.lblTitle3);
            this.card3.Controls.Add(this.lblLowStockCount);
            this.card3.Location = new System.Drawing.Point(585, 45);
            this.card3.Margin = new System.Windows.Forms.Padding(15);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(240, 160);
            this.card3.TabIndex = 2;
            this.card3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle3.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle3.Location = new System.Drawing.Point(20, 20);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(143, 25);
            this.lblTitle3.Text = "⚠️ Low Stock Alert";
            // 
            // lblLowStockCount
            // 
            this.lblLowStockCount.AutoSize = true;
            this.lblLowStockCount.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblLowStockCount.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblLowStockCount.Location = new System.Drawing.Point(20, 65);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(53, 62);
            this.lblLowStockCount.Text = "0";
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.White;
            this.card4.Controls.Add(this.lblTitle4);
            this.card4.Controls.Add(this.lblTotalTransactions);
            this.card4.Location = new System.Drawing.Point(45, 235);
            this.card4.Margin = new System.Windows.Forms.Padding(15);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(240, 160);
            this.card4.TabIndex = 3;
            this.card4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle4.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle4.Location = new System.Drawing.Point(20, 20);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(152, 25);
            this.lblTitle4.Text = "⚡ Recent Activities";
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTotalTransactions.Location = new System.Drawing.Point(20, 65);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(53, 62);
            this.lblTotalTransactions.Text = "0";
            // 
            // OverviewForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(950, 680);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.pnlHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverviewForm";
            this.Text = "Premium Dashboard";
            this.pnlHero.ResumeLayout(false);
            this.pnlHero.PerformLayout();
            this.flowLayout.ResumeLayout(false);
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

// UI Update phase 2 - Author: ousmanseid

// UI Update phase 3 - Author: ousmanseid

// UI Update phase 4 - Author: ousmanseid
