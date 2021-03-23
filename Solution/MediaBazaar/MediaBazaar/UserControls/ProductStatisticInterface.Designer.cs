
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
            this.lbxDisplayPRevenueProfit = new System.Windows.Forms.ListBox();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxDisplayPRevenueProfit
            // 
            this.lbxDisplayPRevenueProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDisplayPRevenueProfit.FormattingEnabled = true;
            this.lbxDisplayPRevenueProfit.HorizontalExtent = 1000;
            this.lbxDisplayPRevenueProfit.HorizontalScrollbar = true;
            this.lbxDisplayPRevenueProfit.ItemHeight = 25;
            this.lbxDisplayPRevenueProfit.Location = new System.Drawing.Point(7, 121);
            this.lbxDisplayPRevenueProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxDisplayPRevenueProfit.Name = "lbxDisplayPRevenueProfit";
            this.lbxDisplayPRevenueProfit.ScrollAlwaysVisible = true;
            this.lbxDisplayPRevenueProfit.Size = new System.Drawing.Size(994, 529);
            this.lbxDisplayPRevenueProfit.TabIndex = 2;
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.Location = new System.Drawing.Point(404, 41);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(138, 26);
            this.lblStatistics.TabIndex = 4;
            this.lblStatistics.Text = "All products";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(677, 64);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(228, 25);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount of sold products:";
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(920, 59);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.ReadOnly = true;
            this.nudAmount.Size = new System.Drawing.Size(63, 30);
            this.nudAmount.TabIndex = 7;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
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
            this.Size = new System.Drawing.Size(1001, 662);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxDisplayPRevenueProfit;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}
