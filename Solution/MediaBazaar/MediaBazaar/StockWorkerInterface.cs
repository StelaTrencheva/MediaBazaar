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
    public partial class StockWorkerInterface : UserControl
    {
        private ManageEmployees manageEmployees;
        private int id;

        public StockWorkerInterface()
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
            lblStockWFName.Text = $"First name: {manageEmployees.FindEmployee(id).FirstName}";
            lblStockWLName.Text = $"Last name: {manageEmployees.FindEmployee(id).LastName}";
            lblStockWGender.Text = $"Gender: {manageEmployees.FindEmployee(id).Gender}";
            lblStockWBirthday.Text = $"Birthday: {manageEmployees.FindEmployee(id).Birthday.ToString("dd-MM-yyyy")}";
            lblStockWBSN.Text = $"BSN: {manageEmployees.FindEmployee(id).BSN}";
            lblStockWEmployeeType.Text = $"Eployee type: {manageEmployees.FindEmployee(id).Position}";
            lblStockWContractType.Text = $"Contract type: {manageEmployees.FindEmployee(id).Contract}";
            lblStockWPhoneNum.Text = $"Phone number: {manageEmployees.FindEmployee(id).PhoneNumber}";
            lblStockWEmail.Text = $"Email: {manageEmployees.FindEmployee(id).Email}";
            lblStockWAddress.Text = $"Address: {manageEmployees.FindEmployee(id).GetAddress()}";
        }
    }
}
