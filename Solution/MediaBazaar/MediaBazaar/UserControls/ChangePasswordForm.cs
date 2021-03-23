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
    public partial class ChangePasswordForm : Form
    {
        Employee employee;
        ManageEmployees mngEmp;
        public ChangePasswordForm(Employee emp)
        {
            InitializeComponent();
            this.employee = emp;
            mngEmp = new ManageEmployees();
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            string newPass = txbNewPassword.Text.ToString();
            string oldPass = txbOldPassword.Text.ToString();
            string repeatOldPass = txbRepeatNewPassword.Text.ToString();

            if (String.IsNullOrEmpty(txbNewPassword.Text.ToString()) ||
                String.IsNullOrEmpty(txbOldPassword.Text.ToString()) ||
                String.IsNullOrEmpty(txbRepeatNewPassword.Text.ToString()))
            {
                MessageBox.Show("Your input is not valid");
                return;
            }

            if (oldPass != employee.Password && !String.IsNullOrEmpty(oldPass))
            { 
                MessageBox.Show("Wrong password!");
                return;
            }
            if (newPass == employee.Password && !String.IsNullOrEmpty(newPass))
            { 
                MessageBox.Show("This password is already used!");
                return;
            }
            if (newPass != repeatOldPass && !String.IsNullOrEmpty(newPass) && !String.IsNullOrEmpty(repeatOldPass))
            { 
                MessageBox.Show("Your repeat password does not match your new password!");
                return;
            }
            try
            {
                if (mngEmp.ChangePassword(newPass, employee.Id))
                { MessageBox.Show("Password changed successfully!"); }
                else { MessageBox.Show("Change password failed. Please try again."); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input. Try again");
            }
        }
    }
}
