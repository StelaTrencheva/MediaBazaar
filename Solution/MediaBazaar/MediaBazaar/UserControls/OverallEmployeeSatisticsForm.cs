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

            }
            else if (typeOfStats == "Total hours worked")
            {

            }
            else if (typeOfStats == "Average hours worked")
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
                chartStatistics.Series["Total salary"].Points.AddXY("Jan", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Feb", "2");
                chartStatistics.Series["Total salary"].Points.AddXY("Mar", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Apr", "2");
                chartStatistics.Series["Total salary"].Points.AddXY("May", "2");
                chartStatistics.Series["Total salary"].Points.AddXY("Jun", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Jul", "2");
                chartStatistics.Series["Total salary"].Points.AddXY("Aug", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Sep", "2");
                chartStatistics.Series["Total salary"].Points.AddXY("Oct", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Nov", "2");
                chartStatistics.Series["Total salary"].Points.AddXY("Dec", "1");
            }
            else if (rbtnMonth.Checked)
            {
                chartStatistics.Series["Total salary"].Points.AddXY("1", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("2", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("3", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("4", "1");
            }
            else if (rbtnWeek.Checked)
            {
                chartStatistics.Series["Total salary"].Points.AddXY("Mon", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Tue", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Wed", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Thu", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Fri", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Sat", "1");
                chartStatistics.Series["Total salary"].Points.AddXY("Sun", "1");
            }
            //AddXY value in chartStatistics in series named as "Total salary"


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
