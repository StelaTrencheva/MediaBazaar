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
        ManageEmployees manageEmployees;
        ChangeEmployeeWorkingContractForm changeContractForm;
        public ManageEmployeeInterface()
        {
            InitializeComponent();
            manageEmployees = new ManageEmployees();
        }
       

        private void ManageEmployeeInterface_Load(object sender, EventArgs e)
        {
            manageEmployees.UpdateEmployees();
            UpdateListBoxEmployee();
            SetComboBoxes();
            UpdateListBoxViewEmployees();
        }
        private void UpdateListBoxViewEmployees()
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                lbxViewEmployees.Items.Add(emp.ToString());
                lbxViewEmployees.Items.Add("");
            }
        }
        private void SetComboBoxes()
        {
            cbxContractType.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
            cbxTypeOfEmployee.SelectedIndex = 0;
        }
        private void UpdateListBoxEmployee()
        {
            lbxDisplayEMployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                lbxDisplayEMployees.Items.Add(emp.GetInfo);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if(lbxDisplayEMployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            
            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
               if(emp.GetInfo == lbxDisplayEMployees.SelectedItem.ToString())
                {
                    changeContractForm = new ChangeEmployeeWorkingContractForm(emp);
                    changeContractForm.ShowDialog();
                    UpdateListBoxEmployee();
                    return;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try { 
                string FName = tbxFName.Text.ToString();
                string LName = tbxLName.Text.ToString();
                Gender gender = (Gender)(cbxGender.SelectedIndex);
                string bsn = tbxBSN.Text.ToString();
                string email = tbxEmail.Text.ToString();
                string username = tbxUsername.Text.ToString();
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

                if (manageEmployees.AddEmployeeToDb( bsn, FName, LName, gender,  email,  username,   birthDay,
                 addrStreet,  addrStreetNumber,  addrZipcode,  addrTown,  addrCountry,
                  firstWorkingDay,  emergencyPhoneNumber,  iban,  hourlyWage,  /*contractStartDate,*/ contract,  position))
                {
                    MessageBox.Show("Success!");
                    UpdateListBoxViewEmployees();
                    UpdateListBoxEmployee();
                }
                else { MessageBox.Show("Try again"); }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Please fill all the fields");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("This bsn already exist");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (lbxViewEmployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
                if (lbxViewEmployees.SelectedItem.ToString() == emp.ToString())
                {
                    if (emp.Id == 2 || emp.Id == 3 || emp.Id == 4 || emp.Id == 6 || emp.Id == 8 || emp.Id == 28)
                    {
                        MessageBox.Show("You can not delete this user");
                    }else if (manageEmployees.DeleteEmployeeFromDb(emp.Id))
                    {
                        MessageBox.Show("The employee is deleted");
                        UpdateListBoxViewEmployees();
                        UpdateListBoxEmployee();

                    }
                    else
                    {
                        MessageBox.Show("The employee is not deleted.");
                        UpdateListBoxViewEmployees();
                        UpdateListBoxEmployee();
                    }
                    return;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                if (emp.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    lbxViewEmployees.Items.Add(emp.ToString());
                    lbxViewEmployees.Items.Add("");
                }
            }
            
        }
    }
}
