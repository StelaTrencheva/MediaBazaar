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

namespace CashierApp
{
    public partial class MainForm : Form
    {
        Employee currentEmp;
        ProductManager productManager;
        BasketManager basketManager;
        public MainForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            this.productManager = new ProductManager();
            this.basketManager = new BasketManager();
            productManager.UpdateProducts();
            AllProducts();
            SetComboboxes();
        }
        private void AllProducts()
        {
            lboxProducts.CustomTabOffsets.Add(36);
            lboxProducts.UseCustomTabOffsets = true;
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetAllProducts())
            {
                lboxProducts.Items.Add(product.ToString());
                lboxProducts.Items.Add("");
            }
        }
        private void SetComboboxes()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("All");
            foreach (string category in productManager.GetCategories())
            {
                cbCategory.Items.Add(category);
            }
            cbCategory.SelectedIndex = 0;
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetAllProducts())
            {
                if (product.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    lboxProducts.Items.Add(product.ToString());
                    lboxProducts.Items.Add("");
                }
            }
        }

        private void lboxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxProducts.SelectedItem == null || lboxProducts.SelectedItem.ToString() == "")
            {
                return;
            }
            tbSelectedItem.Text = productManager.GetNameFromToString(lboxProducts.SelectedItem.ToString());
            updatetbProductPrice();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetProductsFromCategory(cbCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
            updateSubCategories();
            cbSubCategory.SelectedIndex = 0;
        }
        private void cbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetProductsFromCategory(cbCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }
        private void updateSubCategories()
        {
            List<string> subCategories = productManager.GetSubCategories(cbCategory.Text);
            cbSubCategory.Items.Clear();
            cbSubCategory.Items.Add("All");
            foreach (string subcat in subCategories)
            {
                cbSubCategory.Items.Add(subcat);
            }
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            if (tbSelectedItem.Text == "")
            {
                MessageBox.Show("Please select a product");
                return;
            }
            Product newProd = productManager.GetProductFromName(tbSelectedItem.Text);
            if (newProd == null)
            {
                MessageBox.Show("This product can not be found in the system");
                return;
            }
            basketManager.AddProduct(new SoldProduct(newProd, Convert.ToInt32(nudProductQuantity.Value)));
            updateBasket();
        }
        private void updateBasket()
        {
            lboxBasket.Items.Clear();
            foreach (SoldProduct product in basketManager.Basket)
            {
                lboxBasket.Items.Add(product);
                lboxBasket.Items.Add("");
            }
            tbFinalPrice.Text = basketManager.GetTotalPrice().ToString();
        }

        private void nudProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            updatetbProductPrice();
        }
        private void updatetbProductPrice()
        {
            tbProductPrice.Text = (productManager.GetPriceFromNames(tbSelectedItem.Text) * nudProductQuantity.Value).ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
