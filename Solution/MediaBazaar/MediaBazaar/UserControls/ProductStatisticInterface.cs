using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class ProductStatisticInterface : UserControl
    {
        ProductManager pManager;

        public ProductStatisticInterface()
        {
            InitializeComponent();
            this.pManager = new ProductManager();
            UpdateListBoxAllProducts();
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBoxAllProducts();
        }
        public void UpdateListBoxAllProducts()
        {
            lbxDisplayPRevenueProfit.Items.Clear();
            foreach (Product i in this.pManager.GetAllProducts())
            {
                lbxDisplayPRevenueProfit.Items.Add(i.GetStatistic(Convert.ToInt32(nudAmount.Value)));
            }
        }
    }
}
