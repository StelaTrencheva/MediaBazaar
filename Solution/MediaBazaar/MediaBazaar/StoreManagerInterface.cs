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
    public partial class StoreManagerInterface : UserControl
    {
        private ManageEmployees manageEmployees;
        private int id;

        public StoreManagerInterface()
        {
            InitializeComponent();
        }

        public void SendInfo(ManageEmployees manageEmployees, int id)
        {
            this.manageEmployees = manageEmployees;
            this.id = id;
            this.UpdateLabel();
        }
        private void UpdateLabel()
        {
            lblStoreMFName.Text = $"First name: {manageEmployees.FindEmployee(id).FirstName}";
            lblStoreMLName.Text = $"Last name: {manageEmployees.FindEmployee(id).LastName}";
            lblStoreMBirthday.Text = $"Birthday: {manageEmployees.FindEmployee(id).Birthday}";
            lblStoreMBSN.Text = $"BSN: {manageEmployees.FindEmployee(id).BSN}";
            lblStoreMEmployeeType.Text = $"Eployee type: {manageEmployees.FindEmployee(id).Position}";
            lblStoreMContractType.Text = $"Contract type: {manageEmployees.FindEmployee(id).Contract}";
            lblStoreMPhoneNum.Text = $"Phone number: {manageEmployees.FindEmployee(id).PhoneNumber}";
            lblStoreMEmail.Text = $"Email: {manageEmployees.FindEmployee(id).Email}";
            lblStoreMAddress.Text = $"Address: {manageEmployees.FindEmployee(id).GetAddress()}";
        }
    }
}
