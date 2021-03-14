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
    public partial class EmployeeStatisticsForm : Form
    {
        Employee employee;
        public EmployeeStatisticsForm()
        {
            InitializeComponent();
        }

        public void SetEmployeeInfo(Employee emp)
        {
            this.employee = emp;
        }

        private void EmployeeStatisticsForm_Load(object sender, EventArgs e)
        {
            tbxGeneralInformation.Text = employee.GetInfo;
            tbxTotalSalary.Text = employee.GetTotalSalaryPerTimeUnit;
        }
    }
}
