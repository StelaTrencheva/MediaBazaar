
namespace MediaBazaar
{
    partial class StockWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockWorker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnStockWRestockRequest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStockWLogOut = new System.Windows.Forms.Button();
            this.btnStockWAccount = new System.Windows.Forms.Button();
            this.btnStockWSave = new System.Windows.Forms.Button();
            this.tbxStockWBSN = new System.Windows.Forms.TextBox();
            this.lblStockWBSN = new System.Windows.Forms.Label();
            this.tbxStockWAddress = new System.Windows.Forms.TextBox();
            this.tbxStockWEmail = new System.Windows.Forms.TextBox();
            this.tbxStockWPhoneNum = new System.Windows.Forms.TextBox();
            this.tbxStockWEmployeeType = new System.Windows.Forms.TextBox();
            this.tbxStockWLName = new System.Windows.Forms.TextBox();
            this.tbxStockWFName = new System.Windows.Forms.TextBox();
            this.lblStockWAddress = new System.Windows.Forms.Label();
            this.lblStockWEmail = new System.Windows.Forms.Label();
            this.lblStockWPhoneNum = new System.Windows.Forms.Label();
            this.lblStockWEmployeeType = new System.Windows.Forms.Label();
            this.lblStockWLName = new System.Windows.Forms.Label();
            this.lblStockWFName = new System.Windows.Forms.Label();
            this.pbxStockW = new System.Windows.Forms.PictureBox();
            this.btnStockWEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnStockWRestockRequest);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 530);
            this.panel1.TabIndex = 51;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(32, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(146, 134);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // btnStockWRestockRequest
            // 
            this.btnStockWRestockRequest.BackColor = System.Drawing.Color.SlateGray;
            this.btnStockWRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWRestockRequest.Location = new System.Drawing.Point(32, 152);
            this.btnStockWRestockRequest.Name = "btnStockWRestockRequest";
            this.btnStockWRestockRequest.Size = new System.Drawing.Size(146, 64);
            this.btnStockWRestockRequest.TabIndex = 1;
            this.btnStockWRestockRequest.Text = "Restock Request";
            this.btnStockWRestockRequest.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStockWLogOut);
            this.panel2.Controls.Add(this.btnStockWAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnStockWLogOut
            // 
            this.btnStockWLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStockWLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnStockWLogOut.Name = "btnStockWLogOut";
            this.btnStockWLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnStockWLogOut.TabIndex = 3;
            this.btnStockWLogOut.Text = "Log out";
            this.btnStockWLogOut.UseVisualStyleBackColor = false;
            // 
            // btnStockWAccount
            // 
            this.btnStockWAccount.BackColor = System.Drawing.Color.White;
            this.btnStockWAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWAccount.Location = new System.Drawing.Point(32, 47);
            this.btnStockWAccount.Name = "btnStockWAccount";
            this.btnStockWAccount.Size = new System.Drawing.Size(146, 43);
            this.btnStockWAccount.TabIndex = 2;
            this.btnStockWAccount.Text = "My account";
            this.btnStockWAccount.UseVisualStyleBackColor = false;
            // 
            // btnStockWSave
            // 
            this.btnStockWSave.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStockWSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWSave.Location = new System.Drawing.Point(613, 448);
            this.btnStockWSave.Name = "btnStockWSave";
            this.btnStockWSave.Size = new System.Drawing.Size(125, 43);
            this.btnStockWSave.TabIndex = 138;
            this.btnStockWSave.Text = "Save";
            this.btnStockWSave.UseVisualStyleBackColor = false;
            this.btnStockWSave.Visible = false;
            this.btnStockWSave.Click += new System.EventHandler(this.btnStockWSave_Click);
            // 
            // tbxStockWBSN
            // 
            this.tbxStockWBSN.Location = new System.Drawing.Point(613, 165);
            this.tbxStockWBSN.Name = "tbxStockWBSN";
            this.tbxStockWBSN.ReadOnly = true;
            this.tbxStockWBSN.Size = new System.Drawing.Size(145, 22);
            this.tbxStockWBSN.TabIndex = 137;
            this.tbxStockWBSN.Text = "238827";
            // 
            // lblStockWBSN
            // 
            this.lblStockWBSN.AutoSize = true;
            this.lblStockWBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWBSN.Location = new System.Drawing.Point(467, 165);
            this.lblStockWBSN.Name = "lblStockWBSN";
            this.lblStockWBSN.Size = new System.Drawing.Size(49, 20);
            this.lblStockWBSN.TabIndex = 136;
            this.lblStockWBSN.Text = "BSN:";
            // 
            // tbxStockWAddress
            // 
            this.tbxStockWAddress.Location = new System.Drawing.Point(613, 301);
            this.tbxStockWAddress.Name = "tbxStockWAddress";
            this.tbxStockWAddress.ReadOnly = true;
            this.tbxStockWAddress.Size = new System.Drawing.Size(220, 22);
            this.tbxStockWAddress.TabIndex = 135;
            this.tbxStockWAddress.Text = "Street 1";
            // 
            // tbxStockWEmail
            // 
            this.tbxStockWEmail.Location = new System.Drawing.Point(613, 267);
            this.tbxStockWEmail.Name = "tbxStockWEmail";
            this.tbxStockWEmail.ReadOnly = true;
            this.tbxStockWEmail.Size = new System.Drawing.Size(170, 22);
            this.tbxStockWEmail.TabIndex = 134;
            this.tbxStockWEmail.Text = "ben.m@example.com";
            // 
            // tbxStockWPhoneNum
            // 
            this.tbxStockWPhoneNum.Location = new System.Drawing.Point(613, 233);
            this.tbxStockWPhoneNum.Name = "tbxStockWPhoneNum";
            this.tbxStockWPhoneNum.ReadOnly = true;
            this.tbxStockWPhoneNum.Size = new System.Drawing.Size(170, 22);
            this.tbxStockWPhoneNum.TabIndex = 133;
            this.tbxStockWPhoneNum.Text = "067*********";
            // 
            // tbxStockWEmployeeType
            // 
            this.tbxStockWEmployeeType.Location = new System.Drawing.Point(613, 199);
            this.tbxStockWEmployeeType.Name = "tbxStockWEmployeeType";
            this.tbxStockWEmployeeType.ReadOnly = true;
            this.tbxStockWEmployeeType.Size = new System.Drawing.Size(145, 22);
            this.tbxStockWEmployeeType.TabIndex = 132;
            this.tbxStockWEmployeeType.Text = "Stock worker";
            // 
            // tbxStockWLName
            // 
            this.tbxStockWLName.Location = new System.Drawing.Point(613, 131);
            this.tbxStockWLName.Name = "tbxStockWLName";
            this.tbxStockWLName.ReadOnly = true;
            this.tbxStockWLName.Size = new System.Drawing.Size(145, 22);
            this.tbxStockWLName.TabIndex = 131;
            this.tbxStockWLName.Text = "Miller";
            // 
            // tbxStockWFName
            // 
            this.tbxStockWFName.Location = new System.Drawing.Point(613, 97);
            this.tbxStockWFName.Name = "tbxStockWFName";
            this.tbxStockWFName.ReadOnly = true;
            this.tbxStockWFName.Size = new System.Drawing.Size(145, 22);
            this.tbxStockWFName.TabIndex = 130;
            this.tbxStockWFName.Text = "Ben";
            // 
            // lblStockWAddress
            // 
            this.lblStockWAddress.AutoSize = true;
            this.lblStockWAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWAddress.Location = new System.Drawing.Point(468, 301);
            this.lblStockWAddress.Name = "lblStockWAddress";
            this.lblStockWAddress.Size = new System.Drawing.Size(76, 20);
            this.lblStockWAddress.TabIndex = 129;
            this.lblStockWAddress.Text = "Address:";
            // 
            // lblStockWEmail
            // 
            this.lblStockWEmail.AutoSize = true;
            this.lblStockWEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWEmail.Location = new System.Drawing.Point(468, 267);
            this.lblStockWEmail.Name = "lblStockWEmail";
            this.lblStockWEmail.Size = new System.Drawing.Size(56, 20);
            this.lblStockWEmail.TabIndex = 128;
            this.lblStockWEmail.Text = "Email:";
            // 
            // lblStockWPhoneNum
            // 
            this.lblStockWPhoneNum.AutoSize = true;
            this.lblStockWPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWPhoneNum.Location = new System.Drawing.Point(468, 233);
            this.lblStockWPhoneNum.Name = "lblStockWPhoneNum";
            this.lblStockWPhoneNum.Size = new System.Drawing.Size(122, 20);
            this.lblStockWPhoneNum.TabIndex = 127;
            this.lblStockWPhoneNum.Text = "Phone number:";
            // 
            // lblStockWEmployeeType
            // 
            this.lblStockWEmployeeType.AutoSize = true;
            this.lblStockWEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWEmployeeType.Location = new System.Drawing.Point(468, 199);
            this.lblStockWEmployeeType.Name = "lblStockWEmployeeType";
            this.lblStockWEmployeeType.Size = new System.Drawing.Size(123, 20);
            this.lblStockWEmployeeType.TabIndex = 126;
            this.lblStockWEmployeeType.Text = "EmployeeType:";
            // 
            // lblStockWLName
            // 
            this.lblStockWLName.AutoSize = true;
            this.lblStockWLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWLName.Location = new System.Drawing.Point(468, 131);
            this.lblStockWLName.Name = "lblStockWLName";
            this.lblStockWLName.Size = new System.Drawing.Size(93, 20);
            this.lblStockWLName.TabIndex = 125;
            this.lblStockWLName.Text = "Last name:";
            // 
            // lblStockWFName
            // 
            this.lblStockWFName.AutoSize = true;
            this.lblStockWFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockWFName.Location = new System.Drawing.Point(468, 97);
            this.lblStockWFName.Name = "lblStockWFName";
            this.lblStockWFName.Size = new System.Drawing.Size(94, 20);
            this.lblStockWFName.TabIndex = 124;
            this.lblStockWFName.Text = "First name:";
            // 
            // pbxStockW
            // 
            this.pbxStockW.Image = ((System.Drawing.Image)(resources.GetObject("pbxStockW.Image")));
            this.pbxStockW.Location = new System.Drawing.Point(271, 97);
            this.pbxStockW.Name = "pbxStockW";
            this.pbxStockW.Size = new System.Drawing.Size(160, 171);
            this.pbxStockW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxStockW.TabIndex = 123;
            this.pbxStockW.TabStop = false;
            // 
            // btnStockWEdit
            // 
            this.btnStockWEdit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStockWEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWEdit.Location = new System.Drawing.Point(758, 448);
            this.btnStockWEdit.Name = "btnStockWEdit";
            this.btnStockWEdit.Size = new System.Drawing.Size(125, 43);
            this.btnStockWEdit.TabIndex = 122;
            this.btnStockWEdit.Text = "Edit";
            this.btnStockWEdit.UseVisualStyleBackColor = false;
            this.btnStockWEdit.Click += new System.EventHandler(this.btnStockWEdit_Click);
            // 
            // StockWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStockWSave);
            this.Controls.Add(this.tbxStockWBSN);
            this.Controls.Add(this.lblStockWBSN);
            this.Controls.Add(this.tbxStockWAddress);
            this.Controls.Add(this.tbxStockWEmail);
            this.Controls.Add(this.tbxStockWPhoneNum);
            this.Controls.Add(this.tbxStockWEmployeeType);
            this.Controls.Add(this.tbxStockWLName);
            this.Controls.Add(this.tbxStockWFName);
            this.Controls.Add(this.lblStockWAddress);
            this.Controls.Add(this.lblStockWEmail);
            this.Controls.Add(this.lblStockWPhoneNum);
            this.Controls.Add(this.lblStockWEmployeeType);
            this.Controls.Add(this.lblStockWLName);
            this.Controls.Add(this.lblStockWFName);
            this.Controls.Add(this.pbxStockW);
            this.Controls.Add(this.btnStockWEdit);
            this.Controls.Add(this.panel1);
            this.Name = "StockWorker";
            this.Size = new System.Drawing.Size(924, 530);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxStockW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnStockWRestockRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStockWLogOut;
        private System.Windows.Forms.Button btnStockWAccount;
        private System.Windows.Forms.Button btnStockWSave;
        private System.Windows.Forms.TextBox tbxStockWBSN;
        private System.Windows.Forms.Label lblStockWBSN;
        private System.Windows.Forms.TextBox tbxStockWAddress;
        private System.Windows.Forms.TextBox tbxStockWEmail;
        private System.Windows.Forms.TextBox tbxStockWPhoneNum;
        private System.Windows.Forms.TextBox tbxStockWEmployeeType;
        private System.Windows.Forms.TextBox tbxStockWLName;
        private System.Windows.Forms.TextBox tbxStockWFName;
        private System.Windows.Forms.Label lblStockWAddress;
        private System.Windows.Forms.Label lblStockWEmail;
        private System.Windows.Forms.Label lblStockWPhoneNum;
        private System.Windows.Forms.Label lblStockWEmployeeType;
        private System.Windows.Forms.Label lblStockWLName;
        private System.Windows.Forms.Label lblStockWFName;
        private System.Windows.Forms.PictureBox pbxStockW;
        private System.Windows.Forms.Button btnStockWEdit;
    }
}
