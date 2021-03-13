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
    public partial class ManageEmployeeInterface : UserControl
    {
        ManageEmployees mngEmp;
        //DatabaseMediator db;
        public ManageEmployeeInterface()
        {
            InitializeComponent();
            //db = new DatabaseMediator();
            mngEmp = new ManageEmployees(1);
        }
       

        private void ManageEmployeeInterface_Load(object sender, EventArgs e)
        {

           // List<string> EmpList = 
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //int index = lbxDisplayRemove.SelectedIndex + 1;
            //if (db.RemoveEmployee(index))
            //{
            //    MessageBox.Show("Success!");
            //}
            //else { MessageBox.Show("Try again"); }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try { 
                string FName = tbxFName.Text.ToString();
                string LName = tbxLName.Text.ToString();
                string bsn = tbxBSN.Text.ToString();
                string email = tbxEmail.Text.ToString();
                string username = tbxUsername.Text.ToString();
                string password = FName + "0000";
                DateTime birthDay = dtpDateOfBirth.Value;
                string addrStreet = tbxStreet.Text.ToString();
                string addrStreetNumber = tbxHouseNumber.Text.ToString();
                string addrZipcode = tbxZipCode.Text.ToString();
                string addrTown = tbxTown.Text.ToString();
                string addrCountry = tbxCountry.Text.ToString();
                DateTime firstWorkingDay = dtpDateFWD.Value;
                string emergencyPhoneNumber = tbxEmTelNum.Text.ToString();
                string iban = tbxBankAccNum.Text.ToString();
                double hourlyWage = double.Parse(tbxHourlyWage.Text);
                DateTime contractStartDate = dtpContractStartDate.Value;
                ContractType contract = (ContractType)(cbxContractType.SelectedIndex);
                EmployeeType position = (EmployeeType)(cbxTypeOfEmployee.SelectedIndex);

                if (mngEmp.AddEmployeeToDb( bsn, FName, LName,  email,  username,  password,  birthDay,
                 addrStreet,  addrStreetNumber,  addrZipcode,  addrTown,  addrCountry,
                  firstWorkingDay,  emergencyPhoneNumber,  iban,  hourlyWage,  contractStartDate, contract,  position))
                {
                    MessageBox.Show("Success!");
                }
                else { MessageBox.Show("Try again"); }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }

    }
}
