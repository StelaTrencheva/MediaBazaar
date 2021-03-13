
namespace MediaBazaar
{
    partial class ProductData
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
            this.lbxProductDisplay = new System.Windows.Forms.ListBox();
            this.tbProductNum = new System.Windows.Forms.TextBox();
            this.btnSearchProductNum = new System.Windows.Forms.Button();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.ItemHeight = 16;
            this.lbxProductDisplay.Location = new System.Drawing.Point(3, 3);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.Size = new System.Drawing.Size(680, 260);
            this.lbxProductDisplay.TabIndex = 0;
            // 
            // tbProductNum
            // 
            this.tbProductNum.Location = new System.Drawing.Point(14, 304);
            this.tbProductNum.Name = "tbProductNum";
            this.tbProductNum.Size = new System.Drawing.Size(124, 22);
            this.tbProductNum.TabIndex = 1;
            // 
            // btnSearchProductNum
            // 
            this.btnSearchProductNum.Location = new System.Drawing.Point(144, 301);
            this.btnSearchProductNum.Name = "btnSearchProductNum";
            this.btnSearchProductNum.Size = new System.Drawing.Size(75, 28);
            this.btnSearchProductNum.TabIndex = 2;
            this.btnSearchProductNum.Text = "Search";
            this.btnSearchProductNum.UseVisualStyleBackColor = true;
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(11, 284);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(111, 17);
            this.lblProductNumber.TabIndex = 3;
            this.lblProductNumber.Text = "Product Number";
            // 
            // ProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.btnSearchProductNum);
            this.Controls.Add(this.tbProductNum);
            this.Controls.Add(this.lbxProductDisplay);
            this.Name = "ProductData";
            this.Size = new System.Drawing.Size(717, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProductDisplay;
        private System.Windows.Forms.TextBox tbProductNum;
        private System.Windows.Forms.Button btnSearchProductNum;
        private System.Windows.Forms.Label lblProductNumber;
    }
}
