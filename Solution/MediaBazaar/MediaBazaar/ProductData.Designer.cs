
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
            this.SuspendLayout();
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.HorizontalScrollbar = true;
            this.lbxProductDisplay.ItemHeight = 25;
            this.lbxProductDisplay.Location = new System.Drawing.Point(3, 3);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.ScrollAlwaysVisible = true;
            this.lbxProductDisplay.Size = new System.Drawing.Size(884, 379);
            this.lbxProductDisplay.TabIndex = 0;
            // 
            // ProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxProductDisplay);
            this.Name = "ProductData";
            this.Size = new System.Drawing.Size(890, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProductDisplay;
    }
}
