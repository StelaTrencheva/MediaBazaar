
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
            this.gbxAddDepartment = new System.Windows.Forms.GroupBox();
            this.nudCode = new System.Windows.Forms.NumericUpDown();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbxDepartments = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpAssignDManager = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDManager = new System.Windows.Forms.Label();
            this.cbxDManagers = new System.Windows.Forms.ComboBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.cbxDMDepartments = new System.Windows.Forms.ComboBox();
            this.tpAssignPCategories = new System.Windows.Forms.TabPage();
            this.lblDMAssignTo = new System.Windows.Forms.Label();
            this.lbxDepartmentsAndDM = new System.Windows.Forms.ListBox();
            this.btnAssignDM = new System.Windows.Forms.Button();
            this.tclDepartment.SuspendLayout();
            this.tpDepartment.SuspendLayout();
            this.gbxAddDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).BeginInit();
            this.tpAssignDManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclDepartment
            // 
            this.tclDepartment.Controls.Add(this.tpDepartment);
            this.tclDepartment.Controls.Add(this.tpAssignDManager);
            this.tclDepartment.Controls.Add(this.tpAssignPCategories);
            this.tclDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclDepartment.Location = new System.Drawing.Point(3, 3);
            this.tclDepartment.Name = "tclDepartment";
            this.tclDepartment.SelectedIndex = 0;
            this.tclDepartment.Size = new System.Drawing.Size(1123, 779);
            this.tclDepartment.TabIndex = 1;
            // 
            // tpDepartment
            // 
            this.tpDepartment.BackColor = System.Drawing.Color.Transparent;
            this.tpDepartment.Controls.Add(this.gbxAddDepartment);
            this.tpDepartment.Controls.Add(this.lbxDepartments);
            this.tpDepartment.Controls.Add(this.lblTitle);
            this.tpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpDepartment.Name = "tpDepartment";
            this.tpDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartment.Size = new System.Drawing.Size(1115, 741);
            this.tpDepartment.TabIndex = 0;
            this.tpDepartment.Text = "Department";
            // 
            // gbxAddDepartment
            // 
            this.gbxAddDepartment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxAddDepartment.Controls.Add(this.nudCode);
            this.gbxAddDepartment.Controls.Add(this.lblCode);
            this.gbxAddDepartment.Controls.Add(this.btnAdd);
            this.gbxAddDepartment.Controls.Add(this.tbxName);
            this.gbxAddDepartment.Controls.Add(this.lblName);
            this.gbxAddDepartment.Location = new System.Drawing.Point(638, 70);
            this.gbxAddDepartment.Name = "gbxAddDepartment";
            this.gbxAddDepartment.Size = new System.Drawing.Size(452, 185);
            this.gbxAddDepartment.TabIndex = 2;
            this.gbxAddDepartment.TabStop = false;
            this.gbxAddDepartment.Text = "Add department";
            // 
            // nudCode
            // 
            this.nudCode.Location = new System.Drawing.Point(200, 39);
            this.nudCode.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudCode.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCode.Name = "nudCode";
            this.nudCode.Size = new System.Drawing.Size(246, 27);
            this.nudCode.TabIndex = 4;
            this.nudCode.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(6, 39);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(188, 30);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(436, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(200, 87);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(246, 27);
            this.tbxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDepartments
            // 
            this.lbxDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDepartments.FormattingEnabled = true;
            this.lbxDepartments.ItemHeight = 20;
            this.lbxDepartments.Location = new System.Drawing.Point(16, 70);
            this.lbxDepartments.Name = "lbxDepartments";
            this.lbxDepartments.Size = new System.Drawing.Size(603, 644);
            this.lbxDepartments.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Departments";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAssignDManager
            // 
            this.tpAssignDManager.BackColor = System.Drawing.Color.Transparent;
            this.tpAssignDManager.Controls.Add(this.lbxDepartmentsAndDM);
            this.tpAssignDManager.Controls.Add(this.panel1);
            this.tpAssignDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAssignDManager.Location = new System.Drawing.Point(4, 34);
            this.tpAssignDManager.Name = "tpAssignDManager";
            this.tpAssignDManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssignDManager.Size = new System.Drawing.Size(1115, 741);
            this.tpAssignDManager.TabIndex = 1;
            this.tpAssignDManager.Text = "Assign department manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnAssignDM);
            this.panel1.Controls.Add(this.lblDMAssignTo);
            this.panel1.Controls.Add(this.lblDManager);
            this.panel1.Controls.Add(this.lblDepartments);
            this.panel1.Controls.Add(this.cbxDManagers);
            this.panel1.Controls.Add(this.cbxDMDepartments);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 89);
            this.panel1.TabIndex = 0;
            // 
            // lblDManager
            // 
            this.lblDManager.AutoSize = true;
            this.lblDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManager.Location = new System.Drawing.Point(100, 14);
            this.lblDManager.Name = "lblDManager";
            this.lblDManager.Size = new System.Drawing.Size(167, 20);
            this.lblDManager.TabIndex = 2;
            this.lblDManager.Text = "Department manager";
            // 
            // cbxDManagers
            // 
            this.cbxDManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDManagers.FormattingEnabled = true;
            this.cbxDManagers.Location = new System.Drawing.Point(104, 37);
            this.cbxDManagers.Name = "cbxDManagers";
            this.cbxDManagers.Size = new System.Drawing.Size(240, 28);
            this.cbxDManagers.TabIndex = 1;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.Location = new System.Drawing.Point(502, 15);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(106, 20);
            this.lblDepartments.TabIndex = 1;
            this.lblDepartments.Text = "Departments";
            // 
            // cbxDMDepartments
            // 
            this.cbxDMDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDMDepartments.FormattingEnabled = true;
            this.cbxDMDepartments.Location = new System.Drawing.Point(506, 38);
            this.cbxDMDepartments.Name = "cbxDMDepartments";
            this.cbxDMDepartments.Size = new System.Drawing.Size(374, 28);
            this.cbxDMDepartments.TabIndex = 0;
            // 
            // tpAssignPCategories
            // 
            this.tpAssignPCategories.Location = new System.Drawing.Point(4, 34);
            this.tpAssignPCategories.Name = "tpAssignPCategories";
            this.tpAssignPCategories.Size = new System.Drawing.Size(1115, 741);
            this.tpAssignPCategories.TabIndex = 2;
            this.tpAssignPCategories.Text = "Assign product categories";
            this.tpAssignPCategories.UseVisualStyleBackColor = true;
            // 
            // lblDMAssignTo
            // 
            this.lblDMAssignTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMAssignTo.Location = new System.Drawing.Point(350, 37);
            this.lblDMAssignTo.Name = "lblDMAssignTo";
            this.lblDMAssignTo.Size = new System.Drawing.Size(150, 28);
            this.lblDMAssignTo.TabIndex = 2;
            this.lblDMAssignTo.Text = "Assign to";
            this.lblDMAssignTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDepartmentsAndDM
            // 
            this.lbxDepartmentsAndDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDepartmentsAndDM.FormattingEnabled = true;
            this.lbxDepartmentsAndDM.ItemHeight = 25;
            this.lbxDepartmentsAndDM.Location = new System.Drawing.Point(159, 146);
            this.lbxDepartmentsAndDM.Name = "lbxDepartmentsAndDM";
            this.lbxDepartmentsAndDM.Size = new System.Drawing.Size(776, 529);
            this.lbxDepartmentsAndDM.TabIndex = 1;
            // 
            // btnAssignDM
            // 
            this.btnAssignDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignDM.Location = new System.Drawing.Point(897, 34);
            this.btnAssignDM.Name = "btnAssignDM";
            this.btnAssignDM.Size = new System.Drawing.Size(121, 35);
            this.btnAssignDM.TabIndex = 3;
            this.btnAssignDM.Text = "Assign";
            this.btnAssignDM.UseVisualStyleBackColor = true;
            this.btnAssignDM.Click += new System.EventHandler(this.btnAssignDM_Click);
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
            this.gbxAddDepartment.ResumeLayout(false);
            this.gbxAddDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).EndInit();
            this.tpAssignDManager.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclDepartment;
        private System.Windows.Forms.TabPage tpDepartment;
        private System.Windows.Forms.GroupBox gbxAddDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbxDepartments;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpAssignDManager;
        private System.Windows.Forms.NumericUpDown nudCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TabPage tpAssignPCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDManager;
        private System.Windows.Forms.ComboBox cbxDManagers;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox cbxDMDepartments;
        private System.Windows.Forms.Label lblDMAssignTo;
        private System.Windows.Forms.ListBox lbxDepartmentsAndDM;
        private System.Windows.Forms.Button btnAssignDM;
    }
}
