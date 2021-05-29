
namespace MediaBazaar
{
    partial class AddProductInterface
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
            this.tcProducts = new System.Windows.Forms.TabControl();
            this.tpAllProducts = new System.Windows.Forms.TabPage();
            this.btnViewProductInfo = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lbxProductDisplay = new System.Windows.Forms.ListBox();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductModel = new System.Windows.Forms.Label();
            this.tbxProductAmountInWarehouse = new System.Windows.Forms.TextBox();
            this.tbxProductModel = new System.Windows.Forms.TextBox();
            this.lblProductAmountInWarehouse = new System.Windows.Forms.Label();
            this.tbxProductCategory = new System.Windows.Forms.TextBox();
            this.tbxProductAmountInStore = new System.Windows.Forms.TextBox();
            this.lblProductSubCategory = new System.Windows.Forms.Label();
            this.lblProductAmountInStore = new System.Windows.Forms.Label();
            this.tbxProductSubCategory = new System.Windows.Forms.TextBox();
            this.tbxProductSalesPrice = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductSalesPrice = new System.Windows.Forms.Label();
            this.tbxProductType = new System.Windows.Forms.TextBox();
            this.tbxProductCostPrice = new System.Windows.Forms.TextBox();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductCostPrice = new System.Windows.Forms.Label();
            this.tbxProductBrand = new System.Windows.Forms.TextBox();
            this.tbxProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.tcProducts.SuspendLayout();
            this.tpAllProducts.SuspendLayout();
            this.tpAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProducts
            // 
            this.tcProducts.Controls.Add(this.tpAllProducts);
            this.tcProducts.Controls.Add(this.tpAddProduct);
            this.tcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProducts.Location = new System.Drawing.Point(0, 0);
            this.tcProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcProducts.Name = "tcProducts";
            this.tcProducts.SelectedIndex = 0;
            this.tcProducts.Size = new System.Drawing.Size(1129, 785);
            this.tcProducts.TabIndex = 24;
            // 
            // tpAllProducts
            // 
            this.tpAllProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpAllProducts.Controls.Add(this.btnViewProductInfo);
            this.tpAllProducts.Controls.Add(this.btnDeleteProduct);
            this.tpAllProducts.Controls.Add(this.lblProduct);
            this.tpAllProducts.Controls.Add(this.lbxProductDisplay);
            this.tpAllProducts.Location = new System.Drawing.Point(4, 34);
            this.tpAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllProducts.Name = "tpAllProducts";
            this.tpAllProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllProducts.Size = new System.Drawing.Size(1121, 747);
            this.tpAllProducts.TabIndex = 0;
            this.tpAllProducts.Text = "All Products";
            // 
            // btnViewProductInfo
            // 
            this.btnViewProductInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductInfo.Location = new System.Drawing.Point(634, 118);
            this.btnViewProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProductInfo.Name = "btnViewProductInfo";
            this.btnViewProductInfo.Size = new System.Drawing.Size(242, 57);
            this.btnViewProductInfo.TabIndex = 4;
            this.btnViewProductInfo.Text = "View a product information";
            this.btnViewProductInfo.UseVisualStyleBackColor = false;
            this.btnViewProductInfo.Click += new System.EventHandler(this.btnViewProductInfo_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(634, 215);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(242, 57);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Remove a product\r\n/Only when necessary/";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(6, 17);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(622, 47);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "All products in the store";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.HorizontalScrollbar = true;
            this.lbxProductDisplay.ItemHeight = 25;
            this.lbxProductDisplay.Location = new System.Drawing.Point(3, 67);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.ScrollAlwaysVisible = true;
            this.lbxProductDisplay.Size = new System.Drawing.Size(625, 654);
            this.lbxProductDisplay.TabIndex = 1;
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpAddProduct.Controls.Add(this.tbxBarcode);
            this.tpAddProduct.Controls.Add(this.lbBarcode);
            this.tpAddProduct.Controls.Add(this.lblTitle);
            this.tpAddProduct.Controls.Add(this.lblProductCategory);
            this.tpAddProduct.Controls.Add(this.btnAddProduct);
            this.tpAddProduct.Controls.Add(this.lblProductModel);
            this.tpAddProduct.Controls.Add(this.tbxProductAmountInWarehouse);
            this.tpAddProduct.Controls.Add(this.tbxProductModel);
            this.tpAddProduct.Controls.Add(this.lblProductAmountInWarehouse);
            this.tpAddProduct.Controls.Add(this.tbxProductCategory);
            this.tpAddProduct.Controls.Add(this.tbxProductAmountInStore);
            this.tpAddProduct.Controls.Add(this.lblProductSubCategory);
            this.tpAddProduct.Controls.Add(this.lblProductAmountInStore);
            this.tpAddProduct.Controls.Add(this.tbxProductSubCategory);
            this.tpAddProduct.Controls.Add(this.tbxProductSalesPrice);
            this.tpAddProduct.Controls.Add(this.lblProductType);
            this.tpAddProduct.Controls.Add(this.lblProductSalesPrice);
            this.tpAddProduct.Controls.Add(this.tbxProductType);
            this.tpAddProduct.Controls.Add(this.tbxProductCostPrice);
            this.tpAddProduct.Controls.Add(this.lblProductBrand);
            this.tpAddProduct.Controls.Add(this.lblProductCostPrice);
            this.tpAddProduct.Controls.Add(this.tbxProductBrand);
            this.tpAddProduct.Controls.Add(this.tbxProductDescription);
            this.tpAddProduct.Controls.Add(this.lblProductDescription);
            this.tpAddProduct.Location = new System.Drawing.Point(4, 34);
            this.tpAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddProduct.Size = new System.Drawing.Size(1121, 747);
            this.tpAddProduct.TabIndex = 1;
            this.tpAddProduct.Text = "Add product";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1112, 58);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Add a product";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(163, 118);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(72, 18);
            this.lblProductCategory.TabIndex = 4;
            this.lblProductCategory.Text = "Category:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(139, 496);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(928, 36);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProductModel
            // 
            this.lblProductModel.AutoSize = true;
            this.lblProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductModel.Location = new System.Drawing.Point(181, 274);
            this.lblProductModel.Name = "lblProductModel";
            this.lblProductModel.Size = new System.Drawing.Size(53, 18);
            this.lblProductModel.TabIndex = 2;
            this.lblProductModel.Text = "Model:";
            // 
            // tbxProductAmountInWarehouse
            // 
            this.tbxProductAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductAmountInWarehouse.Location = new System.Drawing.Point(868, 268);
            this.tbxProductAmountInWarehouse.Name = "tbxProductAmountInWarehouse";
            this.tbxProductAmountInWarehouse.Size = new System.Drawing.Size(124, 24);
            this.tbxProductAmountInWarehouse.TabIndex = 21;
            // 
            // tbxProductModel
            // 
            this.tbxProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductModel.Location = new System.Drawing.Point(246, 269);
            this.tbxProductModel.Name = "tbxProductModel";
            this.tbxProductModel.Size = new System.Drawing.Size(120, 24);
            this.tbxProductModel.TabIndex = 3;
            // 
            // lblProductAmountInWarehouse
            // 
            this.lblProductAmountInWarehouse.AutoSize = true;
            this.lblProductAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmountInWarehouse.Location = new System.Drawing.Point(705, 268);
            this.lblProductAmountInWarehouse.Name = "lblProductAmountInWarehouse";
            this.lblProductAmountInWarehouse.Size = new System.Drawing.Size(155, 18);
            this.lblProductAmountInWarehouse.TabIndex = 20;
            this.lblProductAmountInWarehouse.Text = "Amount in warehouse:";
            // 
            // tbxProductCategory
            // 
            this.tbxProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductCategory.Location = new System.Drawing.Point(246, 118);
            this.tbxProductCategory.Name = "tbxProductCategory";
            this.tbxProductCategory.Size = new System.Drawing.Size(120, 24);
            this.tbxProductCategory.TabIndex = 5;
            // 
            // tbxProductAmountInStore
            // 
            this.tbxProductAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductAmountInStore.Location = new System.Drawing.Point(868, 215);
            this.tbxProductAmountInStore.Name = "tbxProductAmountInStore";
            this.tbxProductAmountInStore.Size = new System.Drawing.Size(124, 24);
            this.tbxProductAmountInStore.TabIndex = 19;
            // 
            // lblProductSubCategory
            // 
            this.lblProductSubCategory.AutoSize = true;
            this.lblProductSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSubCategory.Location = new System.Drawing.Point(136, 157);
            this.lblProductSubCategory.Name = "lblProductSubCategory";
            this.lblProductSubCategory.Size = new System.Drawing.Size(99, 18);
            this.lblProductSubCategory.TabIndex = 6;
            this.lblProductSubCategory.Text = "Sub category:";
            // 
            // lblProductAmountInStore
            // 
            this.lblProductAmountInStore.AutoSize = true;
            this.lblProductAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmountInStore.Location = new System.Drawing.Point(741, 215);
            this.lblProductAmountInStore.Name = "lblProductAmountInStore";
            this.lblProductAmountInStore.Size = new System.Drawing.Size(116, 18);
            this.lblProductAmountInStore.TabIndex = 18;
            this.lblProductAmountInStore.Text = "Amount in store:";
            // 
            // tbxProductSubCategory
            // 
            this.tbxProductSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductSubCategory.Location = new System.Drawing.Point(246, 159);
            this.tbxProductSubCategory.Name = "tbxProductSubCategory";
            this.tbxProductSubCategory.Size = new System.Drawing.Size(120, 24);
            this.tbxProductSubCategory.TabIndex = 7;
            // 
            // tbxProductSalesPrice
            // 
            this.tbxProductSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductSalesPrice.Location = new System.Drawing.Point(868, 166);
            this.tbxProductSalesPrice.Name = "tbxProductSalesPrice";
            this.tbxProductSalesPrice.Size = new System.Drawing.Size(124, 24);
            this.tbxProductSalesPrice.TabIndex = 17;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(189, 198);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(44, 18);
            this.lblProductType.TabIndex = 8;
            this.lblProductType.Text = "Type:";
            // 
            // lblProductSalesPrice
            // 
            this.lblProductSalesPrice.AutoSize = true;
            this.lblProductSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSalesPrice.Location = new System.Drawing.Point(772, 166);
            this.lblProductSalesPrice.Name = "lblProductSalesPrice";
            this.lblProductSalesPrice.Size = new System.Drawing.Size(85, 18);
            this.lblProductSalesPrice.TabIndex = 16;
            this.lblProductSalesPrice.Text = "Sales price:";
            // 
            // tbxProductType
            // 
            this.tbxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductType.Location = new System.Drawing.Point(246, 198);
            this.tbxProductType.Name = "tbxProductType";
            this.tbxProductType.Size = new System.Drawing.Size(120, 24);
            this.tbxProductType.TabIndex = 9;
            // 
            // tbxProductCostPrice
            // 
            this.tbxProductCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductCostPrice.Location = new System.Drawing.Point(868, 115);
            this.tbxProductCostPrice.Name = "tbxProductCostPrice";
            this.tbxProductCostPrice.Size = new System.Drawing.Size(124, 24);
            this.tbxProductCostPrice.TabIndex = 15;
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBrand.Location = new System.Drawing.Point(181, 233);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(51, 18);
            this.lblProductBrand.TabIndex = 10;
            this.lblProductBrand.Text = "Brand:";
            // 
            // lblProductCostPrice
            // 
            this.lblProductCostPrice.AutoSize = true;
            this.lblProductCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCostPrice.Location = new System.Drawing.Point(778, 115);
            this.lblProductCostPrice.Name = "lblProductCostPrice";
            this.lblProductCostPrice.Size = new System.Drawing.Size(80, 18);
            this.lblProductCostPrice.TabIndex = 14;
            this.lblProductCostPrice.Text = "Cost price:";
            // 
            // tbxProductBrand
            // 
            this.tbxProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductBrand.Location = new System.Drawing.Point(246, 233);
            this.tbxProductBrand.Name = "tbxProductBrand";
            this.tbxProductBrand.Size = new System.Drawing.Size(120, 24);
            this.tbxProductBrand.TabIndex = 11;
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.Location = new System.Drawing.Point(199, 379);
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.Size = new System.Drawing.Size(793, 64);
            this.tbxProductDescription.TabIndex = 13;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Location = new System.Drawing.Point(199, 343);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(793, 33);
            this.lblProductDescription.TabIndex = 12;
            this.lblProductDescription.Text = "Description:";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBarcode.Location = new System.Drawing.Point(868, 316);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(124, 24);
            this.tbxBarcode.TabIndex = 25;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.Location = new System.Drawing.Point(705, 316);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(68, 18);
            this.lbBarcode.TabIndex = 24;
            this.lbBarcode.Text = "Barcode:";
            // 
            // AddProductInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcProducts);
            this.Name = "AddProductInterface";
            this.Size = new System.Drawing.Size(1129, 785);
            this.Load += new System.EventHandler(this.AddProductInterface_Load);
            this.tcProducts.ResumeLayout(false);
            this.tpAllProducts.ResumeLayout(false);
            this.tpAddProduct.ResumeLayout(false);
            this.tpAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProducts;
        private System.Windows.Forms.TabPage tpAllProducts;
        private System.Windows.Forms.Button btnViewProductInfo;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lbxProductDisplay;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductModel;
        private System.Windows.Forms.TextBox tbxProductAmountInWarehouse;
        private System.Windows.Forms.TextBox tbxProductModel;
        private System.Windows.Forms.Label lblProductAmountInWarehouse;
        private System.Windows.Forms.TextBox tbxProductCategory;
        private System.Windows.Forms.TextBox tbxProductAmountInStore;
        private System.Windows.Forms.Label lblProductSubCategory;
        private System.Windows.Forms.Label lblProductAmountInStore;
        private System.Windows.Forms.TextBox tbxProductSubCategory;
        private System.Windows.Forms.TextBox tbxProductSalesPrice;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductSalesPrice;
        private System.Windows.Forms.TextBox tbxProductType;
        private System.Windows.Forms.TextBox tbxProductCostPrice;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductCostPrice;
        private System.Windows.Forms.TextBox tbxProductBrand;
        private System.Windows.Forms.TextBox tbxProductDescription;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.Label lbBarcode;
    }
}
