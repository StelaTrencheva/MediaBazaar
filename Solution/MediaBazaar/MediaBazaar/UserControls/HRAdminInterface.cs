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
    public partial class HRAdminInterface : UserControl
    {
        Employee employee;
        ChangePasswordForm changePasswordForm;
        public HRAdminInterface()
        {
            InitializeComponent();
        }
        public void SendInfo(Employee employee)
        {
            this.employee = employee;
            UpdateLabel();
        }
        
        private void UpdateLabel()
        {
            lblHRAdminFName.Text = $"First name: {employee.FirstName}";
            lblHRAdminLName.Text = $"Last name: {employee.LastName}";
            lblHRAdminGender.Text = $"Gender: {employee.Gender}";
            lblHRAdminBirthday.Text = $"Birthday: {employee.Birthday.ToString("dd-MM-yyyy")}";
            lblHRAdminBSN.Text = $"BSN: {employee.BSN}";
            lblHRAdminEmployeeType.Text = $"Eployee type: {employee.Position}";
            lblHRAdminContractType.Text = $"Contract type: {employee.Contract}";
            lblHRAdminPhoneNum.Text = $"Phone number: {employee.PhoneNumber}";
            lblHRAdminEmail.Text = $"Email: {employee.Email}";
            lblHRAdminAddress.Text = $"Address: {employee.GetAddress()}";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changePasswordForm = new ChangePasswordForm(employee);
            changePasswordForm.ShowDialog();

        }
    }
}
