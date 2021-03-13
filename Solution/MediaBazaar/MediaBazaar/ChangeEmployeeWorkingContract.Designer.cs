namespace MediaBazaar
{
    partial class ChangeEmployeeWorkingContract
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentContract = new System.Windows.Forms.Label();
            this.tbxCurrentContract = new System.Windows.Forms.TextBox();
            this.lblChangeContract = new System.Windows.Forms.Label();
            this.cbbChangeCOntract = new System.Windows.Forms.ComboBox();
            this.btnChangeContract = new System.Windows.Forms.Button();
            this.txbEmployeeInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentContract
            // 
            this.lblCurrentContract.AutoSize = true;
            this.lblCurrentContract.Location = new System.Drawing.Point(34, 302);
            this.lblCurrentContract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentContract.Name = "lblCurrentContract";
            this.lblCurrentContract.Size = new System.Drawing.Size(148, 24);
            this.lblCurrentContract.TabIndex = 2;
            this.lblCurrentContract.Text = "Current contract:";
            // 
            // tbxCurrentContract
            // 
            this.tbxCurrentContract.Location = new System.Drawing.Point(242, 298);
            this.tbxCurrentContract.Name = "tbxCurrentContract";
            this.tbxCurrentContract.Size = new System.Drawing.Size(449, 28);
            this.tbxCurrentContract.TabIndex = 3;
            // 
            // lblChangeContract
            // 
            this.lblChangeContract.AutoSize = true;
            this.lblChangeContract.Location = new System.Drawing.Point(34, 358);
            this.lblChangeContract.Name = "lblChangeContract";
            this.lblChangeContract.Size = new System.Drawing.Size(153, 24);
            this.lblChangeContract.TabIndex = 4;
            this.lblChangeContract.Text = "Change contract:";
            // 
            // cbbChangeCOntract
            // 
            this.cbbChangeCOntract.FormattingEnabled = true;
            this.cbbChangeCOntract.Items.AddRange(new object[] {
            "Fulltime",
            "Eighty percent",
            "Flex",
            "Left"});
            this.cbbChangeCOntract.Location = new System.Drawing.Point(242, 355);
            this.cbbChangeCOntract.Name = "cbbChangeCOntract";
            this.cbbChangeCOntract.Size = new System.Drawing.Size(449, 30);
            this.cbbChangeCOntract.TabIndex = 5;
            // 
            // btnChangeContract
            // 
            this.btnChangeContract.BackColor = System.Drawing.Color.Snow;
            this.btnChangeContract.Location = new System.Drawing.Point(242, 399);
            this.btnChangeContract.Name = "btnChangeContract";
            this.btnChangeContract.Size = new System.Drawing.Size(449, 36);
            this.btnChangeContract.TabIndex = 6;
            this.btnChangeContract.Text = "Change working contract";
            this.btnChangeContract.UseVisualStyleBackColor = false;
            this.btnChangeContract.Click += new System.EventHandler(this.btnChangeContract_Click);
            // 
            // txbEmployeeInfo
            // 
            this.txbEmployeeInfo.Location = new System.Drawing.Point(242, 33);
            this.txbEmployeeInfo.Name = "txbEmployeeInfo";
            this.txbEmployeeInfo.Size = new System.Drawing.Size(449, 241);
            this.txbEmployeeInfo.TabIndex = 7;
            this.txbEmployeeInfo.Text = "";
            // 
            // ChangeEmployeeWorkingContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(741, 502);
            this.Controls.Add(this.txbEmployeeInfo);
            this.Controls.Add(this.btnChangeContract);
            this.Controls.Add(this.cbbChangeCOntract);
            this.Controls.Add(this.lblChangeContract);
            this.Controls.Add(this.tbxCurrentContract);
            this.Controls.Add(this.lblCurrentContract);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeEmployeeWorkingContract";
            this.Text = "ChangeEmployeeWorkingContract";
            this.Load += new System.EventHandler(this.ChangeEmployeeWorkingContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentContract;
        private System.Windows.Forms.TextBox tbxCurrentContract;
        private System.Windows.Forms.Label lblChangeContract;
        private System.Windows.Forms.ComboBox cbbChangeCOntract;
        private System.Windows.Forms.Button btnChangeContract;
        private System.Windows.Forms.RichTextBox txbEmployeeInfo;
    }
}