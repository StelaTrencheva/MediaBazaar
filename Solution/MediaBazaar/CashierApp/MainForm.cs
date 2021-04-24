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
        public MainForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            this.productManager = new ProductManager();
            productManager.UpdateProducts();
            AllProducts();
            SetComboboxes();
        }
        private void AllProducts()
        {
            lboxProducts.CustomTabOffsets.Add(40);
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
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetProductsFromCategory(cbCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }


    }
}
