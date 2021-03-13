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
            Updatetbx();
        }
        
        private void Updatetbx()
        {
            tbxHRAdminFName.Text = manageEmployees.FindEmployee(id).FirstName;
            tbxHRAdminLName.Text = manageEmployees.FindEmployee(id).LastName;
            tbxHRAdminBSN.Text = manageEmployees.FindEmployee(id).BSN;
            tbxHRAdminEmployeeType.Text = manageEmployees.FindEmployee(id).Position.ToString();
            tbxHRAdminEmail.Text = manageEmployees.FindEmployee(id).Email;
            tbxHRAdminPhoneNum.Text = manageEmployees.FindEmployee(id).PhoneNumber;
            tbxHRAdminAddress.Text = manageEmployees.FindEmployee(id).GetAddress();
        }

        private void btnHRAdminEdit_Click(object sender, EventArgs e)
        {
            tbxHRAdminFName.ReadOnly = false;
            tbxHRAdminLName.ReadOnly = false;
            tbxHRAdminBSN.ReadOnly = false;
            tbxHRAdminPhoneNum.ReadOnly = false;
            tbxHRAdminEmail.ReadOnly = false;
            tbxHRAdminAddress.ReadOnly = false;
            btnHRAdminEdit.Visible = false;
            btnHRAdminSave.Visible = true;
        }

        private void btnHRAdminSave_Click(object sender, EventArgs e)
        {
            tbxHRAdminFName.ReadOnly = true;
            tbxHRAdminLName.ReadOnly = true;
            tbxHRAdminBSN.ReadOnly = true;
            tbxHRAdminPhoneNum.ReadOnly = true;
            tbxHRAdminEmail.ReadOnly = true;
            tbxHRAdminAddress.ReadOnly = true;
            btnHRAdminEdit.Visible = true;
            btnHRAdminSave.Visible = false;
        }
    }
}
