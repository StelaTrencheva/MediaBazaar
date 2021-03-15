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
    public partial class StockManagerInterface : UserControl
    {
        private ManageEmployees manageEmployees;
        private int id;
        public StockManagerInterface()
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
            lblStockMFName.Text = $"First name: {manageEmployees.FindEmployee(id).FirstName}";
            lblStockMLName.Text = $"Last name: {manageEmployees.FindEmployee(id).LastName}";
            lblStockMGender.Text = $"Gender: {manageEmployees.FindEmployee(id).Gender}";
            lblStockMBirthday.Text = $"Birthday: {manageEmployees.FindEmployee(id).Birthday.ToString("dd-MM-yyyy")}";
            lblStockMBSN.Text = $"BSN: {manageEmployees.FindEmployee(id).BSN}";
            lblStockMEmployeeType.Text = $"Eployee type: {manageEmployees.FindEmployee(id).Position}";
            lblStockMContractType.Text = $"Contract type: {manageEmployees.FindEmployee(id).Contract}";
            lblStockMPhoneNum.Text = $"Phone number: {manageEmployees.FindEmployee(id).PhoneNumber}";
            lblStockMEmail.Text = $"Email: {manageEmployees.FindEmployee(id).Email}";
            lblStockMAddress.Text = $"Address: {manageEmployees.FindEmployee(id).GetAddress()}";
        }
    }
}
