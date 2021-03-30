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
    public partial class HRAdminForm : Form
    {
        ManageEmployees manageEmployees;
        Employee currentEmp;
        
        public HRAdminForm(Employee employee)
        {
            InitializeComponent();
            this.manageEmployees = new ManageEmployees();
            currentEmp = employee;
            userInterface1.SendInfo(currentEmp);
        }
        
        private void PaintAllButtons()
        {
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
            btnHRAdminManageEmployee.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            userInterface1.Hide();
            manageEmployeeInterface1.Hide();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            HideAllInterfaces();
            manageEmployeeInterface1.Show();
            PaintAllButtons();
            btnHRAdminManageEmployee.BackColor = Color.White;
            
        }

        private void btnHRAdminAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            HideAllInterfaces();
            btnHRAdminAccount.BackColor = Color.White;
            userInterface1.Show();
        }

        private void btnHRAdminLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void userInterface1_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnHRAdminAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }
    }
}
