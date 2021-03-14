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
    public partial class ProductData : UserControl
    {
        ManageEmployees manageEmployees;

        public ProductData()
        {
            InitializeComponent();
            manageEmployees = new ManageEmployees(1);
            foreach (Product i in manageEmployees.GetAllProducts())
            {
                lbxProductDisplay.Items.Add(i.ToString());
            }
        }
    }
}
