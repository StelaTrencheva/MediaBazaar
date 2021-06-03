﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{
    public partial class RestockRequestInterface : UserControl
    {
        private int prevIndex = -1;
        RestockRequestManager requestManager;
        public RestockRequestInterface()
        {
            InitializeComponent();
            requestManager = new RestockRequestManager();
            lbxRestockRequests.DrawMode = DrawMode.OwnerDrawFixed;
            lbxRestockRequests.DrawItem += new DrawItemEventHandler(lbxRestockRequests_DrawItem_1);
            lbxStockInWarehouse.DrawMode = DrawMode.OwnerDrawFixed;
            lbxStockInWarehouse.DrawItem += new DrawItemEventHandler(lbxStockInWarehouse_DrawItem);
            this.UpdateRestockRequests();

        }

        public void UpdateRestockRequests()
        {
            btnAcceptRequest.Visible = false;
            btnDenyRequest.Visible = false;
            btnDenyRequest.BackColor = Color.White;
            btnAcceptRequest.BackColor = Color.White;
            gbxStore.Visible = false;
            gbxSupplier.Enabled = false;
            this.ClearInfoLabels();
            lbxRestockRequests.Items.Clear();
            lbxStockInWarehouse.Items.Clear();
            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if (product.Value != 0)
                {
                    lbxRestockRequests.Items.Add($"{product.Key.Type} - {product.Key.Brand}");
                }
                else
                {
                    requestManager.DeleteRestockRequest(product.Key.PNumber);
                }
            }
            foreach(Product product in requestManager.GetListOfAllProducts())
            {
                lbxStockInWarehouse.Items.Add($"{product.Type} - {product.Brand}");
            }
        }

        private void lbxRestockRequests_DoubleClick(object sender, EventArgs e)
        {
            lblRequestedAmount.Visible = true;
            lblAmountInStore.Visible = true;
            pnlAmountInStore.Visible = true;
            lblStockInStoreLabel.Visible = true;
            lblAmount.Visible = true;
            btnAcceptRequest.Visible = true;
            btnDenyRequest.Visible = false;
            this.ClearGroupBoxes();

            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if (lbxRestockRequests.Items[prevIndex].ToString() == $"{product.Key.Type} - {product.Key.Brand}")
                {
                    lblProductTypeAndModel.Text = $"{product.Key.Type} ({product.Key.Model})";
                    lblProductBrand.Text = $"{product.Key.Brand}";
                    lblRequestedAmount.Text = $"{product.Value}";
                    lblAmountInStore.Text = $"{product.Key.AmountInStore}";
                    lblAmountInWarehouse.Text = $"{product.Key.AmountInWarehouse}";
                    if (product.Key.AmountInWarehouse < product.Value)
                    {
                        pnlAmountInWarehouse.BackColor = Color.OrangeRed;
                        lblStockMessage.Text = "Not enough stock in the warehouse!";
                    }
                    else
                    {
                        pnlAmountInWarehouse.BackColor = Color.YellowGreen;
                        lblStockMessage.Text = "The request can be proceed!";
                    }
                    lblSendRequestToTheSupplier.Text = "Send request to \r\nthe supplier:";
                    gbxSupplier.Enabled = true;
                    foreach (var request in requestManager.GetAllSupplierRequests())
                    {
                        if (request.Key.PNumber == product.Key.PNumber)
                        {
                            lblSendRequestToTheSupplier.Text = "Request already \r\n sent";
                            gbxSupplier.Enabled = false;
                        }
                    }
                }
            }
        }

        public void ClearInfoLabels()
        {
            lblProductTypeAndModel.Text = "Type and model";
            lblProductBrand.Text = "Brand";
            lblRequestedAmount.Text = "0";
            lblAmountInStore.Text = "0";
            lblAmountInWarehouse.Text = "0";
        }

        private void lbxRestockRequests_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbxRestockRequests.IndexFromPoint(lbxRestockRequests.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                lbxRestockRequests.Invalidate();
            }
        }

        private void lbxRestockRequests_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            lbxRestockRequests.Invalidate();
        }

        private void lbxRestockRequests_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Color c;
            if (e.Index == prevIndex)
            {
                c = Color.Yellow;
            }
            else
            {
                c = Color.LightBlue;
            }
            using (SolidBrush brsh = new SolidBrush(c))
            {
                g.FillRectangle(brsh, e.Bounds);
            }
            using (SolidBrush brsh = new SolidBrush(e.ForeColor))
            {
                g.DrawString(lbxRestockRequests.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        private void lbxRestockRequests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceptRequest_MouseHover(object sender, EventArgs e)
        {
            btnAcceptRequest.BackColor = Color.LightSkyBlue;
        }

        private void btnDenyRequest_MouseHover(object sender, EventArgs e)
        {
            btnDenyRequest.BackColor = Color.LightSkyBlue;
        }

        private void btnDenyRequest_MouseLeave(object sender, EventArgs e)
        {
            btnDenyRequest.BackColor = Color.White;
        }

        private void btnAcceptRequest_MouseLeave(object sender, EventArgs e)
        {
            btnAcceptRequest.BackColor = Color.White;
        }

        private void btnDenyRequest_Click(object sender, EventArgs e)
        {
            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if (lblProductTypeAndModel.Text == $"{product.Key.Type} ({product.Key.Model})")
                {
                    requestManager.DeleteRestockRequest(product.Key.PNumber);
                }
            }
            this.UpdateRestockRequests();
            btnAcceptRequest.BackColor = Color.White;

        }

        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            btnDenyRequest.BackColor = Color.White;
            btnAcceptRequest.BackColor = Color.LightSkyBlue;
            btnDenyRequest.Visible = true;

            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if (lblProductTypeAndModel.Text == $"{product.Key.Type} ({product.Key.Model})")
                {
                    if (product.Key.AmountInWarehouse < product.Value && product.Key.AmountInWarehouse != 0)
                    {
                        gbxStore.Visible = true;
                        numSendAmount.Maximum = product.Key.AmountInWarehouse;
                        numSendAmount.Value = product.Key.AmountInWarehouse;
                        txbRequestedAmount.Text = "40";
                    }
                    else if (product.Key.AmountInWarehouse >= product.Value && product.Key.AmountInWarehouse != 0)
                    {
                        gbxStore.Visible = true;
                        numSendAmount.Maximum = product.Value;
                        numSendAmount.Value = product.Value;
                    }
                }
            }
        }

        public void ClearGroupBoxes()
        {
            numSendAmount.Value = 0;
            txbRequestedAmount.Text = String.Empty;
            gbxStore.Visible = false;
        }

        private void btnStoreSend_Click(object sender, EventArgs e)
        {
            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if (lblProductTypeAndModel.Text == $"{product.Key.Type} ({product.Key.Model})")
                {
                    requestManager.SendStockToStore(product.Key.PNumber, (product.Key.AmountInStore + Convert.ToInt32(numSendAmount.Value)), (product.Key.AmountInWarehouse - Convert.ToInt32(numSendAmount.Value)));
                    requestManager.UpdateRestockRequest(product.Key.PNumber, product.Value - Convert.ToInt32(numSendAmount.Value));
                    lblRequestedAmount.Text = $"{product.Value - Convert.ToInt32(numSendAmount.Value)}";
                    lblAmountInStore.Text = $"{product.Key.AmountInStore + Convert.ToInt32(numSendAmount.Value)}";
                    lblAmountInWarehouse.Text = $"{product.Key.AmountInWarehouse - Convert.ToInt32(numSendAmount.Value)}";
                    if (product.Value - Convert.ToInt32(numSendAmount.Value) == 0)
                    {
                        this.UpdateRestockRequests();
                    }
                    numSendAmount.Value = 0;
                }
            }
        }

        private void btnSendSupplierRequest_Click(object sender, EventArgs e)
        {
            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if (lblProductTypeAndModel.Text == $"{product.Key.Type} ({product.Key.Model})")
                {
                    requestManager.SendSupplierRequest(product.Key.PNumber, Convert.ToInt32(txbRequestedAmount.Text));
                    MessageBox.Show("After the stock manager's approval the request will be send to the supplier.");
                    numSendAmount.Value = 0;
                    txbRequestedAmount.Text = String.Empty;
                    lblSendRequestToTheSupplier.Text = "Request already \r\n sent";
                    gbxSupplier.Enabled = false;
                }
            }

        }

        private void lbxStockInWarehouse_DoubleClick(object sender, EventArgs e)
        {
            lblRequestedAmount.Visible = true;
            lblAmountInStore.Visible = true;
            pnlAmountInStore.Visible = true;
            lblStockInStoreLabel.Visible = true;
            lblAmount.Visible = true;
            foreach (Product product in requestManager.GetListOfAllProducts())
            {
                if (lbxStockInWarehouse.Items[prevIndex].ToString() == $"{product.Type} - {product.Brand}")
                {
                    lblProductTypeAndModel.Text = $"{product.Type} ({product.Model})";
                    lblProductBrand.Text = $"{product.Brand}";
                    lblAmountInWarehouse.Text = $"{product.AmountInWarehouse}";
                    pnlAmountInWarehouse.BackColor = Color.YellowGreen;
                    lblRequestedAmount.Visible = false;
                    lblAmountInStore.Visible = false;
                    pnlAmountInStore.Visible = false;
                    lblStockInStoreLabel.Visible = false;
                    lblAmount.Visible = false;
                    btnAcceptRequest.Visible = false;
                    lblSendRequestToTheSupplier.Text = "Send request to \r\nthe supplier:";
                    gbxSupplier.Enabled = true;
                    foreach (var requestedProduct in requestManager.GetAllSupplierRequests())
                    {
                        if (requestedProduct.Key.PNumber == product.PNumber)
                        {
                            gbxSupplier.Enabled = false;
                            lblSendRequestToTheSupplier.Text = "Request already \r\nsent";
                        }
                    }
                }
            }
        }

        private void lbxStockInWarehouse_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbxStockInWarehouse.IndexFromPoint(lbxStockInWarehouse.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                lbxStockInWarehouse.Invalidate();
            }
        }

        private void lbxStockInWarehouse_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            lbxStockInWarehouse.Invalidate();
        }

        private void lbxStockInWarehouse_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Color c;
            if (e.Index == prevIndex)
            {
                c = Color.YellowGreen;
            }
            else
            {
                c = Color.LightBlue;
            }
            using (SolidBrush brsh = new SolidBrush(c))
            {
                g.FillRectangle(brsh, e.Bounds);
            }
            using (SolidBrush brsh = new SolidBrush(e.ForeColor))
            {
                g.DrawString(lbxStockInWarehouse.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }
    }
}
