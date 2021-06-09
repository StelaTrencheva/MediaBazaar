using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.UserControls
{
    public partial class HolidayRequestsUC : UserControl
    {
        HolidayManager hm;
        public HolidayRequestsUC()
        {
            InitializeComponent();
            hm = new HolidayManager();
            updateRequestedHolidays();
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;

        }
        private void updateRequestedHolidays()
        {
            lbRequestedHolidays.Items.Clear();
            foreach (Holiday requestedHoliday in hm.GetRequestedHolidays())
            {
               lbRequestedHolidays.Items.Add(requestedHoliday);
            }
        }

        private void rbSortByRequestedTime_CheckedChanged(object sender, EventArgs e)
        {
            lbRequestedHolidays.Items.Clear();
            if (rbSortByRequestedTime.Checked == true)
            {
                foreach (Holiday requestedHoliday in hm.GetRequestedHolidaysByRequestedTime())
                {
                    lbRequestedHolidays.Items.Add(requestedHoliday);
                }
            }
            else
            {
                updateRequestedHolidays();
            }
        }

        private void rbSortByEmployee_CheckedChanged(object sender, EventArgs e)
        {
            lbRequestedHolidays.Items.Clear();
            if (rbSortByEmployee.Checked == true)
            {
                foreach (Holiday requestedHoliday in hm.GetRequestedHolidaysByEmployee())
                {
                    lbRequestedHolidays.Items.Add(requestedHoliday);
                }
            }
            else
            {
                updateRequestedHolidays();
            }
        }

        private void lbRequestedHolidays_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                if (lbRequestedHolidays.SelectedItem == null)
            {
                throw new ArgumentException();
            }
                btnDenyHolidayRequest.Visible = true;
                Holiday foundHoliday = hm.GetRequestedHolidayById(Convert.ToInt32(lbRequestedHolidays.SelectedItem.ToString().Substring(0, lbRequestedHolidays.SelectedItem.ToString().IndexOf('.'))));
                ClearFields();
                tbEmployeeBSN.Text = foundHoliday.EmployeeBsn;
                dtpEndDate.Value = foundHoliday.EndDate;
                dtpStartDate.Value = foundHoliday.StartDate;
            }
            catch(NotExistingHolidayException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDenyHolidayRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbRequestedHolidays.SelectedItem == null)
                {
                    throw new ArgumentException();
                }
                hm.DenyRequestedHoliday(Convert.ToInt32(lbRequestedHolidays.SelectedItem.ToString().Substring(0, lbRequestedHolidays.SelectedItem.ToString().IndexOf('.'))));
                updateRequestedHolidays();
                ClearFields();
            }
            catch (NotExistingHolidayException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            tbEmployeeBSN.Text = "";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }
        private void btnRegisterNewHoliday_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeBSN = tbEmployeeBSN.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                DateTime requestedTime = DateTime.Now;
                Holiday newHoliday = new Holiday(1,employeeBSN,startDate,endDate,requestedTime);
                hm.RegisterNewHoliday(newHoliday);
                MessageBox.Show($"The new holiday for employee with BSN: {employeeBSN} was registered!");
                updateRequestedHolidays();
                ClearFields();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExistingHolidayException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
            
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
