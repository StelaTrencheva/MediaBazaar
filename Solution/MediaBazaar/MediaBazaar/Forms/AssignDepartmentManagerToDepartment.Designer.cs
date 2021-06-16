
namespace MediaBazaar
{
    partial class AssignDepartmentManagerToDepartment
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
            this.lbxAssignDepartmentManager = new System.Windows.Forms.ListBox();
            this.cbxDepartmentManager = new System.Windows.Forms.ComboBox();
            this.lblDepartmentManager = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnUnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxAssignDepartmentManager
            // 
            this.lbxAssignDepartmentManager.FormattingEnabled = true;
            this.lbxAssignDepartmentManager.ItemHeight = 16;
            this.lbxAssignDepartmentManager.Location = new System.Drawing.Point(242, 101);
            this.lbxAssignDepartmentManager.Name = "lbxAssignDepartmentManager";
            this.lbxAssignDepartmentManager.Size = new System.Drawing.Size(254, 212);
            this.lbxAssignDepartmentManager.TabIndex = 0;
            // 
            // cbxDepartmentManager
            // 
            this.cbxDepartmentManager.FormattingEnabled = true;
            this.cbxDepartmentManager.Location = new System.Drawing.Point(513, 101);
            this.cbxDepartmentManager.Name = "cbxDepartmentManager";
            this.cbxDepartmentManager.Size = new System.Drawing.Size(208, 24);
            this.cbxDepartmentManager.TabIndex = 1;
            // 
            // lblDepartmentManager
            // 
            this.lblDepartmentManager.AutoSize = true;
            this.lblDepartmentManager.Location = new System.Drawing.Point(513, 78);
            this.lblDepartmentManager.Name = "lblDepartmentManager";
            this.lblDepartmentManager.Size = new System.Drawing.Size(142, 17);
            this.lblDepartmentManager.TabIndex = 2;
            this.lblDepartmentManager.Text = "Department Manager";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(513, 131);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(208, 30);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(239, 81);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department";
            // 
            // btnUnAssign
            // 
            this.btnUnAssign.Location = new System.Drawing.Point(513, 167);
            this.btnUnAssign.Name = "btnUnAssign";
            this.btnUnAssign.Size = new System.Drawing.Size(208, 30);
            this.btnUnAssign.TabIndex = 5;
            this.btnUnAssign.Text = "Unassign";
            this.btnUnAssign.UseVisualStyleBackColor = true;
            this.btnUnAssign.Click += new System.EventHandler(this.btnUnAssign_Click);
            // 
            // AssignDepartmentManagerToDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnAssign);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblDepartmentManager);
            this.Controls.Add(this.cbxDepartmentManager);
            this.Controls.Add(this.lbxAssignDepartmentManager);
            this.Name = "AssignDepartmentManagerToDepartment";
            this.Text = "AssignDepartmentManagerToDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAssignDepartmentManager;
        private System.Windows.Forms.ComboBox cbxDepartmentManager;
        private System.Windows.Forms.Label lblDepartmentManager;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnUnAssign;
    }
}