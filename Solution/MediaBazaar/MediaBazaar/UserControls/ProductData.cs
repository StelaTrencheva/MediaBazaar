﻿using System;
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
            manageEmployees = new ManageEmployees();
            UpdateListBoxProducts();
        }

        private void UpdateListBoxProducts()
        {
            lbxProductDisplay.Items.Clear();
            foreach (Product i in manageEmployees.GetAllProducts())
            {
                lbxProductDisplay.Items.Add(i.ToString());
                lbxProductDisplay.Items.Add("");
            }
        }

        private void btnViewPInfo_Click(object sender, EventArgs e)
        {
            if(lbxProductDisplay.SelectedItem == null || lbxProductDisplay.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select a product.");
            }
            else
            {
                foreach(Product i in manageEmployees.GetAllProducts())
                {
                    if(lbxProductDisplay.SelectedItem.ToString() == i.ToString())
                    {
                        ProductInfoForm productInfo = new ProductInfoForm();
                        productInfo.Show();
                    }
                }
            }
        }
    }
}
