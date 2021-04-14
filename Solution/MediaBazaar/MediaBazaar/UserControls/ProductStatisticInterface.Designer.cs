
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
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lbxDisplayPRevenueProfit = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(1151, 108);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.ReadOnly = true;
            this.nudAmount.Size = new System.Drawing.Size(47, 30);
            this.nudAmount.TabIndex = 11;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(916, 112);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(228, 25);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount of sold products:";
            // 
            // lblStatistics
            // 
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(7, 36);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(1251, 50);
            this.lblStatistics.TabIndex = 9;
            this.lblStatistics.Text = "All products";
            this.lblStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDisplayPRevenueProfit
            // 
            this.lbxDisplayPRevenueProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDisplayPRevenueProfit.FormattingEnabled = true;
            this.lbxDisplayPRevenueProfit.HorizontalExtent = 1000;
            this.lbxDisplayPRevenueProfit.HorizontalScrollbar = true;
            this.lbxDisplayPRevenueProfit.ItemHeight = 25;
            this.lbxDisplayPRevenueProfit.Location = new System.Drawing.Point(3, 141);
            this.lbxDisplayPRevenueProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxDisplayPRevenueProfit.Name = "lbxDisplayPRevenueProfit";
            this.lbxDisplayPRevenueProfit.ScrollAlwaysVisible = true;
            this.lbxDisplayPRevenueProfit.Size = new System.Drawing.Size(1230, 754);
            this.lbxDisplayPRevenueProfit.TabIndex = 8;
            // 
            // ProductStatisticInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStatistics);
            this.Controls.Add(this.lbxDisplayPRevenueProfit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductStatisticInterface";
            this.Size = new System.Drawing.Size(1261, 934);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.ListBox lbxDisplayPRevenueProfit;
    }
}
