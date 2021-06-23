
namespace MediaBazaar
{
    partial class AssignProductForm
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
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.lbxProduct = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoryName.Location = new System.Drawing.Point(13, 17);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(776, 27);
            this.lblSubCategoryName.TabIndex = 9;
            this.lblSubCategoryName.Text = "label1";
            this.lblSubCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(516, 132);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(243, 31);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cbxProduct
            // 
            this.cbxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(516, 89);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(243, 24);
            this.cbxProduct.TabIndex = 7;
            // 
            // lbxProduct
            // 
            this.lbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProduct.FormattingEnabled = true;
            this.lbxProduct.ItemHeight = 22;
            this.lbxProduct.Location = new System.Drawing.Point(181, 89);
            this.lbxProduct.Name = "lbxProduct";
            this.lbxProduct.Size = new System.Drawing.Size(293, 312);
            this.lbxProduct.TabIndex = 6;
            // 
            // AssignProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubCategoryName);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.lbxProduct);
            this.Name = "AssignProductForm";
            this.Text = "AssignProductForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.ListBox lbxProduct;
    }
}