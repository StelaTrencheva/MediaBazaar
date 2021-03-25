using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class StoreWorkerScheduleInterface : UserControl
    {

        private DateTime today = DateTime.Today;
        private Schedule schedule;
        private Shift foundShift;
        private void CreateFutureMonths()
        {
          
            for (int i = 0; i < 4; i++)
            {
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(today.Month + i);
                cbMonth.Items.Add(month);
                schedule = new Schedule();
            }


        }
        private void UpdateInfo()
        {
            lbxDisplayAssignedEmployees.Items.Clear();
            lbxDisplayAvailableStoreW.Items.Clear();
            string selectedShiftValue = cbxShiftType.SelectedItem.ToString();
            Enum.TryParse(selectedShiftValue, out ShiftType shiftType);
            DateTime selectedDate = DateTime.Parse(cbxDay.SelectedItem.ToString());
            string date = selectedDate.ToString("yyyy-MM-dd");

            foundShift = schedule.GetShift(shiftType, date);
            try
            {
                foreach (Employee employee in foundShift.GetAssignedEmployees())
                {

                    lbxDisplayAssignedEmployees.Items.Add(employee.BSN);
                }
                Dictionary<int, int> assignedHours = schedule.GetEmployeesAssignedHours(foundShift.GetAvailableEmployeesIds(), date);
                
                for (int i = 0; i < foundShift.GetAvailableEmployees().Count; i++)
                {
                    assignedHours.TryGetValue(foundShift.GetAvailableEmployees()[i].Id,out int hours);
                    lbxDisplayAvailableStoreW.Items.Add(foundShift.GetAvailableEmployees()[i].BSN + " - " + foundShift.GetAvailableEmployees()[i].Contract + " - " + hours + "h assigned for the week.");
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Database problem detected - " + exc.Message);
            }
        }
        public StoreWorkerScheduleInterface()
        {
            InitializeComponent();
            lbTodayDate.Text = today.ToShortDateString();
            CreateFutureMonths();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = DateTime.ParseExact(cbMonth.SelectedItem.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;
            lblDay.Visible = true;
            cbxDay.Visible = true;
            cbxDay.Items.Clear();
            cbxShiftType.Visible = false;
            lblShiftType.Visible = false;
            DateTime lst = today.AddMonths(3);
            for (DateTime day = today.Date; day <= lst; day = day.AddDays(1))
            {
                if (day.Month == month)
                {
                    cbxDay.Items.Add(day.ToShortDateString()+" - "+day.DayOfWeek);
                }

            }
        }

        private void cbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxDisplayAssignedEmployees.Visible = false;
            lbxDisplayAvailableStoreW.Visible = false;
            lblAvailableStoreW.Visible = false;
            lblAssignStoreW.Visible = false;
            lblShiftType.Visible = true;
            cbxShiftType.Visible = true;
            cbxShiftType.SelectedIndex = -1;

        }

        private void cbxShiftType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxShiftType.SelectedIndex != -1)
            {
                lblAssignStoreW.Visible = true;
            lblAvailableStoreW.Visible = true;
            lbxDisplayAvailableStoreW.Visible = true;
            lbxDisplayAssignedEmployees.Visible = true;
            btnRemove.Visible = true;
            btnAssign.Visible = true;

            UpdateInfo();

            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedUser;
            try
            {
                if (lbxDisplayAssignedEmployees.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a store worker from the assigned store workers");
                }
                else
                {
                    selectedUser = lbxDisplayAssignedEmployees.SelectedItem.ToString(); 
                    MessageBox.Show("Employee with BSN: " + schedule.RemoveEmployeeFromShift(foundShift, selectedUser).BSN + " was removed from this shift.");
                UpdateInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

            string selectedUser;
            try
            {
                if (lbxDisplayAvailableStoreW.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a store worker from the available store workers");
                }
                else
                {
                    selectedUser = lbxDisplayAvailableStoreW.SelectedItem.ToString();
                    selectedUser = selectedUser.Substring(0, selectedUser.IndexOf(" - "));
                    MessageBox.Show("Employee with BSN: " + schedule.AssignEmployeeToShift(foundShift, selectedUser).BSN + " was assigned to this shift.");
                    UpdateInfo();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
      
        private int GetWeekNumber(DateTime date)
        {
           return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        private void btnShowShifts_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = calendarDate.SelectionRange.Start;
           
            lbViewSchedule.Visible = true;
            lbViewSchedule.Items.Clear();
            btnChangeSelectedWeek.Visible = true;
            int weekNumberOfSelectedDate = GetWeekNumber(selectedDate);
            DateTime startDate=selectedDate;
            DateTime endDate = startDate.AddDays(7);
            List<DateTime> dates = new List<DateTime>();
            for (DateTime i = startDate; i > selectedDate.AddDays(-7); i=i.AddDays(-1))
            {
                if (GetWeekNumber(i.AddDays(-1)) != weekNumberOfSelectedDate)
                {
                    startDate = i;
                    endDate = startDate.AddDays(7);
                    break;
                }
            }
            for (DateTime i = startDate; i <endDate; i=i.AddDays(1))
            {
                dates.Add(i);
            }
            Shift shift;
            foreach (DateTime d in dates)
            {
                string date = d.ToString("yyyy-MM-dd");
                lbViewSchedule.Items.Add(d.ToShortDateString()+" - "+d.DayOfWeek);
                foreach (ShiftType s in (ShiftType[])Enum.GetValues(typeof(ShiftType)))
                {
                    lbViewSchedule.Items.Add("\t" + s.ToString());
                    shift = schedule.GetShift(s,date);
                    foreach (Employee employee in shift.GetAssignedEmployees())
                    {
                        lbViewSchedule.Items.Add("\t\t" + employee.BSN+" - "+employee.GetEmployeeNames);
                    }
                }
            }
            
            
        }

        private void btnChangeSelectedWeek_Click(object sender, EventArgs e)
        {
            lbViewSchedule.Visible = false;
        }

        private void tcStoreWorkerSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            calendarDate.MinDate = today.AddMonths(-3);
            calendarDate.MaxDate = today.AddMonths(3);
        }
    }
}
