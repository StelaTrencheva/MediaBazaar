﻿
namespace MediaBazaar
{
    partial class DepartmentInterface
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
            this.tclDepartment = new System.Windows.Forms.TabControl();
            this.tpAddDepartment = new System.Windows.Forms.TabPage();
            this.gbxAddDepartment = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbxDepartments = new System.Windows.Forms.ListBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.tpAssignEmployeeToDepartment = new System.Windows.Forms.TabPage();
            this.tclDepartment.SuspendLayout();
            this.tpAddDepartment.SuspendLayout();
            this.gbxAddDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclDepartment
            // 
            this.tclDepartment.Controls.Add(this.tpAddDepartment);
            this.tclDepartment.Controls.Add(this.tpAssignEmployeeToDepartment);
            this.tclDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclDepartment.Location = new System.Drawing.Point(3, 3);
            this.tclDepartment.Name = "tclDepartment";
            this.tclDepartment.SelectedIndex = 0;
            this.tclDepartment.Size = new System.Drawing.Size(1123, 779);
            this.tclDepartment.TabIndex = 1;
            // 
            // tpAddDepartment
            // 
            this.tpAddDepartment.BackColor = System.Drawing.Color.Lavender;
            this.tpAddDepartment.Controls.Add(this.gbxAddDepartment);
            this.tpAddDepartment.Controls.Add(this.lbxDepartments);
            this.tpAddDepartment.Controls.Add(this.lblDepartments);
            this.tpAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpAddDepartment.Name = "tpAddDepartment";
            this.tpAddDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddDepartment.Size = new System.Drawing.Size(1115, 741);
            this.tpAddDepartment.TabIndex = 0;
            this.tpAddDepartment.Text = "Add Department";
            // 
            // gbxAddDepartment
            // 
            this.gbxAddDepartment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxAddDepartment.Controls.Add(this.btnAdd);
            this.gbxAddDepartment.Controls.Add(this.tbxName);
            this.gbxAddDepartment.Controls.Add(this.lblName);
            this.gbxAddDepartment.Location = new System.Drawing.Point(26, 75);
            this.gbxAddDepartment.Name = "gbxAddDepartment";
            this.gbxAddDepartment.Size = new System.Drawing.Size(452, 166);
            this.gbxAddDepartment.TabIndex = 2;
            this.gbxAddDepartment.TabStop = false;
            this.gbxAddDepartment.Text = "Add department";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(436, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(10, 74);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(436, 27);
            this.tbxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(11, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(435, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDepartments
            // 
            this.lbxDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDepartments.FormattingEnabled = true;
            this.lbxDepartments.ItemHeight = 20;
            this.lbxDepartments.Location = new System.Drawing.Point(484, 75);
            this.lbxDepartments.Name = "lbxDepartments";
            this.lbxDepartments.Size = new System.Drawing.Size(603, 644);
            this.lbxDepartments.TabIndex = 1;
            // 
            // lblDepartments
            // 
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.Location = new System.Drawing.Point(484, 27);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(603, 45);
            this.lblDepartments.TabIndex = 0;
            this.lblDepartments.Text = "Departments";
            this.lblDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAssignEmployeeToDepartment
            // 
            this.tpAssignEmployeeToDepartment.BackColor = System.Drawing.Color.Lavender;
            this.tpAssignEmployeeToDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAssignEmployeeToDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpAssignEmployeeToDepartment.Name = "tpAssignEmployeeToDepartment";
            this.tpAssignEmployeeToDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssignEmployeeToDepartment.Size = new System.Drawing.Size(1115, 741);
            this.tpAssignEmployeeToDepartment.TabIndex = 1;
            this.tpAssignEmployeeToDepartment.Text = "Assign employee to department";
            // 
            // DepartmentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tclDepartment);
            this.Name = "DepartmentInterface";
            this.Size = new System.Drawing.Size(1129, 785);
            this.tclDepartment.ResumeLayout(false);
            this.tpAddDepartment.ResumeLayout(false);
            this.gbxAddDepartment.ResumeLayout(false);
            this.gbxAddDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclDepartment;
        private System.Windows.Forms.TabPage tpAddDepartment;
        private System.Windows.Forms.GroupBox gbxAddDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbxDepartments;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.TabPage tpAssignEmployeeToDepartment;
    }
}