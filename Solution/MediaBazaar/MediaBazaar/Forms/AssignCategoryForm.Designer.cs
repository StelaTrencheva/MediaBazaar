
namespace MediaBazaar
{
    partial class AssignCategoryForm
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
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCategory
            // 
            this.lbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 22;
            this.lbxCategory.Location = new System.Drawing.Point(180, 81);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(293, 312);
            this.lbxCategory.TabIndex = 2;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(515, 81);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(151, 24);
            this.cbxCategory.TabIndex = 3;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(515, 124);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(151, 31);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(12, 18);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(776, 27);
            this.lblDepartmentName.TabIndex = 5;
            this.lblDepartmentName.Text = "label1";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lbxCategory);
            this.Name = "AssignCategoryForm";
            this.Text = "AssignCategory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblDepartmentName;
    }
}