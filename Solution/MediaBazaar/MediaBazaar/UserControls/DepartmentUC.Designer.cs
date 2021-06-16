
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
            this.gbxSubCategory = new System.Windows.Forms.GroupBox();
            this.lblSearchSubCategory = new System.Windows.Forms.Label();
            this.gbxAddSubCategory = new System.Windows.Forms.GroupBox();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.tbxSubCategory = new System.Windows.Forms.TextBox();
            this.lblSubCategoryName = new System.Windows.Forms.Label();
            this.lbxSubCategory = new System.Windows.Forms.ListBox();
            this.tbxSearchSubCategory = new System.Windows.Forms.TextBox();
            this.gbxSelectSubCategory = new System.Windows.Forms.GroupBox();
            this.btnUpdateSubCategory = new System.Windows.Forms.Button();
            this.btnDeleteSubCategory = new System.Windows.Forms.Button();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.gbxAddCategory = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.tbxSearchCategory = new System.Windows.Forms.TextBox();
            this.gbxSelectCategory = new System.Windows.Forms.GroupBox();
            this.btnUpadteCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.gbxDepartment = new System.Windows.Forms.GroupBox();
            this.lblSearchDepartment = new System.Windows.Forms.Label();
            this.gbxAddDepartment = new System.Windows.Forms.GroupBox();
            this.nudDepartmentCode = new System.Windows.Forms.NumericUpDown();
            this.lblDepartmentCode = new System.Windows.Forms.Label();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lbxDepartments = new System.Windows.Forms.ListBox();
            this.tbxSearchDepartment = new System.Windows.Forms.TextBox();
            this.gbxDeleteDepartment = new System.Windows.Forms.GroupBox();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.tpAssignDManager = new System.Windows.Forms.TabPage();
            this.lbxDepartmentsAndDM = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignDM = new System.Windows.Forms.Button();
            this.lblDMAssignTo = new System.Windows.Forms.Label();
            this.lblDManager = new System.Windows.Forms.Label();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.cbxDManagers = new System.Windows.Forms.ComboBox();
            this.cbxDMDepartments = new System.Windows.Forms.ComboBox();
            this.tpAssignPCategories = new System.Windows.Forms.TabPage();
            this.lbxDepartmentsAndPCategory = new System.Windows.Forms.ListBox();
            this.btnAssignDepartmentManager = new System.Windows.Forms.Button();
            this.tclDepartment.SuspendLayout();
            this.tpDepartment.SuspendLayout();
            this.gbxSubCategory.SuspendLayout();
            this.gbxAddSubCategory.SuspendLayout();
            this.gbxSelectSubCategory.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            this.gbxAddCategory.SuspendLayout();
            this.gbxSelectCategory.SuspendLayout();
            this.gbxDepartment.SuspendLayout();
            this.gbxAddDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepartmentCode)).BeginInit();
            this.gbxDeleteDepartment.SuspendLayout();
            this.tpAssignDManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpAssignPCategories.SuspendLayout();
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
            this.tpDepartment.BackColor = System.Drawing.Color.White;
            this.tpDepartment.Controls.Add(this.gbxSubCategory);
            this.tpDepartment.Controls.Add(this.gbxCategory);
            this.tpDepartment.Controls.Add(this.gbxDepartment);
            this.tpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDepartment.Location = new System.Drawing.Point(4, 27);
            this.tpDepartment.Name = "tpDepartment";
            this.tpDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartment.Size = new System.Drawing.Size(1115, 748);
            this.tpDepartment.TabIndex = 0;
            this.tpDepartment.Text = "Department";
            // 
            // gbxSubCategory
            // 
            this.gbxSubCategory.Controls.Add(this.lblSearchSubCategory);
            this.gbxSubCategory.Controls.Add(this.gbxAddSubCategory);
            this.gbxSubCategory.Controls.Add(this.lbxSubCategory);
            this.gbxSubCategory.Controls.Add(this.tbxSearchSubCategory);
            this.gbxSubCategory.Controls.Add(this.gbxSelectSubCategory);
            this.gbxSubCategory.Location = new System.Drawing.Point(557, 351);
            this.gbxSubCategory.Name = "gbxSubCategory";
            this.gbxSubCategory.Size = new System.Drawing.Size(536, 310);
            this.gbxSubCategory.TabIndex = 10;
            this.gbxSubCategory.TabStop = false;
            this.gbxSubCategory.Text = "SubCategory";
            // 
            // lblSearchSubCategory
            // 
            this.lblSearchSubCategory.Location = new System.Drawing.Point(9, 23);
            this.lblSearchSubCategory.Name = "lblSearchSubCategory";
            this.lblSearchSubCategory.Size = new System.Drawing.Size(186, 30);
            this.lblSearchSubCategory.TabIndex = 5;
            this.lblSearchSubCategory.Text = "Search SubCategory";
            this.lblSearchSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxAddSubCategory
            // 
            this.gbxAddSubCategory.BackColor = System.Drawing.Color.LightBlue;
            this.gbxAddSubCategory.Controls.Add(this.btnSubCategory);
            this.gbxAddSubCategory.Controls.Add(this.tbxSubCategory);
            this.gbxAddSubCategory.Controls.Add(this.lblSubCategoryName);
            this.gbxAddSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddSubCategory.Location = new System.Drawing.Point(230, 177);
            this.gbxAddSubCategory.Name = "gbxAddSubCategory";
            this.gbxAddSubCategory.Size = new System.Drawing.Size(289, 120);
            this.gbxAddSubCategory.TabIndex = 2;
            this.gbxAddSubCategory.TabStop = false;
            this.gbxAddSubCategory.Text = "Add subcategory";
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Location = new System.Drawing.Point(22, 77);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(252, 31);
            this.btnSubCategory.TabIndex = 2;
            this.btnSubCategory.Text = "Add";
            this.btnSubCategory.UseVisualStyleBackColor = true;
            // 
            // tbxSubCategory
            // 
            this.tbxSubCategory.Location = new System.Drawing.Point(148, 35);
            this.tbxSubCategory.Name = "tbxSubCategory";
            this.tbxSubCategory.Size = new System.Drawing.Size(126, 27);
            this.tbxSubCategory.TabIndex = 1;
            // 
            // lblSubCategoryName
            // 
            this.lblSubCategoryName.Location = new System.Drawing.Point(22, 32);
            this.lblSubCategoryName.Name = "lblSubCategoryName";
            this.lblSubCategoryName.Size = new System.Drawing.Size(120, 30);
            this.lblSubCategoryName.TabIndex = 0;
            this.lblSubCategoryName.Text = "Name:";
            this.lblSubCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxSubCategory
            // 
            this.lbxSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSubCategory.FormattingEnabled = true;
            this.lbxSubCategory.ItemHeight = 22;
            this.lbxSubCategory.Location = new System.Drawing.Point(9, 59);
            this.lbxSubCategory.Name = "lbxSubCategory";
            this.lbxSubCategory.Size = new System.Drawing.Size(510, 114);
            this.lbxSubCategory.TabIndex = 1;
            // 
            // tbxSearchSubCategory
            // 
            this.tbxSearchSubCategory.Location = new System.Drawing.Point(201, 23);
            this.tbxSearchSubCategory.Name = "tbxSearchSubCategory";
            this.tbxSearchSubCategory.Size = new System.Drawing.Size(318, 27);
            this.tbxSearchSubCategory.TabIndex = 6;
            // 
            // gbxSelectSubCategory
            // 
            this.gbxSelectSubCategory.BackColor = System.Drawing.Color.LightBlue;
            this.gbxSelectSubCategory.Controls.Add(this.btnUpdateSubCategory);
            this.gbxSelectSubCategory.Controls.Add(this.btnDeleteSubCategory);
            this.gbxSelectSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelectSubCategory.Location = new System.Drawing.Point(9, 178);
            this.gbxSelectSubCategory.Name = "gbxSelectSubCategory";
            this.gbxSelectSubCategory.Size = new System.Drawing.Size(215, 119);
            this.gbxSelectSubCategory.TabIndex = 5;
            this.gbxSelectSubCategory.TabStop = false;
            this.gbxSelectSubCategory.Text = "Select a subcategory to";
            // 
            // btnUpdateSubCategory
            // 
            this.btnUpdateSubCategory.Location = new System.Drawing.Point(22, 63);
            this.btnUpdateSubCategory.Name = "btnUpdateSubCategory";
            this.btnUpdateSubCategory.Size = new System.Drawing.Size(171, 31);
            this.btnUpdateSubCategory.TabIndex = 3;
            this.btnUpdateSubCategory.Text = "Update/Modify";
            this.btnUpdateSubCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubCategory
            // 
            this.btnDeleteSubCategory.Location = new System.Drawing.Point(22, 26);
            this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
            this.btnDeleteSubCategory.Size = new System.Drawing.Size(171, 31);
            this.btnDeleteSubCategory.TabIndex = 2;
            this.btnDeleteSubCategory.Text = "Delete";
            this.btnDeleteSubCategory.UseVisualStyleBackColor = true;
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblSearchCategory);
            this.gbxCategory.Controls.Add(this.gbxAddCategory);
            this.gbxCategory.Controls.Add(this.lbxCategory);
            this.gbxCategory.Controls.Add(this.tbxSearchCategory);
            this.gbxCategory.Controls.Add(this.gbxSelectCategory);
            this.gbxCategory.Location = new System.Drawing.Point(15, 349);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(536, 310);
            this.gbxCategory.TabIndex = 9;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Category";
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.Location = new System.Drawing.Point(9, 23);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(186, 30);
            this.lblSearchCategory.TabIndex = 5;
            this.lblSearchCategory.Text = "Search Category";
            this.lblSearchCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxAddCategory
            // 
            this.gbxAddCategory.BackColor = System.Drawing.Color.LightBlue;
            this.gbxAddCategory.Controls.Add(this.btnAddCategory);
            this.gbxAddCategory.Controls.Add(this.tbxCategoryName);
            this.gbxAddCategory.Controls.Add(this.lblCategoryName);
            this.gbxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddCategory.Location = new System.Drawing.Point(230, 177);
            this.gbxAddCategory.Name = "gbxAddCategory";
            this.gbxAddCategory.Size = new System.Drawing.Size(289, 120);
            this.gbxAddCategory.TabIndex = 2;
            this.gbxAddCategory.TabStop = false;
            this.gbxAddCategory.Text = "Add category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(22, 77);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(252, 31);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Location = new System.Drawing.Point(148, 35);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(126, 27);
            this.tbxCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Location = new System.Drawing.Point(22, 32);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(120, 30);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Name:";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxCategory
            // 
            this.lbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 22;
            this.lbxCategory.Location = new System.Drawing.Point(9, 59);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(510, 114);
            this.lbxCategory.TabIndex = 1;
            // 
            // tbxSearchCategory
            // 
            this.tbxSearchCategory.Location = new System.Drawing.Point(201, 23);
            this.tbxSearchCategory.Name = "tbxSearchCategory";
            this.tbxSearchCategory.Size = new System.Drawing.Size(318, 27);
            this.tbxSearchCategory.TabIndex = 6;
            // 
            // gbxSelectCategory
            // 
            this.gbxSelectCategory.BackColor = System.Drawing.Color.LightBlue;
            this.gbxSelectCategory.Controls.Add(this.btnUpadteCategory);
            this.gbxSelectCategory.Controls.Add(this.btnDeleteCategory);
            this.gbxSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelectCategory.Location = new System.Drawing.Point(9, 178);
            this.gbxSelectCategory.Name = "gbxSelectCategory";
            this.gbxSelectCategory.Size = new System.Drawing.Size(215, 119);
            this.gbxSelectCategory.TabIndex = 5;
            this.gbxSelectCategory.TabStop = false;
            this.gbxSelectCategory.Text = "Select a category to";
            // 
            // btnUpadteCategory
            // 
            this.btnUpadteCategory.Location = new System.Drawing.Point(22, 63);
            this.btnUpadteCategory.Name = "btnUpadteCategory";
            this.btnUpadteCategory.Size = new System.Drawing.Size(171, 31);
            this.btnUpadteCategory.TabIndex = 3;
            this.btnUpadteCategory.Text = "Update/Modify";
            this.btnUpadteCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(22, 26);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(171, 31);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // gbxDepartment
            // 
            this.gbxDepartment.Controls.Add(this.lblSearchDepartment);
            this.gbxDepartment.Controls.Add(this.gbxAddDepartment);
            this.gbxDepartment.Controls.Add(this.lbxDepartments);
            this.gbxDepartment.Controls.Add(this.tbxSearchDepartment);
            this.gbxDepartment.Controls.Add(this.gbxDeleteDepartment);
            this.gbxDepartment.Location = new System.Drawing.Point(6, 16);
            this.gbxDepartment.Name = "gbxDepartment";
            this.gbxDepartment.Size = new System.Drawing.Size(1088, 329);
            this.gbxDepartment.TabIndex = 8;
            this.gbxDepartment.TabStop = false;
            this.gbxDepartment.Text = "Department";
            // 
            // lblSearchDepartment
            // 
            this.lblSearchDepartment.Location = new System.Drawing.Point(9, 23);
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
            this.gbxAddDepartment.Location = new System.Drawing.Point(422, 24);
            this.gbxAddDepartment.Name = "gbxAddDepartment";
            this.gbxAddDepartment.Size = new System.Drawing.Size(315, 164);
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
            this.nudDepartmentCode.Size = new System.Drawing.Size(150, 27);
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
            this.btnDepartmentAdd.Location = new System.Drawing.Point(22, 113);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(276, 31);
            this.btnDepartmentAdd.TabIndex = 2;
            this.btnDepartmentAdd.Text = "Add";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Location = new System.Drawing.Point(148, 71);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(150, 27);
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
            // lbxDepartments
            // 
            this.lbxDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDepartments.FormattingEnabled = true;
            this.lbxDepartments.ItemHeight = 22;
            this.lbxDepartments.Location = new System.Drawing.Point(9, 59);
            this.lbxDepartments.Name = "lbxDepartments";
            this.lbxDepartments.Size = new System.Drawing.Size(407, 268);
            this.lbxDepartments.TabIndex = 1;
            // 
            // tbxSearchDepartment
            // 
            this.tbxSearchDepartment.Location = new System.Drawing.Point(201, 23);
            this.tbxSearchDepartment.Name = "tbxSearchDepartment";
            this.tbxSearchDepartment.Size = new System.Drawing.Size(215, 27);
            this.tbxSearchDepartment.TabIndex = 6;
            this.tbxSearchDepartment.TextChanged += new System.EventHandler(this.tbxSearchDepartment_TextChanged);
            // 
            // gbxDeleteDepartment
            // 
            this.gbxDeleteDepartment.BackColor = System.Drawing.Color.LightBlue;
            this.gbxDeleteDepartment.Controls.Add(this.btnAssignDepartmentManager);
            this.gbxDeleteDepartment.Controls.Add(this.btnDepartmentUpdate);
            this.gbxDeleteDepartment.Controls.Add(this.btnDepartmentDelete);
            this.gbxDeleteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDeleteDepartment.Location = new System.Drawing.Point(743, 26);
            this.gbxDeleteDepartment.Name = "gbxDeleteDepartment";
            this.gbxDeleteDepartment.Size = new System.Drawing.Size(315, 162);
            this.gbxDeleteDepartment.TabIndex = 5;
            this.gbxDeleteDepartment.TabStop = false;
            this.gbxDeleteDepartment.Text = "Select a department to";
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(22, 63);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(276, 31);
            this.btnDepartmentUpdate.TabIndex = 3;
            this.btnDepartmentUpdate.Text = "Update/Modify";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.Location = new System.Drawing.Point(22, 26);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(276, 31);
            this.btnDepartmentDelete.TabIndex = 2;
            this.btnDepartmentDelete.Text = "Delete";
            this.btnDepartmentDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tpAssignDManager
            // 
            this.tpAssignDManager.BackColor = System.Drawing.Color.Transparent;
            this.tpAssignDManager.Controls.Add(this.lbxDepartmentsAndDM);
            this.tpAssignDManager.Controls.Add(this.panel1);
            this.tpAssignDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAssignDManager.Location = new System.Drawing.Point(4, 27);
            this.tpAssignDManager.Name = "tpAssignDManager";
            this.tpAssignDManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssignDManager.Size = new System.Drawing.Size(1115, 748);
            this.tpAssignDManager.TabIndex = 1;
            this.tpAssignDManager.Text = "Assign department manager";
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
            // cbxDManagers
            // 
            this.cbxDManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDManagers.FormattingEnabled = true;
            this.cbxDManagers.Location = new System.Drawing.Point(104, 37);
            this.cbxDManagers.Name = "cbxDManagers";
            this.cbxDManagers.Size = new System.Drawing.Size(240, 28);
            this.cbxDManagers.TabIndex = 1;
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
            this.tpAssignPCategories.Controls.Add(this.lbxDepartmentsAndPCategory);
            this.tpAssignPCategories.Location = new System.Drawing.Point(4, 27);
            this.tpAssignPCategories.Name = "tpAssignPCategories";
            this.tpAssignPCategories.Size = new System.Drawing.Size(1115, 748);
            this.tpAssignPCategories.TabIndex = 2;
            this.tpAssignPCategories.Text = "Assign product categories";
            this.tpAssignPCategories.UseVisualStyleBackColor = true;
            // 
            // lbxDepartmentsAndPCategory
            // 
            this.lbxDepartmentsAndPCategory.FormattingEnabled = true;
            this.lbxDepartmentsAndPCategory.ItemHeight = 18;
            this.lbxDepartmentsAndPCategory.Location = new System.Drawing.Point(44, 64);
            this.lbxDepartmentsAndPCategory.Name = "lbxDepartmentsAndPCategory";
            this.lbxDepartmentsAndPCategory.Size = new System.Drawing.Size(518, 328);
            this.lbxDepartmentsAndPCategory.TabIndex = 0;
            // 
            // btnAssignDepartmentManager
            // 
            this.btnAssignDepartmentManager.Location = new System.Drawing.Point(22, 100);
            this.btnAssignDepartmentManager.Name = "btnAssignDepartmentManager";
            this.btnAssignDepartmentManager.Size = new System.Drawing.Size(276, 31);
            this.btnAssignDepartmentManager.TabIndex = 4;
            this.btnAssignDepartmentManager.Text = "Assign department manager";
            this.btnAssignDepartmentManager.UseVisualStyleBackColor = true;
            this.btnAssignDepartmentManager.Click += new System.EventHandler(this.btnAssignDepartmentManager_Click);
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
            this.gbxSubCategory.ResumeLayout(false);
            this.gbxSubCategory.PerformLayout();
            this.gbxAddSubCategory.ResumeLayout(false);
            this.gbxAddSubCategory.PerformLayout();
            this.gbxSelectSubCategory.ResumeLayout(false);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxAddCategory.ResumeLayout(false);
            this.gbxAddCategory.PerformLayout();
            this.gbxSelectCategory.ResumeLayout(false);
            this.gbxDepartment.ResumeLayout(false);
            this.gbxDepartment.PerformLayout();
            this.gbxAddDepartment.ResumeLayout(false);
            this.gbxAddDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepartmentCode)).EndInit();
            this.gbxDeleteDepartment.ResumeLayout(false);
            this.tpAssignDManager.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpAssignPCategories.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDManager;
        private System.Windows.Forms.ComboBox cbxDManagers;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox cbxDMDepartments;
        private System.Windows.Forms.Label lblDMAssignTo;
        private System.Windows.Forms.ListBox lbxDepartmentsAndDM;
        private System.Windows.Forms.Button btnAssignDM;
        private System.Windows.Forms.ListBox lbxDepartmentsAndPCategory;
        private System.Windows.Forms.GroupBox gbxDeleteDepartment;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.TextBox tbxSearchDepartment;
        private System.Windows.Forms.GroupBox gbxDepartment;
        private System.Windows.Forms.Label lblSearchDepartment;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.GroupBox gbxAddCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.TextBox tbxSearchCategory;
        private System.Windows.Forms.GroupBox gbxSelectCategory;
        private System.Windows.Forms.Button btnUpadteCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.GroupBox gbxSubCategory;
        private System.Windows.Forms.Label lblSearchSubCategory;
        private System.Windows.Forms.GroupBox gbxAddSubCategory;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.TextBox tbxSubCategory;
        private System.Windows.Forms.Label lblSubCategoryName;
        private System.Windows.Forms.ListBox lbxSubCategory;
        private System.Windows.Forms.TextBox tbxSearchSubCategory;
        private System.Windows.Forms.GroupBox gbxSelectSubCategory;
        private System.Windows.Forms.Button btnUpdateSubCategory;
        private System.Windows.Forms.Button btnDeleteSubCategory;
        private System.Windows.Forms.Button btnAssignDepartmentManager;
    }
}
