
namespace MediaBazaar
{
    partial class RestockRequestInterface
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
            this.lblRestockRequest = new System.Windows.Forms.Label();
            this.gbxProductInformation = new System.Windows.Forms.GroupBox();
            this.lbxRestockRequests = new System.Windows.Forms.ListBox();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.pnlAmountInStore = new System.Windows.Forms.Panel();
            this.pnlAmountInWarehouse = new System.Windows.Forms.Panel();
            this.lblStockMessage = new System.Windows.Forms.Label();
            this.lblAmountInStore = new System.Windows.Forms.Label();
            this.lblAmountInWarehouse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequestedAmount = new System.Windows.Forms.Label();
            this.pnlbackground = new System.Windows.Forms.Panel();
            this.gbxProductInformation.SuspendLayout();
            this.pnlAmountInStore.SuspendLayout();
            this.pnlAmountInWarehouse.SuspendLayout();
            this.pnlbackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRestockRequest
            // 
            this.lblRestockRequest.AutoSize = true;
            this.lblRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRestockRequest.Location = new System.Drawing.Point(31, 24);
            this.lblRestockRequest.Name = "lblRestockRequest";
            this.lblRestockRequest.Size = new System.Drawing.Size(233, 32);
            this.lblRestockRequest.TabIndex = 0;
            this.lblRestockRequest.Text = "Restock requests";
            // 
            // gbxProductInformation
            // 
            this.gbxProductInformation.BackColor = System.Drawing.Color.White;
            this.gbxProductInformation.Controls.Add(this.lblRequestedAmount);
            this.gbxProductInformation.Controls.Add(this.pnlAmountInWarehouse);
            this.gbxProductInformation.Controls.Add(this.label3);
            this.gbxProductInformation.Controls.Add(this.lblAmount);
            this.gbxProductInformation.Controls.Add(this.label1);
            this.gbxProductInformation.Controls.Add(this.lblStockMessage);
            this.gbxProductInformation.Controls.Add(this.pnlAmountInStore);
            this.gbxProductInformation.Controls.Add(this.lblProductBrand);
            this.gbxProductInformation.Controls.Add(this.lblProductTypeAndModel);
            this.gbxProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxProductInformation.Location = new System.Drawing.Point(579, 65);
            this.gbxProductInformation.Name = "gbxProductInformation";
            this.gbxProductInformation.Size = new System.Drawing.Size(517, 381);
            this.gbxProductInformation.TabIndex = 3;
            this.gbxProductInformation.TabStop = false;
            // 
            // lbxRestockRequests
            // 
            this.lbxRestockRequests.BackColor = System.Drawing.Color.White;
            this.lbxRestockRequests.CausesValidation = false;
            this.lbxRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxRestockRequests.FormattingEnabled = true;
            this.lbxRestockRequests.ItemHeight = 29;
            this.lbxRestockRequests.Location = new System.Drawing.Point(14, 15);
            this.lbxRestockRequests.Name = "lbxRestockRequests";
            this.lbxRestockRequests.Size = new System.Drawing.Size(489, 381);
            this.lbxRestockRequests.TabIndex = 0;
            this.lbxRestockRequests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxRestockRequests_DrawItem_1);
            this.lbxRestockRequests.SelectedIndexChanged += new System.EventHandler(this.lbxRestockRequests_SelectedIndexChanged);
            this.lbxRestockRequests.DoubleClick += new System.EventHandler(this.lbxRestockRequests_DoubleClick);
            this.lbxRestockRequests.MouseLeave += new System.EventHandler(this.lbxRestockRequests_MouseLeave);
            this.lbxRestockRequests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxRestockRequests_MouseMove);
            // 
            // lblProductTypeAndModel
            // 
            this.lblProductTypeAndModel.AutoSize = true;
            this.lblProductTypeAndModel.Location = new System.Drawing.Point(30, 31);
            this.lblProductTypeAndModel.Name = "lblProductTypeAndModel";
            this.lblProductTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblProductTypeAndModel.TabIndex = 0;
            this.lblProductTypeAndModel.Text = "Type and model";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(30, 84);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 1;
            this.lblProductBrand.Text = "Brand ";
            // 
            // pnlAmountInStore
            // 
            this.pnlAmountInStore.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlAmountInStore.Controls.Add(this.lblAmountInStore);
            this.pnlAmountInStore.Location = new System.Drawing.Point(34, 237);
            this.pnlAmountInStore.Name = "pnlAmountInStore";
            this.pnlAmountInStore.Size = new System.Drawing.Size(184, 63);
            this.pnlAmountInStore.TabIndex = 2;
            // 
            // pnlAmountInWarehouse
            // 
            this.pnlAmountInWarehouse.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlAmountInWarehouse.Controls.Add(this.lblAmountInWarehouse);
            this.pnlAmountInWarehouse.Location = new System.Drawing.Point(300, 237);
            this.pnlAmountInWarehouse.Name = "pnlAmountInWarehouse";
            this.pnlAmountInWarehouse.Size = new System.Drawing.Size(178, 63);
            this.pnlAmountInWarehouse.TabIndex = 3;
            // 
            // lblStockMessage
            // 
            this.lblStockMessage.AutoSize = true;
            this.lblStockMessage.Location = new System.Drawing.Point(30, 325);
            this.lblStockMessage.Name = "lblStockMessage";
            this.lblStockMessage.Size = new System.Drawing.Size(31, 29);
            this.lblStockMessage.TabIndex = 4;
            this.lblStockMessage.Text = "...";
            // 
            // lblAmountInStore
            // 
            this.lblAmountInStore.AutoSize = true;
            this.lblAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountInStore.Location = new System.Drawing.Point(71, 16);
            this.lblAmountInStore.Name = "lblAmountInStore";
            this.lblAmountInStore.Size = new System.Drawing.Size(39, 29);
            this.lblAmountInStore.TabIndex = 5;
            this.lblAmountInStore.Text = "00";
            // 
            // lblAmountInWarehouse
            // 
            this.lblAmountInWarehouse.AutoSize = true;
            this.lblAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountInWarehouse.Location = new System.Drawing.Point(71, 16);
            this.lblAmountInWarehouse.Name = "lblAmountInWarehouse";
            this.lblAmountInWarehouse.Size = new System.Drawing.Size(39, 29);
            this.lblAmountInWarehouse.TabIndex = 5;
            this.lblAmountInWarehouse.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "In store:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(222, 29);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Requested amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "In warehouse:";
            // 
            // lblRequestedAmount
            // 
            this.lblRequestedAmount.AutoSize = true;
            this.lblRequestedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestedAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRequestedAmount.Location = new System.Drawing.Point(295, 142);
            this.lblRequestedAmount.Name = "lblRequestedAmount";
            this.lblRequestedAmount.Size = new System.Drawing.Size(41, 29);
            this.lblRequestedAmount.TabIndex = 8;
            this.lblRequestedAmount.Text = "00";
            // 
            // pnlbackground
            // 
            this.pnlbackground.BackColor = System.Drawing.Color.White;
            this.pnlbackground.Controls.Add(this.lbxRestockRequests);
            this.pnlbackground.Location = new System.Drawing.Point(37, 65);
            this.pnlbackground.Name = "pnlbackground";
            this.pnlbackground.Size = new System.Drawing.Size(518, 381);
            this.pnlbackground.TabIndex = 4;
            // 
            // RestockRequestInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlbackground);
            this.Controls.Add(this.gbxProductInformation);
            this.Controls.Add(this.lblRestockRequest);
            this.Name = "RestockRequestInterface";
            this.Size = new System.Drawing.Size(1121, 747);
            this.gbxProductInformation.ResumeLayout(false);
            this.gbxProductInformation.PerformLayout();
            this.pnlAmountInStore.ResumeLayout(false);
            this.pnlAmountInStore.PerformLayout();
            this.pnlAmountInWarehouse.ResumeLayout(false);
            this.pnlAmountInWarehouse.PerformLayout();
            this.pnlbackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestockRequest;
        private System.Windows.Forms.GroupBox gbxProductInformation;
        private System.Windows.Forms.ListBox lbxRestockRequests;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Label lblStockMessage;
        private System.Windows.Forms.Panel pnlAmountInWarehouse;
        private System.Windows.Forms.Label lblAmountInWarehouse;
        private System.Windows.Forms.Panel pnlAmountInStore;
        private System.Windows.Forms.Label lblAmountInStore;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblRequestedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlbackground;
    }
}
