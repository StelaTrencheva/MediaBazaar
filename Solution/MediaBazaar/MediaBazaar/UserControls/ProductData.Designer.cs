
namespace MediaBazaar
{
    partial class ProductData
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
            this.lbxProductDisplay = new System.Windows.Forms.ListBox();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.HorizontalScrollbar = true;
            this.lbxProductDisplay.ItemHeight = 29;
            this.lbxProductDisplay.Location = new System.Drawing.Point(0, 56);
            this.lbxProductDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.ScrollAlwaysVisible = true;
            this.lbxProductDisplay.Size = new System.Drawing.Size(998, 584);
            this.lbxProductDisplay.TabIndex = 0;
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProducts.Location = new System.Drawing.Point(-1, 9);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(1001, 43);
            this.lblAllProducts.TabIndex = 1;
            this.lblAllProducts.Text = "All products in the store";
            this.lblAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxProductDisplay);
            this.Controls.Add(this.lblAllProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductData";
            this.Size = new System.Drawing.Size(1001, 662);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProductDisplay;
        private System.Windows.Forms.Label lblAllProducts;
    }
}
