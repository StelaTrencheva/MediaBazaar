
namespace MediaBazaar
{
    partial class AssignSubCategoryForm
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cbxSubCategory = new System.Windows.Forms.ComboBox();
            this.lbxSubCategory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(14, 17);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(776, 27);
            this.lblCategoryName.TabIndex = 9;
            this.lblCategoryName.Text = "label1";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(517, 132);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(151, 31);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cbxSubCategory
            // 
            this.cbxSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubCategory.FormattingEnabled = true;
            this.cbxSubCategory.Location = new System.Drawing.Point(517, 89);
            this.cbxSubCategory.Name = "cbxSubCategory";
            this.cbxSubCategory.Size = new System.Drawing.Size(151, 24);
            this.cbxSubCategory.TabIndex = 7;
            // 
            // lbxSubCategory
            // 
            this.lbxSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSubCategory.FormattingEnabled = true;
            this.lbxSubCategory.ItemHeight = 22;
            this.lbxSubCategory.Location = new System.Drawing.Point(182, 89);
            this.lbxSubCategory.Name = "lbxSubCategory";
            this.lbxSubCategory.Size = new System.Drawing.Size(293, 312);
            this.lbxSubCategory.TabIndex = 6;
            // 
            // AssignSubCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cbxSubCategory);
            this.Controls.Add(this.lbxSubCategory);
            this.Name = "AssignSubCategoryForm";
            this.Text = "AssignSubCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cbxSubCategory;
        private System.Windows.Forms.ListBox lbxSubCategory;
    }
}