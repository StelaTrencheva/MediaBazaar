
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
            this.tcProducts.Size = new System.Drawing.Size(1270, 981);
            this.tcProducts.TabIndex = 24;
            // 
            // tpAllProducts
            // 
            this.tpAllProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpAllProducts.Controls.Add(this.btnViewProductInfo);
            this.tpAllProducts.Controls.Add(this.btnDeleteProduct);
            this.tpAllProducts.Controls.Add(this.lblProduct);
            this.tpAllProducts.Controls.Add(this.lbxProductDisplay);
            this.tpAllProducts.Location = new System.Drawing.Point(4, 38);
            this.tpAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllProducts.Name = "tpAllProducts";
            this.tpAllProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllProducts.Size = new System.Drawing.Size(1262, 939);
            this.tpAllProducts.TabIndex = 0;
            this.tpAllProducts.Text = "All Products";
            // 
            // btnViewProductInfo
            // 
            this.btnViewProductInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductInfo.Location = new System.Drawing.Point(713, 148);
            this.btnViewProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProductInfo.Name = "btnViewProductInfo";
            this.btnViewProductInfo.Size = new System.Drawing.Size(272, 71);
            this.btnViewProductInfo.TabIndex = 4;
            this.btnViewProductInfo.Text = "View a product information";
            this.btnViewProductInfo.UseVisualStyleBackColor = false;
            this.btnViewProductInfo.Click += new System.EventHandler(this.btnViewProductInfo_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(713, 269);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(272, 71);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Remove a product\r\n/Only when necessary/";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(7, 21);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(700, 59);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "All products in the store";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.HorizontalScrollbar = true;
            this.lbxProductDisplay.ItemHeight = 29;
            this.lbxProductDisplay.Location = new System.Drawing.Point(3, 84);
            this.lbxProductDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.ScrollAlwaysVisible = true;
            this.lbxProductDisplay.Size = new System.Drawing.Size(703, 845);
            this.lbxProductDisplay.TabIndex = 1;
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.tpAddProduct.Location = new System.Drawing.Point(4, 38);
            this.tpAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddProduct.Size = new System.Drawing.Size(1262, 939);
            this.tpAddProduct.TabIndex = 1;
            this.tpAddProduct.Text = "Add product";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1251, 72);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Add a product";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.Location = new System.Drawing.Point(183, 148);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(88, 22);
            this.lblProductCategory.TabIndex = 4;
            this.lblProductCategory.Text = "Category:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(156, 620);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(1044, 45);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblProductModel
            // 
            this.lblProductModel.AutoSize = true;
            this.lblProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductModel.Location = new System.Drawing.Point(204, 342);
            this.lblProductModel.Name = "lblProductModel";
            this.lblProductModel.Size = new System.Drawing.Size(63, 22);
            this.lblProductModel.TabIndex = 2;
            this.lblProductModel.Text = "Model:";
            // 
            // tbxProductAmountInWarehouse
            // 
            this.tbxProductAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductAmountInWarehouse.Location = new System.Drawing.Point(976, 335);
            this.tbxProductAmountInWarehouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductAmountInWarehouse.Name = "tbxProductAmountInWarehouse";
            this.tbxProductAmountInWarehouse.Size = new System.Drawing.Size(139, 28);
            this.tbxProductAmountInWarehouse.TabIndex = 21;
            // 
            // tbxProductModel
            // 
            this.tbxProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductModel.Location = new System.Drawing.Point(277, 336);
            this.tbxProductModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductModel.Name = "tbxProductModel";
            this.tbxProductModel.Size = new System.Drawing.Size(134, 28);
            this.tbxProductModel.TabIndex = 3;
            // 
            // lblProductAmountInWarehouse
            // 
            this.lblProductAmountInWarehouse.AutoSize = true;
            this.lblProductAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmountInWarehouse.Location = new System.Drawing.Point(793, 335);
            this.lblProductAmountInWarehouse.Name = "lblProductAmountInWarehouse";
            this.lblProductAmountInWarehouse.Size = new System.Drawing.Size(188, 22);
            this.lblProductAmountInWarehouse.TabIndex = 20;
            this.lblProductAmountInWarehouse.Text = "Amount in warehouse:";
            // 
            // tbxProductCategory
            // 
            this.tbxProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductCategory.Location = new System.Drawing.Point(277, 148);
            this.tbxProductCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductCategory.Name = "tbxProductCategory";
            this.tbxProductCategory.Size = new System.Drawing.Size(134, 28);
            this.tbxProductCategory.TabIndex = 5;
            // 
            // tbxProductAmountInStore
            // 
            this.tbxProductAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductAmountInStore.Location = new System.Drawing.Point(976, 269);
            this.tbxProductAmountInStore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductAmountInStore.Name = "tbxProductAmountInStore";
            this.tbxProductAmountInStore.Size = new System.Drawing.Size(139, 28);
            this.tbxProductAmountInStore.TabIndex = 19;
            // 
            // lblProductSubCategory
            // 
            this.lblProductSubCategory.AutoSize = true;
            this.lblProductSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSubCategory.Location = new System.Drawing.Point(153, 196);
            this.lblProductSubCategory.Name = "lblProductSubCategory";
            this.lblProductSubCategory.Size = new System.Drawing.Size(121, 22);
            this.lblProductSubCategory.TabIndex = 6;
            this.lblProductSubCategory.Text = "Sub category:";
            // 
            // lblProductAmountInStore
            // 
            this.lblProductAmountInStore.AutoSize = true;
            this.lblProductAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmountInStore.Location = new System.Drawing.Point(834, 269);
            this.lblProductAmountInStore.Name = "lblProductAmountInStore";
            this.lblProductAmountInStore.Size = new System.Drawing.Size(140, 22);
            this.lblProductAmountInStore.TabIndex = 18;
            this.lblProductAmountInStore.Text = "Amount in store:";
            // 
            // tbxProductSubCategory
            // 
            this.tbxProductSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductSubCategory.Location = new System.Drawing.Point(277, 199);
            this.tbxProductSubCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductSubCategory.Name = "tbxProductSubCategory";
            this.tbxProductSubCategory.Size = new System.Drawing.Size(134, 28);
            this.tbxProductSubCategory.TabIndex = 7;
            // 
            // tbxProductSalesPrice
            // 
            this.tbxProductSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductSalesPrice.Location = new System.Drawing.Point(976, 208);
            this.tbxProductSalesPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductSalesPrice.Name = "tbxProductSalesPrice";
            this.tbxProductSalesPrice.Size = new System.Drawing.Size(139, 28);
            this.tbxProductSalesPrice.TabIndex = 17;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(213, 248);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(56, 22);
            this.lblProductType.TabIndex = 8;
            this.lblProductType.Text = "Type:";
            // 
            // lblProductSalesPrice
            // 
            this.lblProductSalesPrice.AutoSize = true;
            this.lblProductSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSalesPrice.Location = new System.Drawing.Point(868, 208);
            this.lblProductSalesPrice.Name = "lblProductSalesPrice";
            this.lblProductSalesPrice.Size = new System.Drawing.Size(104, 22);
            this.lblProductSalesPrice.TabIndex = 16;
            this.lblProductSalesPrice.Text = "Sales price:";
            // 
            // tbxProductType
            // 
            this.tbxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductType.Location = new System.Drawing.Point(277, 248);
            this.tbxProductType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductType.Name = "tbxProductType";
            this.tbxProductType.Size = new System.Drawing.Size(134, 28);
            this.tbxProductType.TabIndex = 9;
            // 
            // tbxProductCostPrice
            // 
            this.tbxProductCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductCostPrice.Location = new System.Drawing.Point(976, 144);
            this.tbxProductCostPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductCostPrice.Name = "tbxProductCostPrice";
            this.tbxProductCostPrice.Size = new System.Drawing.Size(139, 28);
            this.tbxProductCostPrice.TabIndex = 15;
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBrand.Location = new System.Drawing.Point(204, 291);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(63, 22);
            this.lblProductBrand.TabIndex = 10;
            this.lblProductBrand.Text = "Brand:";
            // 
            // lblProductCostPrice
            // 
            this.lblProductCostPrice.AutoSize = true;
            this.lblProductCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCostPrice.Location = new System.Drawing.Point(875, 144);
            this.lblProductCostPrice.Name = "lblProductCostPrice";
            this.lblProductCostPrice.Size = new System.Drawing.Size(96, 22);
            this.lblProductCostPrice.TabIndex = 14;
            this.lblProductCostPrice.Text = "Cost price:";
            // 
            // tbxProductBrand
            // 
            this.tbxProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductBrand.Location = new System.Drawing.Point(277, 291);
            this.tbxProductBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductBrand.Name = "tbxProductBrand";
            this.tbxProductBrand.Size = new System.Drawing.Size(134, 28);
            this.tbxProductBrand.TabIndex = 11;
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.Location = new System.Drawing.Point(224, 429);
            this.tbxProductDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.Size = new System.Drawing.Size(892, 79);
            this.tbxProductDescription.TabIndex = 13;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Location = new System.Drawing.Point(224, 401);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(892, 24);
            this.lblProductDescription.TabIndex = 12;
            this.lblProductDescription.Text = "Description:";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProductInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProductInterface";
            this.Size = new System.Drawing.Size(1270, 981);
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
    }
}
