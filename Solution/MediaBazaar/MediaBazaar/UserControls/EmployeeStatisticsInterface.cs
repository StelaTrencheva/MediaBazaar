using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar
{

    public partial class EmployeeStatistics : UserControl
    {
        EmployeeManager mngEmp;
        SystemManagerEmployeeStatistics empStatistics;
        List<int> EmployeeID;
        string[] TypeOfStats = new string[4] { "Total salary", "Average salary", "Total hours worked", "Average hours worked" };
        public EmployeeStatistics()
        {
            InitializeComponent();
            mngEmp = new EmployeeManager();
            empStatistics = new SystemManagerEmployeeStatistics();

        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            EmployeeID = new List<int>();
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                EmployeeID.Add(emp.Id);
                lbxEmployees.Items.Add(emp.GetEmployeeNames);
            }
            foreach (string stat in TypeOfStats)
            {
                lbxAllKindsOfStatistics.Items.Add(stat);
            }
        }
        private void tbpAllEmployees_Click(object sender, EventArgs e)
        {

        }

        private void txbEmployees_TextChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            string empName = txbEmployees.Text.ToString().ToLower();
            if (String.IsNullOrEmpty(empName))
            {
                foreach (Employee emp in mngEmp.GetListOFAllEmployees())
                { lbxEmployees.Items.Add(emp.GetEmployeeNames); }
            }
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                if (emp.GetEmployeeNames.ToLower().Contains(empName))
                {
                    lbxEmployees.Items.Add(emp.GetEmployeeNames);
                }

            }
        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {

            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                if (emp.GetEmployeeNames == lbxEmployees.SelectedItem.ToString())
                {
                    empStatistics.ShowIndividualEmpStats(emp, dtpTimePeriod.Value);
                }
            }
        }

        private void btnShowOverallStats_Click(object sender, EventArgs e)
        {
            empStatistics.ShowOverviewEmpStats(lbxAllKindsOfStatistics.SelectedItem.ToString(), dtDateStatistic.Value);
        }
    }
}
