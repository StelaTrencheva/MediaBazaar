namespace MediaBazaar
{
    partial class StoreWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreWorkerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStoreWorkerRestockRequest = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStoreWLogOut = new System.Windows.Forms.Button();
            this.btnStoreWAccount = new System.Windows.Forms.Button();
            this.userInterface1 = new MediaBazaar.UserInterface();
            this.storeWorkerRestockRequest1 = new MediaBazaar.StoreWorkerRestockRequest();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStoreWorkerRestockRequest);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 786);
            this.panel1.TabIndex = 53;
            // 
            // btnStoreWorkerRestockRequest
            // 
            this.btnStoreWorkerRestockRequest.BackColor = System.Drawing.Color.SlateGray;
            this.btnStoreWorkerRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreWorkerRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreWorkerRestockRequest.Location = new System.Drawing.Point(23, 184);
            this.btnStoreWorkerRestockRequest.Name = "btnStoreWorkerRestockRequest";
            this.btnStoreWorkerRestockRequest.Size = new System.Drawing.Size(155, 59);
            this.btnStoreWorkerRestockRequest.TabIndex = 3;
            this.btnStoreWorkerRestockRequest.Text = "Restock request";
            this.btnStoreWorkerRestockRequest.UseVisualStyleBackColor = false;
            this.btnStoreWorkerRestockRequest.Click += new System.EventHandler(this.btnStoreWorkerRestockRequest_Click);
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
            this.panel2.Controls.Add(this.btnStoreWLogOut);
            this.panel2.Controls.Add(this.btnStoreWAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 364);
            this.panel2.TabIndex = 0;
            // 
            // btnStoreWLogOut
            // 
            this.btnStoreWLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStoreWLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreWLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreWLogOut.Location = new System.Drawing.Point(23, 223);
            this.btnStoreWLogOut.Name = "btnStoreWLogOut";
            this.btnStoreWLogOut.Size = new System.Drawing.Size(155, 59);
            this.btnStoreWLogOut.TabIndex = 3;
            this.btnStoreWLogOut.Text = "Log out";
            this.btnStoreWLogOut.UseVisualStyleBackColor = false;
            this.btnStoreWLogOut.Click += new System.EventHandler(this.btnStoreWLogOut_Click);
            // 
            // btnStoreWAccount
            // 
            this.btnStoreWAccount.BackColor = System.Drawing.Color.White;
            this.btnStoreWAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreWAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreWAccount.Location = new System.Drawing.Point(23, 82);
            this.btnStoreWAccount.Name = "btnStoreWAccount";
            this.btnStoreWAccount.Size = new System.Drawing.Size(155, 59);
            this.btnStoreWAccount.TabIndex = 2;
            this.btnStoreWAccount.Text = "My account";
            this.btnStoreWAccount.UseVisualStyleBackColor = false;
            this.btnStoreWAccount.Click += new System.EventHandler(this.btnStoreWAccount_Click);
            // 
            // userInterface1
            // 
            this.userInterface1.Location = new System.Drawing.Point(207, 0);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(1121, 747);
            this.userInterface1.TabIndex = 54;
            // 
            // storeWorkerRestockRequest1
            // 
            this.storeWorkerRestockRequest1.BackColor = System.Drawing.Color.LightBlue;
            this.storeWorkerRestockRequest1.Location = new System.Drawing.Point(207, 0);
            this.storeWorkerRestockRequest1.Name = "storeWorkerRestockRequest1";
            this.storeWorkerRestockRequest1.Size = new System.Drawing.Size(1121, 747);
            this.storeWorkerRestockRequest1.TabIndex = 55;
            // 
            // StoreWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1340, 786);
            this.Controls.Add(this.userInterface1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.storeWorkerRestockRequest1);
            this.Name = "StoreWorkerForm";
            this.Text = "StoreWorkerForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStoreWorkerRestockRequest;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStoreWLogOut;
        private System.Windows.Forms.Button btnStoreWAccount;
        private UserInterface userInterface1;
        private StoreWorkerRestockRequest storeWorkerRestockRequest1;
    }
}