using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar
{

    public partial class EmployeeStatistics : UserControl
    {
        DatabaseMediator dbMediator;
        ManageEmployees mngEmp;
        EmployeeStatistcsForm empStats;
        List<int> EmployeeID;
        public EmployeeStatistics()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees();
            dbMediator = new DatabaseMediator();
            
        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            EmployeeID = new List<int>();
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                EmployeeID.Add(emp.Id);
                lbxEmployees.Items.Add(emp.GetEmployeeNames);
            }
            ShowOverallStatistics();
        }

        private void dtDateStatistic_ValueChanged(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }
        public void ShowOverallStatistics()
        {
            if(cbbShowStats.SelectedIndex == -1 || cbbShowStats.SelectedIndex == 0)  //"Total salary"
            {
                ShowOverallStatisticsForTotalSalary();
            }
            else if (cbbShowStats.SelectedIndex == 1) //"Average salary"
            {

            }
            else if (cbbShowStats.SelectedIndex == 2) //"Total hours worked"
            {

            }
            else if (cbbShowStats.SelectedIndex == 3)  //"Average hours worked"
            {

            }
        }
        public void ShowOverallStatisticsForTotalSalary()
        {
            chartStatistics.Series["Total salary"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Total salary");
            if (rbtnYear.Checked)
            {
            chartStatistics.Series["Total salary"].Points.AddXY("J", "1");
            chartStatistics.Series["Total salary"].Points.AddXY("F", "2");
            chartStatistics.Series["Total salary"].Points.AddXY("M", "1");
            chartStatistics.Series["Total salary"].Points.AddXY("A", "2");
            chartStatistics.Series["Total salary"].Points.AddXY("M", "2");
            chartStatistics.Series["Total salary"].Points.AddXY("J", "1");
            chartStatistics.Series["Total salary"].Points.AddXY("J", "2");
            chartStatistics.Series["Total salary"].Points.AddXY("A", "1");
            chartStatistics.Series["Total salary"].Points.AddXY("S", "2");
            chartStatistics.Series["Total salary"].Points.AddXY("O", "1");
            chartStatistics.Series["Total salary"].Points.AddXY("N", "2");
            chartStatistics.Series["Total salary"].Points.AddXY("D", "1");
            }
            else if(rbtnMonth.Checked)
            {
                chartStatistics.Series["Total salary"].Points.AddXY("1", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("2", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("3", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("4", "1");
            }
            else if(rbtnWeek.Checked)
            {
                chartStatistics.Series["Total salary"].Points.AddXY("1", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("2", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("3", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("4", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("5", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("6", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("7", "1");
            }
            //AddXY value in chartStatistics in series named as "Total salary"
            
            
        }

        private void tbpAllEmployees_Click(object sender, EventArgs e)
        {

        }

        private void txbEmployees_TextChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            string empName = txbEmployees.Text.ToString();
            if (String.IsNullOrEmpty(empName))
            {
                foreach (Employee emp in mngEmp.GetListOFAllEmployees())
                { lbxEmployees.Items.Add(emp.GetEmployeeNames); }
            }
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                if (emp.GetEmployeeNames.Contains(empName))
                {
                    lbxEmployees.Items.Add(emp.GetEmployeeNames);
                }

            }
        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                if(emp.GetEmployeeNames == lbxEmployees.SelectedItem.ToString())
                {
                    empStats = new EmployeeStatistcsForm();
                    empStats.SetEmployee(emp, dtpTimePeriod.Value);
                    empStats.ShowDialog();
                }
            }
        }

        private void cbbShowStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }

        private void rbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }

        private void chbOrderBy_CheckedChanged(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }
    }
}
