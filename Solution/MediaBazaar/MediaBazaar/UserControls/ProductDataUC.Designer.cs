﻿
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
            this.btnViewPInfo = new System.Windows.Forms.Button();
            this.lbxProductDisplay = new System.Windows.Forms.ListBox();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewPInfo
            // 
            this.btnViewPInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewPInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPInfo.Location = new System.Drawing.Point(755, 88);
            this.btnViewPInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPInfo.Name = "btnViewPInfo";
            this.btnViewPInfo.Size = new System.Drawing.Size(388, 78);
            this.btnViewPInfo.TabIndex = 86;
            this.btnViewPInfo.Text = "View product information";
            this.btnViewPInfo.UseVisualStyleBackColor = false;
            this.btnViewPInfo.Click += new System.EventHandler(this.btnViewPInfo_Click);
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.HorizontalScrollbar = true;
            this.lbxProductDisplay.ItemHeight = 25;
            this.lbxProductDisplay.Location = new System.Drawing.Point(2, 88);
            this.lbxProductDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.Size = new System.Drawing.Size(745, 829);
            this.lbxProductDisplay.TabIndex = 84;
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProducts.Location = new System.Drawing.Point(1, 15);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(1259, 69);
            this.lblAllProducts.TabIndex = 85;
            this.lblAllProducts.Text = "All products in the store";
            this.lblAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewPInfo);
            this.Controls.Add(this.lbxProductDisplay);
            this.Controls.Add(this.lblAllProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductData";
            this.Size = new System.Drawing.Size(1261, 934);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewPInfo;
        private System.Windows.Forms.ListBox lbxProductDisplay;
        private System.Windows.Forms.Label lblAllProducts;
    }
}