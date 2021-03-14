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
    public partial class HRAdminInterface : UserControl
    {
        private ManageEmployees manageEmployees;
        private int id = 0;

        public HRAdminInterface()
        {
            InitializeComponent();
        }
        public void SendInfo(ManageEmployees manageEmployees,int id)
        {
            this.manageEmployees = manageEmployees;
            this.id = id;
            UpdateLabel();
        }
        
        private void UpdateLabel()
        {
            lblHRAdminFName.Text = $"First name: {manageEmployees.FindEmployee(id).FirstName}";
            lblHRAdminLName.Text = $"Last name: {manageEmployees.FindEmployee(id).LastName}";
            lblHRAdminBirthday.Text = $"Birthday: {manageEmployees.FindEmployee(id).Birthday}";
            lblHRAdminBSN.Text = $"BSN: {manageEmployees.FindEmployee(id).BSN}";
            lblHRAdminEmployeeType.Text = $"Eployee type: {manageEmployees.FindEmployee(id).Position}";
            lblHRAdminContractType.Text = $"Contract type: {manageEmployees.FindEmployee(id).Contract}";
            lblHRAdminPhoneNum.Text = $"Phone number: {manageEmployees.FindEmployee(id).PhoneNumber}";
            lblHRAdminEmail.Text = $"Email: {manageEmployees.FindEmployee(id).Email}";
            lblHRAdminAddress.Text = $"Address: {manageEmployees.FindEmployee(id).GetAddress()}";
        }
    }
}
