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
        private void AddProductInterface_Load(object sender, EventArgs e)
        {
            UpdateListBoxAllProducts();
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

                if (manageEmployees.AddProductToDB(brand, type, model, description, catergory, subCategory, costPrice, 
                    salesPrice, amountInStore, amountInWarehouse))
                {
                    MessageBox.Show("Success!");
                    UpdateListBoxAllProducts();
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
            catch (IncorrectPricingException)
            {
                MessageBox.Show("The sale price can not be smaller than the cost price");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("This product already exist");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }
        private void UpdateListBoxAllProducts()
        {
            lbxProductDisplay.Items.Clear();
            foreach (Product i in manageEmployees.GetAllProducts())
            {
                lbxProductDisplay.Items.Add(i.ToString());
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lbxProductDisplay.SelectedItem==null)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            foreach (Product i in manageEmployees.GetAllProducts())
            {
                if (lbxProductDisplay.SelectedItem.ToString() == i.ToString())
                {
                    if(manageEmployees.DeleteAProduct(i.PNumber))
                    {
                        MessageBox.Show("Success");
                        UpdateListBoxAllProducts();
                        return;
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed deleting");
                        UpdateListBoxAllProducts();
                        return;
                        
                    }
                }
            }
        }
    }
}
