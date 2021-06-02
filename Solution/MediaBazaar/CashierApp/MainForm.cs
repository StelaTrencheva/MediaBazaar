using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        DepartmentManager departmentManager;
        BasketManager basketManager;
        string barcode;
        string searchtext;

        public MainForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            this.productManager = new ProductManager();
            this.basketManager = new BasketManager();
            this.departmentManager = new DepartmentManager();
            productManager.UpdateProducts();
            AllProducts();
            SetComboboxes();
            barcode = "";
            searchtext = "";
        }
        //TEST
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Focus();
                searchtext = "";
                Test();
                e.Handled = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            char c = (char)keyData;

            if (char.IsNumber(c))
            {
                barcode += c;
            }
            if (char.IsLetterOrDigit(c))
            {
                searchtext += c;
                Test();
            }
            else
            {
                searchtext = "";
                AllProducts();
            }

            if (c == (char)Keys.Return)
            {

                ScanedProductToBasket(barcode);
                barcode = "";
                searchtext = "";
                lboxBasket.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        //TEST
        private void ScanedProductToBasket(string barcode)
        {
            Product scannedProduct = productManager.GetProductByBarcode(barcode);
            if (scannedProduct == null)
            {
                SystemSounds.Exclamation.Play();
                return;
            }
            basketManager.AddProduct(new SoldProduct(scannedProduct, 1));
            updateBasket();

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
            clearDepartments();
            clearCategories();
            clearSubCategories();
            setCbDepartments();
        }
        private void setCbDepartments()
        {
            foreach (Department department in departmentManager.GetDepartments())
            {
                cbDepartment.Items.Add(department.Name);
            }
        }
        //TEST
        private void Test()
        {
            cbDepartment.SelectedIndex = 0;
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetAllProducts())
            {
                if (product.ToString().ToLower().Contains(searchtext.ToLower()))
                {
                    lboxProducts.Items.Add(product.ToString());
                    lboxProducts.Items.Add("");
                }
            }
        }
        //TEST

        private void lboxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxProducts.SelectedItem == null || lboxProducts.SelectedItem.ToString() == "")
            {
                return;
            }
            tbSelectedItem.Text = productManager.GetNameFromToString(lboxProducts.SelectedItem.ToString());
            updatetbProductPrice();
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

            if (rbtnCash.Checked == true)
            {
                basketManager.ExecuteOrder(currentEmp.Id, PaymentType.CASH);
            }
            else if (rbtnCard.Checked == true)
            {
                basketManager.ExecuteOrder(currentEmp.Id, PaymentType.CARD);
            }
            basketManager.ClearBascet();
            updateBasket();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchtext = "";
            if (cbDepartment.SelectedItem.ToString() == "All")
            {
                AllProducts();
                clearCategories();
            }
            else
            {
                updateCategories(getDeptCode());
            }

        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchtext = "";
            if (cbCategory.SelectedItem.ToString() == "All")
            {
                clearSubCategories();
                //updateProductsByDepartment();
            }
            else
            {
                updateSubCategories();
                updateProductsByCategory();
            }
        }
        private void cbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchtext = "";
            if (cbSubCategory.SelectedItem.ToString() == "All")
            {
                updateProductsByDepartment();
            }
            else
            {
                updateProductsBySubCategory();
            }
        }
        private void updateSubCategories()
        {
            clearSubCategories();
            foreach (string category in departmentManager.GetDepartmentSubcategories(getDeptCode(), cbCategory.SelectedItem.ToString()))
            {
                cbSubCategory.Items.Add(category);
            }
        }
        private void updateProductsByCategory()
        {
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetProductsFromDepartmentCategoryDB(getDeptCode(), cbCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }
        private void updateProductsBySubCategory()
        {
            lboxProducts.Items.Clear();
            foreach (Product product in productManager.GetProductsFromSubcategoryDB(getDeptCode(), cbCategory.SelectedItem.ToString(), cbSubCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }
        private void updateCategories(int deptCode)
        {
            clearCategories();
            foreach (string category in departmentManager.GetDepartmentCategorieDB(deptCode))
            {
                cbCategory.Items.Add(category);
            }
        }
        private void updateProductsByDepartment()
        {
            if (cbDepartment.SelectedItem.ToString() != "All")
            {
                int code = getDeptCode();
                lboxProducts.Items.Clear();
                foreach (Product product in productManager.GetProductsFromDepartmentDB(code))
                {
                    lboxProducts.Items.Add(product);
                    lboxProducts.Items.Add("");
                }
                //updateCategories(code);
            }
            else
            {
                AllProducts();
            }
        }
        private int getDeptCode()
        {
            return departmentManager.GetDepartmentCode(cbDepartment.SelectedItem.ToString());
        }
        private void clearDepartments()
        {
            cbDepartment.Items.Clear();
            cbDepartment.Items.Add("All");
            cbDepartment.SelectedIndex = 0;
        }
        private void clearCategories()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("All");
            cbCategory.SelectedIndex = 0;
        }
        private void clearSubCategories()
        {
            cbSubCategory.Items.Clear();
            cbSubCategory.Items.Add("All");
            cbSubCategory.SelectedIndex = 0;
        }

        private void btnRemovePiece_Click(object sender, EventArgs e)
        {
            if (lboxBasket.SelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            string barcode = basketManager.GetProductBarcode(lboxBasket.SelectedItem.ToString());
            if (barcode == null)
            {
                MessageBox.Show("This product can not be found in the system");
                return;
            }
            basketManager.RemovePiece(barcode);
            updateBasket();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lboxBasket.SelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            string barcode = basketManager.GetProductBarcode(lboxBasket.SelectedItem.ToString());
            if (barcode == null)
            {
                MessageBox.Show("This product can not be found in the system");
                return;
            }
            basketManager.RemoveProduct(barcode);
            updateBasket();
        }

        private void btnClearBascet_Click(object sender, EventArgs e)
        {
            basketManager.ClearBascet();
            updateBasket();
        }

        private void cbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbSubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
