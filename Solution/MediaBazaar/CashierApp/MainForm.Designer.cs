
namespace CashierApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxProducts = new System.Windows.Forms.ListBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSubCategory = new System.Windows.Forms.ComboBox();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbSerchEmoji = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSubCategory = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lboxBasket = new System.Windows.Forms.ListBox();
            this.nudProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbSelectedItem = new System.Windows.Forms.TextBox();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.lbCurrentProduct = new System.Windows.Forms.Label();
            this.tbFinalPrice = new System.Windows.Forms.TextBox();
            this.gbBasket = new System.Windows.Forms.GroupBox();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.gbFinishOrder = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCashRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.gbBasket.SuspendLayout();
            this.gbFinishOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxProducts
            // 
            this.lboxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lboxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxProducts.FormattingEnabled = true;
            this.lboxProducts.ItemHeight = 18;
            this.lboxProducts.Location = new System.Drawing.Point(21, 40);
            this.lboxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lboxProducts.Name = "lboxProducts";
            this.lboxProducts.Size = new System.Drawing.Size(391, 472);
            this.lboxProducts.TabIndex = 0;
            this.lboxProducts.SelectedIndexChanged += new System.EventHandler(this.lboxProducts_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(416, 107);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(215, 28);
            this.cbDepartment.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(416, 157);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(215, 28);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.Location = new System.Drawing.Point(416, 214);
            this.cbSubCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(215, 28);
            this.cbSubCategory.TabIndex = 3;
            this.cbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbSubCategory_SelectedIndexChanged);
            // 
            // lbWelcome
            // 
            this.lbWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWelcome.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(135, 28);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(1252, 38);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Text = "Have a good day";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSerchEmoji
            // 
            this.lbSerchEmoji.AutoSize = true;
            this.lbSerchEmoji.BackColor = System.Drawing.SystemColors.Window;
            this.lbSerchEmoji.Location = new System.Drawing.Point(599, 43);
            this.lbSerchEmoji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSerchEmoji.Name = "lbSerchEmoji";
            this.lbSerchEmoji.Size = new System.Drawing.Size(25, 20);
            this.lbSerchEmoji.TabIndex = 86;
            this.lbSerchEmoji.Text = "🔍";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(416, 40);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(215, 27);
            this.tbSearch.TabIndex = 85;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbSubCategory
            // 
            this.lbSubCategory.Location = new System.Drawing.Point(416, 187);
            this.lbSubCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSubCategory.Name = "lbSubCategory";
            this.lbSubCategory.Size = new System.Drawing.Size(214, 25);
            this.lbSubCategory.TabIndex = 88;
            this.lbSubCategory.Text = "Subcategory";
            this.lbSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategory
            // 
            this.lbCategory.Location = new System.Drawing.Point(416, 136);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(214, 20);
            this.lbCategory.TabIndex = 89;
            this.lbCategory.Text = "Category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartment
            // 
            this.lbDepartment.Location = new System.Drawing.Point(416, 84);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(214, 20);
            this.lbDepartment.TabIndex = 90;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxBasket
            // 
            this.lboxBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxBasket.FormattingEnabled = true;
            this.lboxBasket.ItemHeight = 18;
            this.lboxBasket.Location = new System.Drawing.Point(26, 222);
            this.lboxBasket.Margin = new System.Windows.Forms.Padding(2);
            this.lboxBasket.Name = "lboxBasket";
            this.lboxBasket.Size = new System.Drawing.Size(356, 292);
            this.lboxBasket.TabIndex = 91;
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudProductQuantity.Location = new System.Drawing.Point(149, 88);
            this.nudProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.Size = new System.Drawing.Size(128, 27);
            this.nudProductQuantity.TabIndex = 92;
            this.nudProductQuantity.ValueChanged += new System.EventHandler(this.nudProductQuantity_ValueChanged);
            // 
            // tbSelectedItem
            // 
            this.tbSelectedItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSelectedItem.Enabled = false;
            this.tbSelectedItem.Location = new System.Drawing.Point(72, 53);
            this.tbSelectedItem.Margin = new System.Windows.Forms.Padding(2);
            this.tbSelectedItem.Name = "tbSelectedItem";
            this.tbSelectedItem.Size = new System.Drawing.Size(278, 27);
            this.tbSelectedItem.TabIndex = 93;
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddToBasket.BackColor = System.Drawing.Color.Bisque;
            this.btnAddToBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToBasket.Location = new System.Drawing.Point(113, 172);
            this.btnAddToBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(199, 37);
            this.btnAddToBasket.TabIndex = 94;
            this.btnAddToBasket.Text = "Add to basket";
            this.btnAddToBasket.UseVisualStyleBackColor = false;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // gbProducts
            // 
            this.gbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbProducts.Controls.Add(this.lboxProducts);
            this.gbProducts.Controls.Add(this.cbDepartment);
            this.gbProducts.Controls.Add(this.cbCategory);
            this.gbProducts.Controls.Add(this.cbSubCategory);
            this.gbProducts.Controls.Add(this.lbDepartment);
            this.gbProducts.Controls.Add(this.lbSerchEmoji);
            this.gbProducts.Controls.Add(this.lbCategory);
            this.gbProducts.Controls.Add(this.lbSubCategory);
            this.gbProducts.Controls.Add(this.tbSearch);
            this.gbProducts.Location = new System.Drawing.Point(26, 85);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(649, 542);
            this.gbProducts.TabIndex = 95;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Select a product";
            // 
            // lbCurrentProduct
            // 
            this.lbCurrentProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCurrentProduct.Location = new System.Drawing.Point(68, 23);
            this.lbCurrentProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentProduct.Name = "lbCurrentProduct";
            this.lbCurrentProduct.Size = new System.Drawing.Size(282, 20);
            this.lbCurrentProduct.TabIndex = 91;
            this.lbCurrentProduct.Text = "Current product";
            this.lbCurrentProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFinalPrice
            // 
            this.tbFinalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFinalPrice.Enabled = false;
            this.tbFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFinalPrice.Location = new System.Drawing.Point(92, 97);
            this.tbFinalPrice.Name = "tbFinalPrice";
            this.tbFinalPrice.Size = new System.Drawing.Size(146, 34);
            this.tbFinalPrice.TabIndex = 96;
            // 
            // gbBasket
            // 
            this.gbBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBasket.Controls.Add(this.lbProductPrice);
            this.gbBasket.Controls.Add(this.tbProductPrice);
            this.gbBasket.Controls.Add(this.lbCurrentProduct);
            this.gbBasket.Controls.Add(this.lboxBasket);
            this.gbBasket.Controls.Add(this.nudProductQuantity);
            this.gbBasket.Controls.Add(this.btnAddToBasket);
            this.gbBasket.Controls.Add(this.tbSelectedItem);
            this.gbBasket.Location = new System.Drawing.Point(681, 85);
            this.gbBasket.Name = "gbBasket";
            this.gbBasket.Size = new System.Drawing.Size(413, 542);
            this.gbBasket.TabIndex = 97;
            this.gbBasket.TabStop = false;
            this.gbBasket.Text = "Basket";
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProductPrice.Location = new System.Drawing.Point(149, 117);
            this.lbProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(128, 21);
            this.lbProductPrice.TabIndex = 97;
            this.lbProductPrice.Text = "Product price:";
            this.lbProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Location = new System.Drawing.Point(149, 140);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(128, 27);
            this.tbProductPrice.TabIndex = 98;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.Location = new System.Drawing.Point(62, 51);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(205, 42);
            this.lbTotalPrice.TabIndex = 91;
            this.lbTotalPrice.Text = "Totalprice";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFinishOrder
            // 
            this.gbFinishOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFinishOrder.Controls.Add(this.radioButton2);
            this.gbFinishOrder.Controls.Add(this.radioButton1);
            this.gbFinishOrder.Controls.Add(this.btnConfirm);
            this.gbFinishOrder.Controls.Add(this.lbTotalPrice);
            this.gbFinishOrder.Controls.Add(this.tbFinalPrice);
            this.gbFinishOrder.Location = new System.Drawing.Point(1100, 85);
            this.gbFinishOrder.Name = "gbFinishOrder";
            this.gbFinishOrder.Size = new System.Drawing.Size(323, 256);
            this.gbFinishOrder.TabIndex = 100;
            this.gbFinishOrder.TabStop = false;
            this.gbFinishOrder.Text = "Finish order";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton2.Location = new System.Drawing.Point(189, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 40);
            this.radioButton2.TabIndex = 101;
            this.radioButton2.Text = "Card";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(92, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 40);
            this.radioButton1.TabIndex = 100;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.Bisque;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(62, 187);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(205, 46);
            this.btnConfirm.TabIndex = 99;
            this.btnConfirm.Text = "Confirm purchase";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashRegister.BackColor = System.Drawing.Color.Ivory;
            this.btnCashRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashRegister.Location = new System.Drawing.Point(1244, 553);
            this.btnCashRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.Size = new System.Drawing.Size(168, 44);
            this.btnCashRegister.TabIndex = 99;
            this.btnCashRegister.Text = "Cash register";
            this.btnCashRegister.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1480, 677);
            this.Controls.Add(this.btnCashRegister);
            this.Controls.Add(this.gbFinishOrder);
            this.Controls.Add(this.gbBasket);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.lbWelcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gbBasket.ResumeLayout(false);
            this.gbBasket.PerformLayout();
            this.gbFinishOrder.ResumeLayout(false);
            this.gbFinishOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxProducts;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSubCategory;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbSerchEmoji;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSubCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ListBox lboxBasket;
        private System.Windows.Forms.NumericUpDown nudProductQuantity;
        private System.Windows.Forms.TextBox tbSelectedItem;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Label lbCurrentProduct;
        private System.Windows.Forms.TextBox tbFinalPrice;
        private System.Windows.Forms.GroupBox gbBasket;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.GroupBox gbFinishOrder;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCashRegister;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}