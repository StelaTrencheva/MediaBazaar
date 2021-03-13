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
    public partial class ChangeEmployeeWorkingContract : Form
    {
        Employee employee;
        DatabaseMediator dbMediator;
        public ChangeEmployeeWorkingContract()
        {
            InitializeComponent();
            dbMediator = new DatabaseMediator();
        }

        public void SetEmployee(Employee emp)
        {
            this.employee = emp;
        }

        private void ChangeEmployeeWorkingContract_Load(object sender, EventArgs e)
        {
            tbxCurrentContract.Text = employee.Contract.ToString();
            txbEmployeeInfo.Text = employee.EmployeeFullInfo;
        }

        private void btnChangeContract_Click(object sender, EventArgs e)
        {
            int index = cbbChangeCOntract.SelectedIndex +1 ;
            if(employee.Contract == (ContractType)(index))
            {
                MessageBox.Show($"{employee.GetEmployeeNames}is already assigned to this contract. \r\n" +
                    $" If you want to change {employee.GetEmployeeNames}'s contract please choose another option.");
            }
            else
            {
                employee.Contract = (ContractType)(index);
                bool success = dbMediator.ChangeWorkContract((ContractType)(index), employee.Id);
                if(success)
                {
                    MessageBox.Show("Success");
                }
            }

        }
    }
}
