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
        DatabaseMediator dbMediator;
        ManageEmployees mngEmp;
        string typeOfStats = "Total salary";
        DateTime date = DateTime.Now;
        string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] day = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public OverallEmployeeSatisticsForm()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees();
            dbMediator = new DatabaseMediator();
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
            chartStatistics.Series["Total salary"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Total salary");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Total salary"].Points.AddXY(month[i], i);
                }
            }
            else if (rbtnMonth.Checked)
            {
                for (int i = 1; i < 5; i++)
                {
                    chartStatistics.Series["Total salary"].Points.AddXY(i, i + 10);
                }
            }
            else if (rbtnWeek.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    chartStatistics.Series["Total salary"].Points.AddXY(day[i], i);
                }
            }
        }
        public void ShowOverallStatisticsForAvgSalary()
        {
            chartStatistics.Series["Average salary"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Average salary");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Average salary"].Points.AddXY(month[i], i);
                }
            }
            else if (rbtnMonth.Checked)
            {
                for (int i = 1; i < 5; i++)
                {
                    chartStatistics.Series["Average salary"].Points.AddXY(i, i );
                }
            }
            else if (rbtnWeek.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    chartStatistics.Series["Average salary"].Points.AddXY(day[i], i);
                }
            }
        }
        public void ShowOverallStatisticsForTotalHoursWorked()
        {
            chartStatistics.Series["Total hours worked"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Total hours worked");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Total hours worked"].Points.AddXY(month[i], i);
                }
            }
            else if (rbtnMonth.Checked)
            {
                for (int i = 1; i < 5; i++)
                {
                    chartStatistics.Series["Total hours worked"].Points.AddXY(i, i+10);
                }
            }
            else if (rbtnWeek.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    chartStatistics.Series["Total hours worked"].Points.AddXY(day[i], i);
                }
            }
        }
        public void ShowOverallStatisticsForAverageHoursWorked()
        {
            chartStatistics.Series["Average hours worked"].Points.Clear();
            chartStatistics.Titles.Clear();
            chartStatistics.Titles.Add("Average hours worked");
            if (rbtnYear.Checked)
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series["Average hours worked"].Points.AddXY(month[i], i+3);
                }
            }
            else if (rbtnMonth.Checked)
            {
                for (int i = 1; i < 5; i++)
                {
                    chartStatistics.Series["Average hours worked"].Points.AddXY(i, i + 20);
                }
            }
            else if (rbtnWeek.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    chartStatistics.Series["Average hours worked"].Points.AddXY(day[i], i+2);
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
