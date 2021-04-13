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
    public partial class LoginForm : Form
    {
        EmployeeManager manageEmployees;
        public LoginForm()
        {
            InitializeComponent();
            manageEmployees = new EmployeeManager();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Employee currentEmp= manageEmployees.Login(tbUserName.Text, tbPassword.Text);
            if (currentEmp == null)
            {
                MessageBox.Show("This user does not exist");
                tbPassword.Text = "";
                return;
            }
            else if(currentEmp.Position == EmployeeType.HR)
            {
                //When the login information of a HR is correct
                HRAdminForm form = new HRAdminForm(currentEmp);
                this.Hide();
                form.ShowDialog();
                this.Close();
            } 
            else if (currentEmp.Position == EmployeeType.STORE_MANAGER)
            {
                //When the login information of a store manager is correct
                StoreManagerForm form = new StoreManagerForm(currentEmp);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (currentEmp.Position == EmployeeType.DEPARTMENT_MANAGER)
            {
                //When the login information of a department manager is correct
                DepartmentManagerForm form = new DepartmentManagerForm(currentEmp);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (currentEmp.Position == EmployeeType.STOCK_MANAGER)
            {
                //When the login information of a stock manager is correct
                StockManagerForm form = new StockManagerForm(currentEmp);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (currentEmp.Position == EmployeeType.STOCK_WORKER)
            {
                //When the login information of a stock worker is correct
                StockWorkerForm form = new StockWorkerForm(currentEmp);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (currentEmp.Position == EmployeeType.STORE_WORKER)
            {
                //When the login information of a stock worker is correct
                MessageBox.Show($"Hello {currentEmp.FirstName}! You dont have access to the application.\nSoon you will have access to the website.");
            }
        }
    }
}