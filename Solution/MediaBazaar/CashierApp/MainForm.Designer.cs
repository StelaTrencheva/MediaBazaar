
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxProducts
            // 
            this.lboxProducts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lboxProducts.FormattingEnabled = true;
            this.lboxProducts.ItemHeight = 22;
            this.lboxProducts.Location = new System.Drawing.Point(21, 44);
            this.lboxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lboxProducts.Name = "lboxProducts";
            this.lboxProducts.Size = new System.Drawing.Size(391, 510);
            this.lboxProducts.TabIndex = 0;
            this.lboxProducts.SelectedIndexChanged += new System.EventHandler(this.lboxProducts_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(440, 117);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(215, 30);
            this.cbDepartment.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(440, 173);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(215, 30);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.Location = new System.Drawing.Point(440, 235);
            this.cbSubCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(215, 30);
            this.cbSubCategory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1211, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Have a good day";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(619, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "🔍";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSearch.Location = new System.Drawing.Point(440, 44);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(215, 28);
            this.tbSearch.TabIndex = 85;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbSubCategory
            // 
            this.lbSubCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSubCategory.Location = new System.Drawing.Point(440, 205);
            this.lbSubCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSubCategory.Name = "lbSubCategory";
            this.lbSubCategory.Size = new System.Drawing.Size(214, 28);
            this.lbSubCategory.TabIndex = 88;
            this.lbSubCategory.Text = "Subcategory";
            this.lbSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCategory.Location = new System.Drawing.Point(440, 149);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(214, 22);
            this.lbCategory.TabIndex = 89;
            this.lbCategory.Text = "Category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDepartment
            // 
            this.lbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDepartment.Location = new System.Drawing.Point(440, 92);
            this.lbDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(214, 22);
            this.lbDepartment.TabIndex = 90;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxBasket
            // 
            this.lboxBasket.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lboxBasket.FormattingEnabled = true;
            this.lboxBasket.ItemHeight = 22;
            this.lboxBasket.Location = new System.Drawing.Point(18, 257);
            this.lboxBasket.Margin = new System.Windows.Forms.Padding(2);
            this.lboxBasket.Name = "lboxBasket";
            this.lboxBasket.Size = new System.Drawing.Size(391, 202);
            this.lboxBasket.TabIndex = 91;
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudProductQuantity.Location = new System.Drawing.Point(154, 144);
            this.nudProductQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.Size = new System.Drawing.Size(128, 28);
            this.nudProductQuantity.TabIndex = 92;
            // 
            // tbSelectedItem
            // 
            this.tbSelectedItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSelectedItem.Enabled = false;
            this.tbSelectedItem.Location = new System.Drawing.Point(77, 74);
            this.tbSelectedItem.Margin = new System.Windows.Forms.Padding(2);
            this.tbSelectedItem.Name = "tbSelectedItem";
            this.tbSelectedItem.Size = new System.Drawing.Size(278, 28);
            this.tbSelectedItem.TabIndex = 93;
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddToBasket.Location = new System.Drawing.Point(114, 189);
            this.btnAddToBasket.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(199, 41);
            this.btnAddToBasket.TabIndex = 94;
            this.btnAddToBasket.Text = "button1";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.lboxProducts);
            this.gbProducts.Controls.Add(this.cbDepartment);
            this.gbProducts.Controls.Add(this.cbCategory);
            this.gbProducts.Controls.Add(this.cbSubCategory);
            this.gbProducts.Controls.Add(this.lbDepartment);
            this.gbProducts.Controls.Add(this.label2);
            this.gbProducts.Controls.Add(this.lbCategory);
            this.gbProducts.Controls.Add(this.lbSubCategory);
            this.gbProducts.Controls.Add(this.tbSearch);
            this.gbProducts.Location = new System.Drawing.Point(19, 76);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(681, 593);
            this.gbProducts.TabIndex = 95;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Select a product";
            // 
            // lbCurrentProduct
            // 
            this.lbCurrentProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCurrentProduct.Location = new System.Drawing.Point(73, 41);
            this.lbCurrentProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentProduct.Name = "lbCurrentProduct";
            this.lbCurrentProduct.Size = new System.Drawing.Size(282, 22);
            this.lbCurrentProduct.TabIndex = 91;
            this.lbCurrentProduct.Text = "Current product";
            this.lbCurrentProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbCurrentProduct);
            this.groupBox1.Controls.Add(this.lboxBasket);
            this.groupBox1.Controls.Add(this.nudProductQuantity);
            this.groupBox1.Controls.Add(this.btnAddToBasket);
            this.groupBox1.Controls.Add(this.tbSelectedItem);
            this.groupBox1.Location = new System.Drawing.Point(706, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 593);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1231, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxProducts;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSubCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}