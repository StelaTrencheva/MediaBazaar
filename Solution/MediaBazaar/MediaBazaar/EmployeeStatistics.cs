using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class EmployeeStatistics : UserControl
    {
        EmployeeStatisticsForm empStats;
        ManageEmployees mngEmp;
        public EmployeeStatistics()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees();
            empStats = new EmployeeStatisticsForm();
        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            foreach(Employee emp in mngEmp.GetEmployees())
            {
                lbxListOfEmployees.Items.Add(emp.GetInfo);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            int index = lbxListOfEmployees.SelectedIndex;
            foreach(Employee emp in mngEmp.GetEmployees())
            {
                if(emp.Id == index+1)
                {
                   empStats.SetEmployeeInfo(emp);
                   empStats.Show();
                }
            }
            
        }
    }
}
