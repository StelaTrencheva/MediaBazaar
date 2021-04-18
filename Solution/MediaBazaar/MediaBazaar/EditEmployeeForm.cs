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
    public partial class EditEmployeeForm : Form
    {
        Employee currentEmp;
        EmployeeManager employeeManager;
        public EditEmployeeForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            employeeManager = new EmployeeManager();
            UpdateInfo();
            tbDisable();
        }
        private void UpdateInfo()
        {
            tboxBSN.Text = currentEmp.BSN;
            tboxFName.Text = currentEmp.FirstName;
            tboxLName.Text = currentEmp.LastName;
            cbxGender.SelectedIndex = Convert.ToInt32(currentEmp.Gender);
            tboxEmail.Text = currentEmp.Email;
            dtpDateOfBirth.Value = Convert.ToDateTime(currentEmp.Birthday);
            tboxPhoneNumber.Text = currentEmp.PhoneNumber;
            tboxIban.Text = currentEmp.Iban;
            tboxStreet.Text = currentEmp.Street;
            tboxStreetNumber.Text = currentEmp.StreetNumber;
            tboxZipcode.Text = currentEmp.Zipcode;
            tboxTown.Text = currentEmp.Town;
            tboxCountry.Text = currentEmp.Country;
            tboxUsername.Text = currentEmp.Username;
            dtpDateFWD.Value = Convert.ToDateTime(currentEmp.FirstWorkingDay);
            tboxHourlyWage.Text = currentEmp.HourlyWage.ToString();
            cbxContractType.SelectedIndex = Convert.ToInt32(currentEmp.Contract);
            cbxTypeOfEmployee.SelectedIndex = Convert.ToInt32(currentEmp.Position);
        }

        private void rbtnPersonalInfo_CheckedChanged(object sender, EventArgs e)
        {
            tbEnablePersonalInfo();
        }

        private void rbtnAddress_CheckedChanged(object sender, EventArgs e)
        {
            tbEnableAddress();
        }

        private void rbtnWorkInfo_CheckedChanged(object sender, EventArgs e)
        {
            tbEnableWorkInfo();
        }
        private void tbEnablePersonalInfo()
        {
            tbDisable();
            tboxBSN.Enabled = true;
            tboxFName.Enabled = true;
            tboxLName.Enabled = true;
            cbxGender.Enabled = true;
            tboxEmail.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            tboxPhoneNumber.Enabled = true;
            tboxIban.Enabled = true;
        }
        private void tbEnableAddress()
        {
            tbDisable();
            tboxStreet.Enabled = true;
            tboxStreetNumber.Enabled = true;
            tboxZipcode.Enabled = true;
            tboxTown.Enabled = true;
            tboxCountry.Enabled = true;
        }
        private void tbEnableWorkInfo()
        {
            tbDisable();
            tboxUsername.Enabled = true;
            dtpDateFWD.Enabled = true;
            tboxHourlyWage.Enabled = true;
            cbxContractType.Enabled = true;
            cbxTypeOfEmployee.Enabled = true;
        }
        private void tbDisable()
        {
            UpdateInfo();
            tboxBSN.Enabled = false;
            tboxFName.Enabled = false;
            tboxLName.Enabled = false;
            cbxGender.Enabled = false;
            tboxEmail.Enabled = false;
            dtpDateOfBirth.Enabled = false;
            tboxPhoneNumber.Enabled = false;
            tboxIban.Enabled = false;
            tboxStreet.Enabled = false;
            tboxStreetNumber.Enabled = false;
            tboxZipcode.Enabled = false;
            tboxTown.Enabled = false;
            tboxCountry.Enabled = false;
            tboxUsername.Enabled = false;
            dtpDateFWD.Enabled = false;
            tboxHourlyWage.Enabled = false;
            cbxContractType.Enabled = false;
            cbxTypeOfEmployee.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                if (rbtnPersonalInfo.Checked == true)
                {
                    if (employeeManager.EditPersonalInfoDB(currentEmp.Id, tboxBSN.Text, tboxFName.Text, tboxLName.Text, (Gender)cbxGender.SelectedIndex,
                                                      tboxEmail.Text, dtpDateOfBirth.Value, tboxPhoneNumber.Text, tboxIban.Text))
                    {
                        MessageBox.Show("Success");
                        //currentEmp.BSN = tboxBSN.Text;
                        //currentEmp.FirstName = tboxFName.Text;
                    }
                    else
                    {
                        MessageBox.Show("The user is not edited, double check your input information");
                    }
                }
                else if (rbtnAddress.Checked == true)
                {
                    if (employeeManager.EditAddressInfoInfoDB(currentEmp.Id, tboxStreet.Text, tboxStreetNumber.Text, tboxZipcode.Text, tboxTown.Text, tboxCountry.Text))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("The user is not edited, double check your input information");
                    }
                }
                else if (rbtnWorkInfo.Checked == true)
                {
                    if (employeeManager.EditWorkInfoDB(currentEmp.Id, tboxUsername.Text, dtpDateFWD.Value, Convert.ToDouble(tboxHourlyWage.Text),
                                                  (ContractType)cbxContractType.SelectedIndex, (EmployeeType)cbxTypeOfEmployee.SelectedIndex))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("The user is not edited, double check your input information");
                    }
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
        }
    }
}
