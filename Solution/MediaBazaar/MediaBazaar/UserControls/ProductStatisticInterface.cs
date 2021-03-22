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
        ManageEmployees manageEmployees;
        public ProductStatisticInterface()
        {
            InitializeComponent();
            this.manageEmployees = new ManageEmployees();
        }

        private void btnShowPRevenueProfit_Click(object sender, EventArgs e)
        {
            lbxDisplayPRevenueProfit.Items.Clear();

            int quantity = 5;
            foreach (Product i in this.manageEmployees.GetAllProducts())
            {
                lbxDisplayPRevenueProfit.Items.Add($"Product number: {i.PNumber} - {i.Brand} {i.Model} - Total revenue: " +
                    $"{i.SalePrice * quantity} Total profit: {(i.SalePrice * quantity) - (i.CostPrice * quantity)} " +
                    $"- for {quantity} Quality");
            }
        }
    }
}
