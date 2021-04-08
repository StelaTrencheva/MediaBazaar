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
    public partial class OverallEmployeeSatisticsForm : Form
    {
        SystemManagerEmployeeStatistics empStatisticsManager;
        string typeOfStats = "Total salary";
        DateTime date = DateTime.Now;
        string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] day = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public OverallEmployeeSatisticsForm()
        {
            InitializeComponent();
            empStatisticsManager = new SystemManagerEmployeeStatistics();
        }
        public void SetTypeOfStatistics(string stats, DateTime Date)
        {
            this.typeOfStats = stats;
            this.date = Date;
        }

        private void OverallEmployeeSatisticsForm_Load(object sender, EventArgs e)
        {
            ShowOverallStatistics();
        }

        public void ShowOverallStatistics()
        {
            if (typeOfStats == "Total salary")
            {
                ShowOverallStatisticsForTotalSalary();
            }
            else if (typeOfStats == "Average salary")
            {
                ShowOverallStatisticsForAvgSalary();
            }
            else if (typeOfStats == "Total hours worked")
            {
                ShowOverallStatisticsForTotalHoursWorked();
            }
            else if (typeOfStats == "Average hours worked")
            {
                ShowOverallStatisticsForAverageHoursWorked();
            }
        }

        public void ShowOverallStatisticsForTotalSalary()
        {
            List<double> TotalSalaryPerYear = empStatisticsManager.GetTotalSalaryPerTimeUnit("year", date);
            List<double> TotalSalaryPerMonth = empStatisticsManager.GetTotalSalaryPerTimeUnit("month", date);

            chartStatistics.Series["Total salary"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Total salary");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Total salary"].Points.AddXY(month[i], TotalSalaryPerYear[i]);
                }
            }
            else if (rbtnMonth.Checked)
            {
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                for (int i = 1; i <= daysInMonth; i++)
                {
                    chartStatistics.Series["Total salary"].Points.AddXY(i+1, TotalSalaryPerMonth[i]);
                }
            }
        }
        public void ShowOverallStatisticsForAvgSalary()
        {
            List<double> AvgSalaryPerYear = empStatisticsManager.GetAvgSalaryPerTimeUnit("year", date);
            List<double> AvgSalaryPerMonth = empStatisticsManager.GetAvgSalaryPerTimeUnit("month", date);

            chartStatistics.Series["Average salary"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Average salary");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Average salary"].Points.AddXY(month[i], AvgSalaryPerYear[i]);
                }
            }
            else if (rbtnMonth.Checked)
            {
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                for (int i = 1; i <= daysInMonth; i++)
                {
                    chartStatistics.Series["Average salary"].Points.AddXY(i+1, AvgSalaryPerMonth[i]);
                }
            }
        }
        public void ShowOverallStatisticsForTotalHoursWorked()
        {
            List<double> TotalHoursWorkedPerYear = empStatisticsManager.GetTotalHoursWorkedPerTimeUnit("year", date);
            List<double> TotalHoursWorkedPerMonth = empStatisticsManager.GetTotalHoursWorkedPerTimeUnit("month", date);

            chartStatistics.Series["Total hours worked"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Total hours worked");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Total hours worked"].Points.AddXY(month[i], TotalHoursWorkedPerYear[i]);
                }
            }
            else if (rbtnMonth.Checked)
            {
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    chartStatistics.Series["Total hours worked"].Points.AddXY(i+1, TotalHoursWorkedPerMonth[i]);
                }
            }
        }
        public void ShowOverallStatisticsForAverageHoursWorked()
        {
            List<double> AvgHoursWorkedPerYear = empStatisticsManager.GetAvgHoursWorkedPerTimeUnit("year", date);
            List<double> AvgHoursWorkedPerMonth = empStatisticsManager.GetAvgHoursWorkedPerTimeUnit("month", date);

            chartStatistics.Series["Average hours worked"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Average hours worked");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Average hours worked"].Points.AddXY(month[i], AvgHoursWorkedPerYear[i]);
                }
            }
            else if (rbtnMonth.Checked)
            {
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    chartStatistics.Series["Average hours worked"].Points.AddXY(i+1, AvgHoursWorkedPerMonth[i]);
                }
            }
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
    }
}
