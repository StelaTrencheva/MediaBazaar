
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
            this.btnShowPRevenueProfit = new System.Windows.Forms.Button();
            this.lbxDisplayPRevenueProfit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowPRevenueProfit
            // 
            this.btnShowPRevenueProfit.Location = new System.Drawing.Point(294, 221);
            this.btnShowPRevenueProfit.Name = "btnShowPRevenueProfit";
            this.btnShowPRevenueProfit.Size = new System.Drawing.Size(301, 33);
            this.btnShowPRevenueProfit.TabIndex = 3;
            this.btnShowPRevenueProfit.Text = "Show product revenue and profit";
            this.btnShowPRevenueProfit.UseVisualStyleBackColor = true;
            this.btnShowPRevenueProfit.Click += new System.EventHandler(this.btnShowPRevenueProfit_Click);
            // 
            // lbxDisplayPRevenueProfit
            // 
            this.lbxDisplayPRevenueProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDisplayPRevenueProfit.FormattingEnabled = true;
            this.lbxDisplayPRevenueProfit.HorizontalExtent = 1000;
            this.lbxDisplayPRevenueProfit.HorizontalScrollbar = true;
            this.lbxDisplayPRevenueProfit.ItemHeight = 20;
            this.lbxDisplayPRevenueProfit.Location = new System.Drawing.Point(3, 3);
            this.lbxDisplayPRevenueProfit.Name = "lbxDisplayPRevenueProfit";
            this.lbxDisplayPRevenueProfit.ScrollAlwaysVisible = true;
            this.lbxDisplayPRevenueProfit.Size = new System.Drawing.Size(884, 204);
            this.lbxDisplayPRevenueProfit.TabIndex = 2;
            // 
            // ProductStatisticInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowPRevenueProfit);
            this.Controls.Add(this.lbxDisplayPRevenueProfit);
            this.Name = "ProductStatisticInterface";
            this.Size = new System.Drawing.Size(890, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPRevenueProfit;
        private System.Windows.Forms.ListBox lbxDisplayPRevenueProfit;
    }
}
