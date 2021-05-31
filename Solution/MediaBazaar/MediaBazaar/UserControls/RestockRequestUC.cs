using System;
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
            this.UpdateRestockRequests();
        }

        public void UpdateRestockRequests()
        {
            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                lbxRestockRequests.Items.Add($"{product.Value.Type} - {product.Value.Brand}");
            }
        }

        private void lbxRestockRequests_DoubleClick(object sender, EventArgs e)
        {
            
            foreach (var product in requestManager.GetAllRequestedProducts())
            {
                if(lbxRestockRequests.Items[prevIndex].ToString() == $"{product.Value.Type} - {product.Value.Brand}")
                {
                    lblProductTypeAndModel.Text = $"{product.Value.Type} ({product.Value.Model})";
                    lblProductBrand.Text = $"{product.Value.Brand}";
                    lblRequestedAmount.Text = $"{product.Key}";
                    lblAmountInStore.Text = $"{product.Value.AmountInStore}";
                    lblAmountInWarehouse.Text = $"{product.Value.AmountInWarehouse}";
                    if(product.Value.AmountInWarehouse < product.Key)
                    {
                        pnlAmountInWarehouse.BackColor = Color.OrangeRed;
                        lblStockMessage.Text = "Not enough stock in the warehouse!";
                    }
                    else
                    {
                        pnlAmountInWarehouse.BackColor = Color.YellowGreen;
                        lblStockMessage.Text = "The request can be proceed!";
                    }
                }
            }
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
    }
}
