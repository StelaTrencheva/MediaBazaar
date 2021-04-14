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
        string TypeOfStats = "Total salary";
        string period = "year";
        DateTime date = DateTime.Now;
        string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] day = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
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

        //chart 
        public void ShowOverallStatisticsForTotalSalary()
        {
            List<double> EmpStats = empStatistics.ShowOverallStatistics(TypeOfStats, period, date);
            if (!String.IsNullOrEmpty(lblChartTitle.Text))
            {
                lblChartTitle.Text += " x " + TypeOfStats;
            }
            else
            {
                lblChartTitle.Text = TypeOfStats;
            }

            if (period == "year")
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series[TypeOfStats].Points.AddXY(month[i], EmpStats[i]);
                }
            }
            else if (period == "month")
            {
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    chartStatistics.Series[TypeOfStats].Points.AddXY(i + 1, EmpStats[i]);
                }
            }
        }
        public void ClearEmpStatsChart()
        {

            lblChartTitle.Text = String.Empty;

            chartStatistics.Series["Total salary"].Points.Clear();
            chartStatistics.Series["Average salary"].Points.Clear();
            chartStatistics.Series["Total hours worked"].Points.Clear();
            chartStatistics.Series["Average hours worked"].Points.Clear();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            period = "year";
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            period = "month";
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void rbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            period = "week";
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void cbbAllKindsOfStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfStats = cbbAllKindsOfStatistics.SelectedItem.ToString();
        }

        private void dtDateStatistic_ValueChanged(object sender, EventArgs e)
        {
            date = dtDateStatistic.Value;
            ClearEmpStatsChart();
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            ShowOverallStatisticsForTotalSalary();
        }

        private void btnRemoveStats_Click(object sender, EventArgs e)
        {
            ClearEmpStatsChart();
        }
    }
}
