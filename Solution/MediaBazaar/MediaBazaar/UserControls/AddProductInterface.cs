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
    public partial class AddProductInterface : UserControl
    {
        ManageEmployees manageEmployees;
        public AddProductInterface()
        {
            InitializeComponent();
            this.manageEmployees = new ManageEmployees();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string catergory = tbxProductCategory.Text;
                string subCategory = tbxProductSubCategory.Text;
                string type = tbxProductType.Text;
                string brand = tbxProductBrand.Text;
                string model = tbxProductModel.Text;
                string description = tbxProductDescription.Text;
                decimal costPrice = Convert.ToDecimal(tbxProductCostPrice.Text);
                decimal salesPrice = Convert.ToDecimal(tbxProductSalesPrice.Text);
                int amountInStore = Convert.ToInt32(tbxProductAmountInStore.Text);
                int amountInWarehouse = Convert.ToInt32(tbxProductAmountInWarehouse.Text);

                if (this.manageEmployees.AddProductToDB(brand, type, model, description, catergory, subCategory, costPrice, 
                    salesPrice, amountInStore, amountInWarehouse))
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }

            lbxProductDisplay.Items.Clear();
            foreach (Product i in manageEmployees.GetAllProducts())
            {
                lbxProductDisplay.Items.Add(i.ToString());
            }
        }
    }
}
