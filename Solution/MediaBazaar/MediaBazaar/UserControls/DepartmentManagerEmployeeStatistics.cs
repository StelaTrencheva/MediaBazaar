using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectClasses;


namespace MediaBazaar
{
    public partial class DepartmentManagerEmployeeStatistics : UserControl
    {
        Employee employee;
        EmpStatisticManager empStatistics;
        string TypeOfStats = "Total salary";
        string periodOverviewStats = "year";
        DateTime dateOverviewStats = DateTime.Now;
        DateTime dateIndividualStats = DateTime.Now;
        string deptCode;
        string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] day = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public DepartmentManagerEmployeeStatistics()
        {
            InitializeComponent();
            empStatistics = new EmpStatisticManager();
        }

        public void SetDepartmentCode(string departmentCode)
        {
            this.deptCode = departmentCode;
        }

        public void ShowDepartmentStatistics()
        {
            List<double> EmpStats = empStatistics.ShowDepartmentOverallStatistics(TypeOfStats, periodOverviewStats, dateOverviewStats, deptCode);
            if (!String.IsNullOrEmpty(lblChartTitle.Text))
            {
                lblChartTitle.Text += " x " + TypeOfStats;
            }
            else
            {
                lblChartTitle.Text = TypeOfStats;
            }

            if (periodOverviewStats == "year")
            {
                for (int i = 0; i < 12; i++)
                {
                    chartDepStatistics.Series[TypeOfStats].Points.AddXY(month[i], EmpStats[i]);
                }
            }
            else if (periodOverviewStats == "month")
            {
                int daysInMonth = System.DateTime.DaysInMonth(dateOverviewStats.Year, dateOverviewStats.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    chartDepStatistics.Series[TypeOfStats].Points.AddXY(i + 1, EmpStats[i]);
                }
            }
            else if (periodOverviewStats == "week")
            {
                for (int i = 0; i < 7; i++)
                {
                    chartDepStatistics.Series[TypeOfStats].Points.AddXY(day[i], EmpStats[i]);
                }
            }
        }

        public void ClearEmpStatsChart()
        {
            lblChartTitle.Text = String.Empty;

            chartDepStatistics.Series["Total salary"].Points.Clear();
            chartDepStatistics.Series["Average salary"].Points.Clear();
            chartDepStatistics.Series["Total hours worked"].Points.Clear();
            chartDepStatistics.Series["Average hours worked"].Points.Clear();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "year";
            ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "month";
            ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void rbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "week";
            ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void cbbAllKindsOfStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfStats = cbbAllKindsOfStatistics.SelectedItem.ToString();
        }

        private void dtDateStatistic_ValueChanged(object sender, EventArgs e)
        {
            dateOverviewStats = dtDateStatistic.Value;
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            ShowDepartmentStatistics();
        }

        private void btnRemoveStats_Click(object sender, EventArgs e)
        {
            this.ClearEmpStatsChart();
        }
    }
}
