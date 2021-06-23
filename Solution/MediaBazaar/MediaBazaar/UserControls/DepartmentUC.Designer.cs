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
            this.tpDepartment = new System.Windows.Forms.TabPage();
            this.lblSearchDepartment = new System.Windows.Forms.Label();
            this.gbxAddDepartment = new System.Windows.Forms.GroupBox();
            this.nudDepartmentCode = new System.Windows.Forms.NumericUpDown();
            this.lblDepartmentCode = new System.Windows.Forms.Label();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.tbxSearchDepartment = new System.Windows.Forms.TextBox();
            this.lbxDepartments = new System.Windows.Forms.ListBox();
            this.gbxDeleteDepartment = new System.Windows.Forms.GroupBox();
            this.btnAssignDepartmentManager = new System.Windows.Forms.Button();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.tpAssignDManager = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddC = new System.Windows.Forms.Button();
            this.tbxCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.tbxSearchC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateC = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.tpAssignPCategories = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAssignC = new System.Windows.Forms.Button();
            this.tclDepartment.SuspendLayout();
            this.tpDepartment.SuspendLayout();
            this.gbxAddDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepartmentCode)).BeginInit();
            this.gbxDeleteDepartment.SuspendLayout();
            this.tpAssignDManager.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpAssignPCategories.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclDepartment
            // 
            this.tclDepartment.Controls.Add(this.tpDepartment);
            this.tclDepartment.Controls.Add(this.tpAssignDManager);
            this.tclDepartment.Controls.Add(this.tpAssignPCategories);
            this.tclDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclDepartment.Location = new System.Drawing.Point(3, 3);
            this.tclDepartment.Name = "tclDepartment";
            this.tclDepartment.SelectedIndex = 0;
            this.tclDepartment.Size = new System.Drawing.Size(1123, 779);
            this.tclDepartment.TabIndex = 1;
            // 
            // tpDepartment
            // 
            this.tpDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.tpDepartment.Controls.Add(this.lblSearchDepartment);
            this.tpDepartment.Controls.Add(this.gbxAddDepartment);
            this.tpDepartment.Controls.Add(this.tbxSearchDepartment);
            this.tpDepartment.Controls.Add(this.lbxDepartments);
            this.tpDepartment.Controls.Add(this.gbxDeleteDepartment);
            this.tpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDepartment.Location = new System.Drawing.Point(4, 27);
            this.tpDepartment.Name = "tpDepartment";
            this.tpDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartment.Size = new System.Drawing.Size(1115, 748);
            this.tpDepartment.TabIndex = 0;
            this.tpDepartment.Text = "Department";
            // 
            // lblSearchDepartment
            // 
            this.lblSearchDepartment.Location = new System.Drawing.Point(118, 51);
            this.lblSearchDepartment.Name = "lblSearchDepartment";
            this.lblSearchDepartment.Size = new System.Drawing.Size(186, 30);
            this.lblSearchDepartment.TabIndex = 5;
            this.lblSearchDepartment.Text = "Search department";
            this.lblSearchDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxAddDepartment
            // 
            this.gbxAddDepartment.BackColor = System.Drawing.Color.LightBlue;
            this.gbxAddDepartment.Controls.Add(this.nudDepartmentCode);
            this.gbxAddDepartment.Controls.Add(this.lblDepartmentCode);
            this.gbxAddDepartment.Controls.Add(this.btnDepartmentAdd);
            this.gbxAddDepartment.Controls.Add(this.tbxDepartmentName);
            this.gbxAddDepartment.Controls.Add(this.lblDepartmentName);
            this.gbxAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddDepartment.Location = new System.Drawing.Point(553, 51);
            this.gbxAddDepartment.Name = "gbxAddDepartment";
            this.gbxAddDepartment.Size = new System.Drawing.Size(401, 164);
            this.gbxAddDepartment.TabIndex = 2;
            this.gbxAddDepartment.TabStop = false;
            this.gbxAddDepartment.Text = "Add department";
            // 
            // nudDepartmentCode
            // 
            this.nudDepartmentCode.Location = new System.Drawing.Point(148, 23);
            this.nudDepartmentCode.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDepartmentCode.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDepartmentCode.Name = "nudDepartmentCode";
            this.nudDepartmentCode.Size = new System.Drawing.Size(201, 27);
            this.nudDepartmentCode.TabIndex = 4;
            this.nudDepartmentCode.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblDepartmentCode
            // 
            this.lblDepartmentCode.Location = new System.Drawing.Point(22, 23);
            this.lblDepartmentCode.Name = "lblDepartmentCode";
            this.lblDepartmentCode.Size = new System.Drawing.Size(120, 30);
            this.lblDepartmentCode.TabIndex = 3;
            this.lblDepartmentCode.Text = "Code";
            this.lblDepartmentCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDepartmentAdd
            // 
            this.btnDepartmentAdd.Location = new System.Drawing.Point(54, 104);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(295, 31);
            this.btnDepartmentAdd.TabIndex = 2;
            this.btnDepartmentAdd.Text = "Add";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Location = new System.Drawing.Point(148, 71);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(201, 27);
            this.tbxDepartmentName.TabIndex = 1;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Location = new System.Drawing.Point(22, 68);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(120, 30);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Name:";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxSearchDepartment
            // 
            this.tbxSearchDepartment.Location = new System.Drawing.Point(310, 51);
            this.tbxSearchDepartment.Name = "tbxSearchDepartment";
            this.tbxSearchDepartment.Size = new System.Drawing.Size(215, 27);
            this.tbxSearchDepartment.TabIndex = 6;
            this.tbxSearchDepartment.TextChanged += new System.EventHandler(this.tbxSearchDepartment_TextChanged);
            // 
            // lbxDepartments
            // 
            this.lbxDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDepartments.FormattingEnabled = true;
            this.lbxDepartments.ItemHeight = 22;
            this.lbxDepartments.Location = new System.Drawing.Point(118, 87);
            this.lbxDepartments.Name = "lbxDepartments";
            this.lbxDepartments.Size = new System.Drawing.Size(407, 312);
            this.lbxDepartments.TabIndex = 1;
            this.lbxDepartments.DoubleClick += new System.EventHandler(this.lbxDepartments_DoubleClick);
            // 
            // gbxDeleteDepartment
            // 
            this.gbxDeleteDepartment.BackColor = System.Drawing.Color.LightBlue;
            this.gbxDeleteDepartment.Controls.Add(this.btnAssignC);
            this.gbxDeleteDepartment.Controls.Add(this.btnAssignDepartmentManager);
            this.gbxDeleteDepartment.Controls.Add(this.btnDepartmentUpdate);
            this.gbxDeleteDepartment.Controls.Add(this.btnDepartmentDelete);
            this.gbxDeleteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDeleteDepartment.Location = new System.Drawing.Point(553, 221);
            this.gbxDeleteDepartment.Name = "gbxDeleteDepartment";
            this.gbxDeleteDepartment.Size = new System.Drawing.Size(401, 192);
            this.gbxDeleteDepartment.TabIndex = 5;
            this.gbxDeleteDepartment.TabStop = false;
            this.gbxDeleteDepartment.Text = "Select a department to";
            // 
            // btnAssignDepartmentManager
            // 
            this.btnAssignDepartmentManager.Location = new System.Drawing.Point(54, 100);
            this.btnAssignDepartmentManager.Name = "btnAssignDepartmentManager";
            this.btnAssignDepartmentManager.Size = new System.Drawing.Size(295, 31);
            this.btnAssignDepartmentManager.TabIndex = 4;
            this.btnAssignDepartmentManager.Text = "Assign department manager";
            this.btnAssignDepartmentManager.UseVisualStyleBackColor = true;
            this.btnAssignDepartmentManager.Click += new System.EventHandler(this.btnAssignDepartmentManager_Click);
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(54, 63);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(295, 31);
            this.btnDepartmentUpdate.TabIndex = 3;
            this.btnDepartmentUpdate.Text = "Update/Modify";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.Location = new System.Drawing.Point(54, 26);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(295, 31);
            this.btnDepartmentDelete.TabIndex = 2;
            this.btnDepartmentDelete.Text = "Delete";
            this.btnDepartmentDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tpAssignDManager
            // 
            this.tpAssignDManager.BackColor = System.Drawing.SystemColors.Control;
            this.tpAssignDManager.Controls.Add(this.label1);
            this.tpAssignDManager.Controls.Add(this.groupBox2);
            this.tpAssignDManager.Controls.Add(this.lbxCategory);
            this.tpAssignDManager.Controls.Add(this.groupBox3);
            this.tpAssignDManager.Controls.Add(this.tbxSearchC);
            this.tpAssignDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAssignDManager.Location = new System.Drawing.Point(4, 27);
            this.tpAssignDManager.Name = "tpAssignDManager";
            this.tpAssignDManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssignDManager.Size = new System.Drawing.Size(1115, 748);
            this.tpAssignDManager.TabIndex = 1;
            this.tpAssignDManager.Text = "Assign department manager";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(141, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnAddC);
            this.groupBox2.Controls.Add(this.tbxCName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(563, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add category";
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(46, 88);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(329, 31);
            this.btnAddC.TabIndex = 2;
            this.btnAddC.Text = "Add";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // tbxCName
            // 
            this.tbxCName.Location = new System.Drawing.Point(148, 46);
            this.tbxCName.Name = "tbxCName";
            this.tbxCName.Size = new System.Drawing.Size(227, 27);
            this.tbxCName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxCategory
            // 
            this.lbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 22;
            this.lbxCategory.Location = new System.Drawing.Point(141, 132);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(407, 312);
            this.lbxCategory.TabIndex = 1;
            // 
            // tbxSearchC
            // 
            this.tbxSearchC.Location = new System.Drawing.Point(329, 97);
            this.tbxSearchC.Name = "tbxSearchC";
            this.tbxSearchC.Size = new System.Drawing.Size(219, 27);
            this.tbxSearchC.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.btnUpdateC);
            this.groupBox3.Controls.Add(this.btnDeleteC);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(563, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 164);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select a category to";
            // 
            // btnUpdateC
            // 
            this.btnUpdateC.Location = new System.Drawing.Point(22, 63);
            this.btnUpdateC.Name = "btnUpdateC";
            this.btnUpdateC.Size = new System.Drawing.Size(355, 31);
            this.btnUpdateC.TabIndex = 3;
            this.btnUpdateC.Text = "Update/Modify";
            this.btnUpdateC.UseVisualStyleBackColor = true;
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(22, 26);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(355, 31);
            this.btnDeleteC.TabIndex = 2;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            // 
            // tpAssignPCategories
            // 
            this.tpAssignPCategories.BackColor = System.Drawing.SystemColors.Control;
            this.tpAssignPCategories.Controls.Add(this.groupBox4);
            this.tpAssignPCategories.Location = new System.Drawing.Point(4, 27);
            this.tpAssignPCategories.Name = "tpAssignPCategories";
            this.tpAssignPCategories.Size = new System.Drawing.Size(1115, 748);
            this.tpAssignPCategories.TabIndex = 2;
            this.tpAssignPCategories.Text = "Assign product categories";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 310);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SubCategory";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search SubCategory";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(230, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 120);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add subcategory";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 31);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 27);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(9, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(510, 114);
            this.listBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(201, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 24);
            this.textBox4.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(9, 178);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 119);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select a subcategory to";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 31);
            this.button5.TabIndex = 3;
            this.button5.Text = "Update/Modify";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 31);
            this.button6.TabIndex = 2;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAssignC
            // 
            this.btnAssignC.Location = new System.Drawing.Point(54, 137);
            this.btnAssignC.Name = "btnAssignC";
            this.btnAssignC.Size = new System.Drawing.Size(295, 31);
            this.btnAssignC.TabIndex = 7;
            this.btnAssignC.Text = "Assign Category";
            this.btnAssignC.UseVisualStyleBackColor = true;
            this.btnAssignC.Click += new System.EventHandler(this.btnAssignC_Click);
            // 
            // DepartmentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tclDepartment);
            this.Name = "DepartmentInterface";
            this.Size = new System.Drawing.Size(1129, 785);
            this.tclDepartment.ResumeLayout(false);
            this.tpDepartment.ResumeLayout(false);
            this.tpDepartment.PerformLayout();
            this.gbxAddDepartment.ResumeLayout(false);
            this.gbxAddDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepartmentCode)).EndInit();
            this.gbxDeleteDepartment.ResumeLayout(false);
            this.tpAssignDManager.ResumeLayout(false);
            this.tpAssignDManager.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tpAssignPCategories.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclDepartment;
        private System.Windows.Forms.TabPage tpDepartment;
        private System.Windows.Forms.GroupBox gbxAddDepartment;
        private System.Windows.Forms.Button btnDepartmentAdd;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.ListBox lbxDepartments;
        private System.Windows.Forms.TabPage tpAssignDManager;
        private System.Windows.Forms.NumericUpDown nudDepartmentCode;
        private System.Windows.Forms.Label lblDepartmentCode;
        private System.Windows.Forms.TabPage tpAssignPCategories;
        private System.Windows.Forms.GroupBox gbxDeleteDepartment;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.TextBox tbxSearchDepartment;
        private System.Windows.Forms.Label lblSearchDepartment;
        private System.Windows.Forms.Button btnAssignDepartmentManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.TextBox tbxCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.TextBox tbxSearchC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateC;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAssignC;
    }
}
