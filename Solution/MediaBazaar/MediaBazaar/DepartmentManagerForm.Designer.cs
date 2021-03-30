
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
            this.btnDepartmentMSchedule = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDepartmentMLogOut = new System.Windows.Forms.Button();
            this.btnDepartmentMAccount = new System.Windows.Forms.Button();
            this.storeWorkerScheduleInterface = new MediaBazaar.StoreWorkerScheduleInterface();
            this.userInterface1 = new MediaBazaar.UserInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDepartmentMSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 34;
            // 
            // btnDepartmentMSchedule
            // 
            this.btnDepartmentMSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnDepartmentMSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMSchedule.Location = new System.Drawing.Point(32, 206);
            this.btnDepartmentMSchedule.Name = "btnDepartmentMSchedule";
            this.btnDepartmentMSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnDepartmentMSchedule.TabIndex = 3;
            this.btnDepartmentMSchedule.Text = "Schedule";
            this.btnDepartmentMSchedule.UseVisualStyleBackColor = false;
            this.btnDepartmentMSchedule.Click += new System.EventHandler(this.btnDepartmentMSchedule_Click);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDepartmentMLogOut);
            this.panel2.Controls.Add(this.btnDepartmentMAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnDepartmentMLogOut
            // 
            this.btnDepartmentMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDepartmentMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnDepartmentMLogOut.Name = "btnDepartmentMLogOut";
            this.btnDepartmentMLogOut.Size = new System.Drawing.Size(146, 43);
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
            this.btnDepartmentMAccount.Location = new System.Drawing.Point(32, 47);
            this.btnDepartmentMAccount.Name = "btnDepartmentMAccount";
            this.btnDepartmentMAccount.Size = new System.Drawing.Size(146, 43);
            this.btnDepartmentMAccount.TabIndex = 2;
            this.btnDepartmentMAccount.Text = "My account";
            this.btnDepartmentMAccount.UseVisualStyleBackColor = false;
            this.btnDepartmentMAccount.Click += new System.EventHandler(this.btnDepartmentMAccount_Click);
            // 
            // storeWorkerScheduleInterface
            // 
            this.storeWorkerScheduleInterface.Location = new System.Drawing.Point(213, 0);
            this.storeWorkerScheduleInterface.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storeWorkerScheduleInterface.Name = "storeWorkerScheduleInterface";
            this.storeWorkerScheduleInterface.Size = new System.Drawing.Size(890, 530);
            this.storeWorkerScheduleInterface.TabIndex = 36;
            // 
            // userInterface1
            // 
            this.userInterface1.Location = new System.Drawing.Point(213, 0);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(890, 530);
            this.userInterface1.TabIndex = 37;
            this.userInterface1.Load += new System.EventHandler(this.userInterface1_Load);
            // 
            // DepartmentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 528);
            this.Controls.Add(this.storeWorkerScheduleInterface);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userInterface1);
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
        private UserInterface userInterface1;
    }
}