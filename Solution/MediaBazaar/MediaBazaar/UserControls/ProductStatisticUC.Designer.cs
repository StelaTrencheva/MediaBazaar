
namespace MediaBazaar
{
    partial class ProductStatisticInterface
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lbxDisplayPRevenueProfit = new System.Windows.Forms.ListBox();
            this.gbxProductInformation = new System.Windows.Forms.GroupBox();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblPriceSale = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblSoldProducts = new System.Windows.Forms.Label();
            this.pnlAmountInWarehouse = new System.Windows.Forms.Panel();
            this.lblAmountOfSoldProducts = new System.Windows.Forms.Label();
            this.gbxProductInformation.SuspendLayout();
            this.pnlAmountInWarehouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatistics
            // 
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatistics.Location = new System.Drawing.Point(26, 28);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(255, 40);
            this.lblStatistics.TabIndex = 9;
            this.lblStatistics.Text = "Product Statistics";
            // 
            // lbxDisplayPRevenueProfit
            // 
            this.lbxDisplayPRevenueProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDisplayPRevenueProfit.FormattingEnabled = true;
            this.lbxDisplayPRevenueProfit.HorizontalExtent = 1000;
            this.lbxDisplayPRevenueProfit.HorizontalScrollbar = true;
            this.lbxDisplayPRevenueProfit.ItemHeight = 25;
            this.lbxDisplayPRevenueProfit.Location = new System.Drawing.Point(32, 82);
            this.lbxDisplayPRevenueProfit.Name = "lbxDisplayPRevenueProfit";
            this.lbxDisplayPRevenueProfit.ScrollAlwaysVisible = true;
            this.lbxDisplayPRevenueProfit.Size = new System.Drawing.Size(509, 479);
            this.lbxDisplayPRevenueProfit.TabIndex = 8;
            this.lbxDisplayPRevenueProfit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxDisplayPRevenueProfit_DrawItem);
            this.lbxDisplayPRevenueProfit.DoubleClick += new System.EventHandler(this.lbxDisplayPRevenueProfit_DoubleClick);
            this.lbxDisplayPRevenueProfit.MouseLeave += new System.EventHandler(this.lbxDisplayPRevenueProfit_MouseLeave);
            this.lbxDisplayPRevenueProfit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxDisplayPRevenueProfit_MouseMove);
            // 
            // gbxProductInformation
            // 
            this.gbxProductInformation.BackColor = System.Drawing.Color.White;
            this.gbxProductInformation.Controls.Add(this.pnlAmountInWarehouse);
            this.gbxProductInformation.Controls.Add(this.lblSoldProducts);
            this.gbxProductInformation.Controls.Add(this.lblCostPrice);
            this.gbxProductInformation.Controls.Add(this.lblPriceCost);
            this.gbxProductInformation.Controls.Add(this.lblSalePrice);
            this.gbxProductInformation.Controls.Add(this.lblPriceSale);
            this.gbxProductInformation.Controls.Add(this.lblProductDescription);
            this.gbxProductInformation.Controls.Add(this.lblProductBrand);
            this.gbxProductInformation.Controls.Add(this.lblProductTypeAndModel);
            this.gbxProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxProductInformation.Location = new System.Drawing.Point(569, 82);
            this.gbxProductInformation.Name = "gbxProductInformation";
            this.gbxProductInformation.Size = new System.Drawing.Size(517, 479);
            this.gbxProductInformation.TabIndex = 10;
            this.gbxProductInformation.TabStop = false;
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(30, 84);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 1;
            this.lblProductBrand.Text = "Brand ";
            // 
            // lblProductTypeAndModel
            // 
            this.lblProductTypeAndModel.AutoSize = true;
            this.lblProductTypeAndModel.Location = new System.Drawing.Point(30, 31);
            this.lblProductTypeAndModel.Name = "lblProductTypeAndModel";
            this.lblProductTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblProductTypeAndModel.TabIndex = 0;
            this.lblProductTypeAndModel.Text = "Type and model";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(30, 138);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(135, 29);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Description";
            // 
            // lblPriceSale
            // 
            this.lblPriceSale.AutoSize = true;
            this.lblPriceSale.Location = new System.Drawing.Point(30, 192);
            this.lblPriceSale.Name = "lblPriceSale";
            this.lblPriceSale.Size = new System.Drawing.Size(134, 29);
            this.lblPriceSale.TabIndex = 3;
            this.lblPriceSale.Text = "Sale price: ";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblSalePrice.Location = new System.Drawing.Point(235, 189);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(49, 32);
            this.lblSalePrice.TabIndex = 4;
            this.lblSalePrice.Text = "00";
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.Location = new System.Drawing.Point(30, 256);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.Size = new System.Drawing.Size(128, 29);
            this.lblPriceCost.TabIndex = 5;
            this.lblPriceCost.Text = "Cost price:";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCostPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblCostPrice.Location = new System.Drawing.Point(235, 256);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(49, 32);
            this.lblCostPrice.TabIndex = 6;
            this.lblCostPrice.Text = "00";
            // 
            // lblSoldProducts
            // 
            this.lblSoldProducts.AutoSize = true;
            this.lblSoldProducts.Location = new System.Drawing.Point(30, 323);
            this.lblSoldProducts.Name = "lblSoldProducts";
            this.lblSoldProducts.Size = new System.Drawing.Size(253, 29);
            this.lblSoldProducts.TabIndex = 7;
            this.lblSoldProducts.Text = "Sold products in store:";
            // 
            // pnlAmountInWarehouse
            // 
            this.pnlAmountInWarehouse.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlAmountInWarehouse.Controls.Add(this.lblAmountOfSoldProducts);
            this.pnlAmountInWarehouse.Location = new System.Drawing.Point(241, 377);
            this.pnlAmountInWarehouse.Name = "pnlAmountInWarehouse";
            this.pnlAmountInWarehouse.Size = new System.Drawing.Size(178, 63);
            this.pnlAmountInWarehouse.TabIndex = 8;
            // 
            // lblAmountOfSoldProducts
            // 
            this.lblAmountOfSoldProducts.AutoSize = true;
            this.lblAmountOfSoldProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountOfSoldProducts.Location = new System.Drawing.Point(71, 16);
            this.lblAmountOfSoldProducts.Name = "lblAmountOfSoldProducts";
            this.lblAmountOfSoldProducts.Size = new System.Drawing.Size(39, 29);
            this.lblAmountOfSoldProducts.TabIndex = 5;
            this.lblAmountOfSoldProducts.Text = "00";
            // 
            // ProductStatisticInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxProductInformation);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lbxDisplayPRevenueProfit);
            this.Name = "ProductStatisticInterface";
            this.Size = new System.Drawing.Size(1121, 747);
            this.gbxProductInformation.ResumeLayout(false);
            this.gbxProductInformation.PerformLayout();
            this.pnlAmountInWarehouse.ResumeLayout(false);
            this.pnlAmountInWarehouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.ListBox lbxDisplayPRevenueProfit;
        private System.Windows.Forms.GroupBox gbxProductInformation;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPriceSale;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label lblSoldProducts;
        private System.Windows.Forms.Panel pnlAmountInWarehouse;
        private System.Windows.Forms.Label lblAmountOfSoldProducts;
    }
}
