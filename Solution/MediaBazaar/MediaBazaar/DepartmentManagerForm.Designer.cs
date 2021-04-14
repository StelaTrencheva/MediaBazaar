
namespace MediaBazaar
{
    partial class DepartmentManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnDepartmentMSchedule = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDepartmentMLogOut = new System.Windows.Forms.Button();
            this.btnDepartmentMAccount = new System.Windows.Forms.Button();
            this.userInterface1 = new MediaBazaar.UserInterface();
            this.departmentInterface1 = new MediaBazaar.DepartmentInterface();
            this.storeWorkerScheduleInterface = new MediaBazaar.StoreWorkerScheduleInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDepartment);
            this.panel1.Controls.Add(this.btnDepartmentMSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 786);
            this.panel1.TabIndex = 34;
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.SlateGray;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(23, 280);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(155, 59);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnDepartmentMSchedule
            // 
            this.btnDepartmentMSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnDepartmentMSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMSchedule.Location = new System.Drawing.Point(23, 179);
            this.btnDepartmentMSchedule.Name = "btnDepartmentMSchedule";
            this.btnDepartmentMSchedule.Size = new System.Drawing.Size(155, 59);
            this.btnDepartmentMSchedule.TabIndex = 3;
            this.btnDepartmentMSchedule.Text = "Schedule";
            this.btnDepartmentMSchedule.UseVisualStyleBackColor = false;
            this.btnDepartmentMSchedule.Click += new System.EventHandler(this.btnDepartmentMSchedule_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(23, 11);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(156, 142);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDepartmentMLogOut);
            this.panel2.Controls.Add(this.btnDepartmentMAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 411);
            this.panel2.TabIndex = 0;
            // 
            // btnDepartmentMLogOut
            // 
            this.btnDepartmentMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDepartmentMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMLogOut.Location = new System.Drawing.Point(23, 253);
            this.btnDepartmentMLogOut.Name = "btnDepartmentMLogOut";
            this.btnDepartmentMLogOut.Size = new System.Drawing.Size(155, 59);
            this.btnDepartmentMLogOut.TabIndex = 3;
            this.btnDepartmentMLogOut.Text = "Log out";
            this.btnDepartmentMLogOut.UseVisualStyleBackColor = false;
            this.btnDepartmentMLogOut.Click += new System.EventHandler(this.btnDepartmentMLogOut_Click);
            // 
            // btnDepartmentMAccount
            // 
            this.btnDepartmentMAccount.BackColor = System.Drawing.Color.White;
            this.btnDepartmentMAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMAccount.Location = new System.Drawing.Point(23, 97);
            this.btnDepartmentMAccount.Name = "btnDepartmentMAccount";
            this.btnDepartmentMAccount.Size = new System.Drawing.Size(155, 59);
            this.btnDepartmentMAccount.TabIndex = 2;
            this.btnDepartmentMAccount.Text = "My account";
            this.btnDepartmentMAccount.UseVisualStyleBackColor = false;
            this.btnDepartmentMAccount.Click += new System.EventHandler(this.btnDepartmentMAccount_Click);
            // 
            // userInterface1
            // 
            this.userInterface1.Location = new System.Drawing.Point(212, 1);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(1121, 747);
            this.userInterface1.TabIndex = 40;
            this.userInterface1.Load += new System.EventHandler(this.userInterface1_Load);
            // 
            // departmentInterface1
            // 
            this.departmentInterface1.Location = new System.Drawing.Point(213, 1);
            this.departmentInterface1.Name = "departmentInterface1";
            this.departmentInterface1.Size = new System.Drawing.Size(1129, 785);
            this.departmentInterface1.TabIndex = 39;
            // 
            // storeWorkerScheduleInterface
            // 
            this.storeWorkerScheduleInterface.Location = new System.Drawing.Point(212, 0);
            this.storeWorkerScheduleInterface.Name = "storeWorkerScheduleInterface";
            this.storeWorkerScheduleInterface.Size = new System.Drawing.Size(1129, 785);
            this.storeWorkerScheduleInterface.TabIndex = 38;
            // 
            // DepartmentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1340, 786);
            this.Controls.Add(this.userInterface1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.departmentInterface1);
            this.Controls.Add(this.storeWorkerScheduleInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DepartmentManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentManagerFormcs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDepartmentMSchedule;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDepartmentMLogOut;
        private System.Windows.Forms.Button btnDepartmentMAccount;
        private StoreWorkerScheduleInterface storeWorkerScheduleInterface;
        private System.Windows.Forms.Button btnDepartment;
        private DepartmentInterface departmentInterface1;
        private UserInterface userInterface1;
    }
}