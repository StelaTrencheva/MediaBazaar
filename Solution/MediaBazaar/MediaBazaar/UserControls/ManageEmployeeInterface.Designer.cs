
namespace MediaBazaar
{
    partial class ManageEmployeeInterface
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
            this.tcManageEmployee = new System.Windows.Forms.TabControl();
            this.tpAllEmployees = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.lbxViewEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSizeHelp = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.cbxTypeOfEmployee = new System.Windows.Forms.ComboBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxTown = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.tbxHouseNumber = new System.Windows.Forms.TextBox();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblContractStartDate = new System.Windows.Forms.Label();
            this.cbxContractType = new System.Windows.Forms.ComboBox();
            this.lblContractType = new System.Windows.Forms.Label();
            this.lblTypeOfEmployee = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblBankAccNum = new System.Windows.Forms.Label();
            this.lblEmTelNum = new System.Windows.Forms.Label();
            this.lblBSN = new System.Windows.Forms.Label();
            this.dtpDateFWD = new System.Windows.Forms.DateTimePicker();
            this.lblDateFWD = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbxHourlyWage = new System.Windows.Forms.TextBox();
            this.tbxBankAccNum = new System.Windows.Forms.TextBox();
            this.tbxEmTelNum = new System.Windows.Forms.TextBox();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tpChangeCOntract = new System.Windows.Forms.TabPage();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lbxDisplayEMployees = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tcManageEmployee.SuspendLayout();
            this.tpAllEmployees.SuspendLayout();
            this.tpRegister.SuspendLayout();
            this.tpChangeCOntract.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManageEmployee
            // 
            this.tcManageEmployee.Controls.Add(this.tpAllEmployees);
            this.tcManageEmployee.Controls.Add(this.tpRegister);
            this.tcManageEmployee.Controls.Add(this.tpChangeCOntract);
            this.tcManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcManageEmployee.Location = new System.Drawing.Point(35, 21);
            this.tcManageEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcManageEmployee.Name = "tcManageEmployee";
            this.tcManageEmployee.SelectedIndex = 0;
            this.tcManageEmployee.Size = new System.Drawing.Size(937, 656);
            this.tcManageEmployee.TabIndex = 1;
            // 
            // tpAllEmployees
            // 
            this.tpAllEmployees.BackColor = System.Drawing.Color.Lavender;
            this.tpAllEmployees.Controls.Add(this.button1);
            this.tpAllEmployees.Controls.Add(this.label1);
            this.tpAllEmployees.Controls.Add(this.tbSearch);
            this.tpAllEmployees.Controls.Add(this.button2);
            this.tpAllEmployees.Controls.Add(this.btnRemoveEmployee);
            this.tpAllEmployees.Controls.Add(this.lbxViewEmployees);
            this.tpAllEmployees.Controls.Add(this.lblEmployees);
            this.tpAllEmployees.Location = new System.Drawing.Point(4, 35);
            this.tpAllEmployees.Name = "tpAllEmployees";
            this.tpAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tpAllEmployees.Size = new System.Drawing.Size(929, 617);
            this.tpAllEmployees.TabIndex = 2;
            this.tpAllEmployees.Text = "View Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(861, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 26);
            this.label1.TabIndex = 84;
            this.label1.Text = "🔍";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(717, 37);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(190, 32);
            this.tbSearch.TabIndex = 83;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(515, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 79);
            this.button2.TabIndex = 82;
            this.button2.Text = "View All information";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(515, 492);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(230, 79);
            this.btnRemoveEmployee.TabIndex = 80;
            this.btnRemoveEmployee.Text = "Remove an employee\r\n/Only when necessary/";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // lbxViewEmployees
            // 
            this.lbxViewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbxViewEmployees.FormattingEnabled = true;
            this.lbxViewEmployees.HorizontalScrollbar = true;
            this.lbxViewEmployees.ItemHeight = 20;
            this.lbxViewEmployees.Location = new System.Drawing.Point(6, 81);
            this.lbxViewEmployees.Name = "lbxViewEmployees";
            this.lbxViewEmployees.Size = new System.Drawing.Size(459, 524);
            this.lbxViewEmployees.TabIndex = 2;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(163, 37);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(127, 26);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Employees:";
            // 
            // tpRegister
            // 
            this.tpRegister.AutoScroll = true;
            this.tpRegister.BackColor = System.Drawing.Color.Lavender;
            this.tpRegister.Controls.Add(this.cbxGender);
            this.tpRegister.Controls.Add(this.lblGender);
            this.tpRegister.Controls.Add(this.lblSizeHelp);
            this.tpRegister.Controls.Add(this.tbxUsername);
            this.tpRegister.Controls.Add(this.lblUsername);
            this.tpRegister.Controls.Add(this.tbxZipCode);
            this.tpRegister.Controls.Add(this.lblZipCode);
            this.tpRegister.Controls.Add(this.cbxTypeOfEmployee);
            this.tpRegister.Controls.Add(this.tbxCountry);
            this.tpRegister.Controls.Add(this.tbxTown);
            this.tpRegister.Controls.Add(this.lblCountry);
            this.tpRegister.Controls.Add(this.lblTown);
            this.tpRegister.Controls.Add(this.tbxHouseNumber);
            this.tpRegister.Controls.Add(this.lblHouseNumber);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Controls.Add(this.dtpContractStartDate);
            this.tpRegister.Controls.Add(this.lblContractStartDate);
            this.tpRegister.Controls.Add(this.cbxContractType);
            this.tpRegister.Controls.Add(this.lblContractType);
            this.tpRegister.Controls.Add(this.lblTypeOfEmployee);
            this.tpRegister.Controls.Add(this.lblHourlyWage);
            this.tpRegister.Controls.Add(this.lblBankAccNum);
            this.tpRegister.Controls.Add(this.lblEmTelNum);
            this.tpRegister.Controls.Add(this.lblBSN);
            this.tpRegister.Controls.Add(this.dtpDateFWD);
            this.tpRegister.Controls.Add(this.lblDateFWD);
            this.tpRegister.Controls.Add(this.dtpDateOfBirth);
            this.tpRegister.Controls.Add(this.lblDateOBirth);
            this.tpRegister.Controls.Add(this.lblEmail);
            this.tpRegister.Controls.Add(this.lblStreet);
            this.tpRegister.Controls.Add(this.tbxHourlyWage);
            this.tpRegister.Controls.Add(this.tbxBankAccNum);
            this.tpRegister.Controls.Add(this.tbxEmTelNum);
            this.tpRegister.Controls.Add(this.tbxBSN);
            this.tpRegister.Controls.Add(this.tbxEmail);
            this.tpRegister.Controls.Add(this.tbxStreet);
            this.tpRegister.Controls.Add(this.tbxLName);
            this.tpRegister.Controls.Add(this.tbxFName);
            this.tpRegister.Controls.Add(this.lblLName);
            this.tpRegister.Controls.Add(this.lblFName);
            this.tpRegister.Location = new System.Drawing.Point(4, 35);
            this.tpRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRegister.Size = new System.Drawing.Size(929, 617);
            this.tpRegister.TabIndex = 0;
            this.tpRegister.Text = "Register";
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.cbxGender.Location = new System.Drawing.Point(345, 139);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(169, 34);
            this.cbxGender.TabIndex = 93;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(64, 146);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 26);
            this.lblGender.TabIndex = 92;
            this.lblGender.Text = "Gender:";
            // 
            // lblSizeHelp
            // 
            this.lblSizeHelp.Location = new System.Drawing.Point(3, 1279);
            this.lblSizeHelp.Name = "lblSizeHelp";
            this.lblSizeHelp.Size = new System.Drawing.Size(897, 21);
            this.lblSizeHelp.TabIndex = 91;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(345, 200);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(280, 32);
            this.tbxUsername.TabIndex = 90;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(66, 204);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(119, 26);
            this.lblUsername.TabIndex = 89;
            this.lblUsername.Text = "Username:";
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(345, 361);
            this.tbxZipCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(280, 32);
            this.tbxZipCode.TabIndex = 88;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(64, 361);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(101, 26);
            this.lblZipCode.TabIndex = 87;
            this.lblZipCode.Text = "Zip code:";
            // 
            // cbxTypeOfEmployee
            // 
            this.cbxTypeOfEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeOfEmployee.FormattingEnabled = true;
            this.cbxTypeOfEmployee.Items.AddRange(new object[] {
            "STORE_WORKER",
            "STOCK_WORKER",
            "DEPARTMENT_MANAGER",
            "STORE_MANAGER",
            "STOCK_MANAGER",
            "HR"});
            this.cbxTypeOfEmployee.Location = new System.Drawing.Point(403, 1102);
            this.cbxTypeOfEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTypeOfEmployee.Name = "cbxTypeOfEmployee";
            this.cbxTypeOfEmployee.Size = new System.Drawing.Size(193, 34);
            this.cbxTypeOfEmployee.TabIndex = 86;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(345, 468);
            this.tbxCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(280, 32);
            this.tbxCountry.TabIndex = 85;
            // 
            // tbxTown
            // 
            this.tbxTown.Location = new System.Drawing.Point(345, 411);
            this.tbxTown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTown.Name = "tbxTown";
            this.tbxTown.Size = new System.Drawing.Size(280, 32);
            this.tbxTown.TabIndex = 84;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(64, 472);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(94, 26);
            this.lblCountry.TabIndex = 83;
            this.lblCountry.Text = "Country:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(64, 415);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(70, 26);
            this.lblTown.TabIndex = 82;
            this.lblTown.Text = "Town:";
            // 
            // tbxHouseNumber
            // 
            this.tbxHouseNumber.Location = new System.Drawing.Point(345, 308);
            this.tbxHouseNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHouseNumber.Name = "tbxHouseNumber";
            this.tbxHouseNumber.Size = new System.Drawing.Size(280, 32);
            this.tbxHouseNumber.TabIndex = 81;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(64, 308);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(161, 26);
            this.lblHouseNumber.TabIndex = 80;
            this.lblHouseNumber.Text = "House number:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(332, 1171);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(335, 58);
            this.btnRegister.TabIndex = 79;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpContractStartDate
            // 
            this.dtpContractStartDate.Location = new System.Drawing.Point(345, 1038);
            this.dtpContractStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpContractStartDate.Name = "dtpContractStartDate";
            this.dtpContractStartDate.Size = new System.Drawing.Size(358, 32);
            this.dtpContractStartDate.TabIndex = 41;
            // 
            // lblContractStartDate
            // 
            this.lblContractStartDate.Location = new System.Drawing.Point(64, 1038);
            this.lblContractStartDate.Name = "lblContractStartDate";
            this.lblContractStartDate.Size = new System.Drawing.Size(154, 35);
            this.lblContractStartDate.TabIndex = 40;
            this.lblContractStartDate.Text = "Contract start date:";
            // 
            // cbxContractType
            // 
            this.cbxContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContractType.FormattingEnabled = true;
            this.cbxContractType.Items.AddRange(new object[] {
            "FULLTIME",
            "EIGHTYPERCENT",
            "FLEX",
            "LEFT"});
            this.cbxContractType.Location = new System.Drawing.Point(403, 971);
            this.cbxContractType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxContractType.Name = "cbxContractType";
            this.cbxContractType.Size = new System.Drawing.Size(193, 34);
            this.cbxContractType.TabIndex = 39;
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Location = new System.Drawing.Point(64, 979);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(147, 26);
            this.lblContractType.TabIndex = 38;
            this.lblContractType.Text = "Contract type:";
            // 
            // lblTypeOfEmployee
            // 
            this.lblTypeOfEmployee.AutoSize = true;
            this.lblTypeOfEmployee.Location = new System.Drawing.Point(64, 1110);
            this.lblTypeOfEmployee.Name = "lblTypeOfEmployee";
            this.lblTypeOfEmployee.Size = new System.Drawing.Size(96, 26);
            this.lblTypeOfEmployee.TabIndex = 34;
            this.lblTypeOfEmployee.Text = "Position:";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(64, 908);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(139, 26);
            this.lblHourlyWage.TabIndex = 32;
            this.lblHourlyWage.Text = "Hourly wage:";
            // 
            // lblBankAccNum
            // 
            this.lblBankAccNum.AutoSize = true;
            this.lblBankAccNum.Location = new System.Drawing.Point(64, 845);
            this.lblBankAccNum.Name = "lblBankAccNum";
            this.lblBankAccNum.Size = new System.Drawing.Size(230, 26);
            this.lblBankAccNum.TabIndex = 31;
            this.lblBankAccNum.Text = "Bank account number:";
            // 
            // lblEmTelNum
            // 
            this.lblEmTelNum.AutoSize = true;
            this.lblEmTelNum.Location = new System.Drawing.Point(64, 781);
            this.lblEmTelNum.Name = "lblEmTelNum";
            this.lblEmTelNum.Size = new System.Drawing.Size(310, 26);
            this.lblEmTelNum.TabIndex = 30;
            this.lblEmTelNum.Text = "Emergency telephone number:";
            // 
            // lblBSN
            // 
            this.lblBSN.AutoSize = true;
            this.lblBSN.Location = new System.Drawing.Point(64, 721);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(64, 26);
            this.lblBSN.TabIndex = 29;
            this.lblBSN.Text = "BSN:";
            // 
            // dtpDateFWD
            // 
            this.dtpDateFWD.Location = new System.Drawing.Point(345, 642);
            this.dtpDateFWD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateFWD.Name = "dtpDateFWD";
            this.dtpDateFWD.Size = new System.Drawing.Size(358, 32);
            this.dtpDateFWD.TabIndex = 28;
            // 
            // lblDateFWD
            // 
            this.lblDateFWD.AutoSize = true;
            this.lblDateFWD.Location = new System.Drawing.Point(64, 649);
            this.lblDateFWD.Name = "lblDateFWD";
            this.lblDateFWD.Size = new System.Drawing.Size(251, 26);
            this.lblDateFWD.TabIndex = 27;
            this.lblDateFWD.Text = "Date of first working day:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(345, 585);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(358, 32);
            this.dtpDateOfBirth.TabIndex = 26;
            // 
            // lblDateOBirth
            // 
            this.lblDateOBirth.AutoSize = true;
            this.lblDateOBirth.Location = new System.Drawing.Point(64, 591);
            this.lblDateOBirth.Name = "lblDateOBirth";
            this.lblDateOBirth.Size = new System.Drawing.Size(136, 26);
            this.lblDateOBirth.TabIndex = 25;
            this.lblDateOBirth.Text = "Date of birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(64, 529);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 26);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(64, 260);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(76, 26);
            this.lblStreet.TabIndex = 23;
            this.lblStreet.Text = "Street:";
            // 
            // tbxHourlyWage
            // 
            this.tbxHourlyWage.Location = new System.Drawing.Point(403, 904);
            this.tbxHourlyWage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHourlyWage.Name = "tbxHourlyWage";
            this.tbxHourlyWage.Size = new System.Drawing.Size(193, 32);
            this.tbxHourlyWage.TabIndex = 22;
            // 
            // tbxBankAccNum
            // 
            this.tbxBankAccNum.Location = new System.Drawing.Point(403, 841);
            this.tbxBankAccNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxBankAccNum.Name = "tbxBankAccNum";
            this.tbxBankAccNum.Size = new System.Drawing.Size(193, 32);
            this.tbxBankAccNum.TabIndex = 21;
            // 
            // tbxEmTelNum
            // 
            this.tbxEmTelNum.Location = new System.Drawing.Point(403, 778);
            this.tbxEmTelNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmTelNum.Name = "tbxEmTelNum";
            this.tbxEmTelNum.Size = new System.Drawing.Size(193, 32);
            this.tbxEmTelNum.TabIndex = 20;
            // 
            // tbxBSN
            // 
            this.tbxBSN.Location = new System.Drawing.Point(403, 718);
            this.tbxBSN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(193, 32);
            this.tbxBSN.TabIndex = 19;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(345, 524);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(280, 32);
            this.tbxEmail.TabIndex = 16;
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(345, 254);
            this.tbxStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(280, 32);
            this.tbxStreet.TabIndex = 15;
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(345, 85);
            this.tbxLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(280, 32);
            this.tbxLName.TabIndex = 14;
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(345, 29);
            this.tbxFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(280, 32);
            this.tbxFName.TabIndex = 2;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(64, 85);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(124, 26);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(64, 29);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(125, 26);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // tpChangeCOntract
            // 
            this.tpChangeCOntract.BackColor = System.Drawing.Color.Lavender;
            this.tpChangeCOntract.Controls.Add(this.btnViewDetails);
            this.tpChangeCOntract.Controls.Add(this.lbxDisplayEMployees);
            this.tpChangeCOntract.Location = new System.Drawing.Point(4, 35);
            this.tpChangeCOntract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpChangeCOntract.Name = "tpChangeCOntract";
            this.tpChangeCOntract.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpChangeCOntract.Size = new System.Drawing.Size(929, 617);
            this.tpChangeCOntract.TabIndex = 1;
            this.tpChangeCOntract.Text = "Change contract";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(280, 517);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(328, 64);
            this.btnViewDetails.TabIndex = 78;
            this.btnViewDetails.Text = "Continue";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lbxDisplayEMployees
            // 
            this.lbxDisplayEMployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxDisplayEMployees.FormattingEnabled = true;
            this.lbxDisplayEMployees.ItemHeight = 25;
            this.lbxDisplayEMployees.Location = new System.Drawing.Point(6, 10);
            this.lbxDisplayEMployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxDisplayEMployees.Name = "lbxDisplayEMployees";
            this.lbxDisplayEMployees.Size = new System.Drawing.Size(915, 454);
            this.lbxDisplayEMployees.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 79);
            this.button1.TabIndex = 85;
            this.button1.Text = "Edit personal information";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ManageEmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcManageEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageEmployeeInterface";
            this.Size = new System.Drawing.Size(1013, 702);
            this.Load += new System.EventHandler(this.ManageEmployeeInterface_Load);
            this.tcManageEmployee.ResumeLayout(false);
            this.tpAllEmployees.ResumeLayout(false);
            this.tpAllEmployees.PerformLayout();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            this.tpChangeCOntract.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManageEmployee;
        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpContractStartDate;
        private System.Windows.Forms.Label lblContractStartDate;
        private System.Windows.Forms.ComboBox cbxContractType;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.Label lblTypeOfEmployee;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblBankAccNum;
        private System.Windows.Forms.Label lblEmTelNum;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.DateTimePicker dtpDateFWD;
        private System.Windows.Forms.Label lblDateFWD;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox tbxHourlyWage;
        private System.Windows.Forms.TextBox tbxBankAccNum;
        private System.Windows.Forms.TextBox tbxEmTelNum;
        private System.Windows.Forms.TextBox tbxBSN;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TabPage tpChangeCOntract;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.ListBox lbxDisplayEMployees;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxTown;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox tbxHouseNumber;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.ComboBox cbxTypeOfEmployee;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSizeHelp;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TabPage tpAllEmployees;
        private System.Windows.Forms.ListBox lbxViewEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button button1;
    }
}
