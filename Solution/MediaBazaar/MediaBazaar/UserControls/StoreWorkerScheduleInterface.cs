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
using MediaBazaar.UserControls;

namespace MediaBazaar
{
    public partial class StoreWorkerScheduleInterface : UserControl
    {
        private DateTime today = DateTime.Today;
        private ShiftManager shiftManager;
        private Shift foundShift;
        private ListBox lbx = null;
        private Label lbl = null;
        private void CreateFutureMonths()
        {
            for (int i = 0; i < 4; i++)
            {
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(today.Month + i);
                cbMonth.Items.Add(month);
                shiftManager = new ShiftManager();

            }
        }
        public StoreWorkerScheduleInterface()
        {
            InitializeComponent();
            lbTodayDate.Text = today.ToShortDateString();
            CreateFutureMonths();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbOverview.Visible = false;
            gbAvailableEmployees.Visible = false;
            gbChangeAssignableEmployees.Visible = false;
            int month = DateTime.ParseExact(cbMonth.SelectedItem.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;
            lblDay.Visible = true;
            cbxDay.Visible = true;
            gbOverview.Visible = false;
            gbAvailableEmployees.Visible = false;
            gbChangeAssignableEmployees.Visible = false;
            cbxDay.Items.Clear();
            DateTime lst = today.AddMonths(3);
            for (DateTime day = today.Date; day <= lst; day = day.AddDays(1))
            {
                if (day.Month == month)
                {
                    cbxDay.Items.Add(day.ToShortDateString());
                }

            }
        }
        private void ClearAllListBoxes()
        {
            lbxAssignedEmployeesMorning.Items.Clear();
            lbxAssignedEmployeesAfternoon.Items.Clear();
            lbxAssignedEmployeesEvening.Items.Clear();
            lbxAssignedEmployeesNight.Items.Clear();
            lbxAvailableStoreWorkers.Items.Clear();
            tbMaxEmployees.Clear();
        }

        private void cbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbMorningShift.Checked = false;
            rbAfternoonShift.Checked = false;
            rbEveningShift.Checked = false;
            rbNightShift.Checked = false;
            gbOverview.Visible = true;
            gbAvailableEmployees.Visible = true;
            gbChangeAssignableEmployees.Visible = true;
            ClearAllListBoxes();
            DateTime selectedDate = DateTime.Parse(cbxDay.SelectedItem.ToString());
            string date = selectedDate.ToString("yyyy-MM-dd");

            foreach (Shift shift in shiftManager.GetAllShiftsPerDate(date))
            {
                if (shift.Type == ShiftType.Morning)
                {
                    UpdateShifts(lbxAssignedEmployeesMorning, shift, lbLeftEmployeesMorning);
                }
                else if (shift.Type == ShiftType.Afternoon)
                {

                    UpdateShifts(lbxAssignedEmployeesAfternoon, shift, lbLeftEmployeesAfternoon);
                }
                else if (shift.Type == ShiftType.Evening)
                {
                    UpdateShifts(lbxAssignedEmployeesEvening, shift, lbLeftEmployeesEvening);
                }
                else if (shift.Type == ShiftType.Night)
                {
                    UpdateShifts(lbxAssignedEmployeesNight, shift, lbLeftEmployeesNight);
                }

            }
        }
        private void UpdateShifts(ListBox lbx, Shift foundShift, Label leftEmployees)
        {
            lbx.Items.Clear();
            leftEmployees.Text = shiftManager.GetAssignableEmployeesLeft(foundShift).ToString();
            foreach (Employee employee in foundShift.GetAssignedEmployees())
            {
                lbx.Items.Add($"{employee.Id}. {employee.FirstName} {employee.LastName} - {employee.Contract}");
            }
        }
        private void UpdateAvailableEmployees(Shift foundShift)
        {
            tbMaxEmployees.Text = foundShift.AssignableEmployees.ToString();
            lbxAvailableStoreWorkers.Items.Clear();
            Dictionary<Employee, int> availableEmployees = shiftManager.GetAvailableEmployees(foundShift, foundShift.Date.ToString("yyyy-MM-dd"));

            foreach (KeyValuePair<Employee, int> employee in availableEmployees)
            {
                lbxAvailableStoreWorkers.Items.Add($"{employee.Key.Id}. {employee.Key.FirstName} - {employee.Key.LastName} - {employee.Key.Contract} - {employee.Value}h assigned for the week.");
            }
        }

        private void rbMorningShift_CheckedChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Parse(cbxDay.SelectedItem.ToString());
            string date = selectedDate.ToString("yyyy-MM-dd");
            foundShift = shiftManager.GetShift(ShiftType.Morning, date);
            UpdateAvailableEmployees(foundShift);
        }

        private void rbAfternoonShift_CheckedChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Parse(cbxDay.SelectedItem.ToString());
            string date = selectedDate.ToString("yyyy-MM-dd");
            foundShift = shiftManager.GetShift(ShiftType.Afternoon, date);
            UpdateAvailableEmployees(foundShift);
        }

        private void rbEveningShift_CheckedChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Parse(cbxDay.SelectedItem.ToString());
            string date = selectedDate.ToString("yyyy-MM-dd");
            foundShift = shiftManager.GetShift(ShiftType.Evening, date);
            UpdateAvailableEmployees(foundShift);
        }

        private void rbNightShift_CheckedChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Parse(cbxDay.SelectedItem.ToString());
            string date = selectedDate.ToString("yyyy-MM-dd");
            foundShift = shiftManager.GetShift(ShiftType.Night, date);
            UpdateAvailableEmployees(foundShift);
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            RadioButton checkedButton = gbOverview.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);
            if (checkedButton == null)
            {
                MessageBox.Show("Please select a shift");
            }
            else
            {
                GetSelectedShift(checkedButton);
                try
                {
                    int newValue = Convert.ToInt32(tbMaxEmployees.Text);
                    if (shiftManager.ChangeMaxAssignableEmployeesValue(foundShift, newValue))
                    {
                        tbMaxEmployees.Text = foundShift.AssignableEmployees.ToString();
                        lbl.Text = shiftManager.GetAssignableEmployeesLeft(foundShift).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GetSelectedShift(RadioButton checkedButton)
        {

            switch (checkedButton.Name)
            {
                case "rbMorningShift":
                    lbx = lbxAssignedEmployeesMorning;
                    lbl = lbLeftEmployeesMorning;
                    break;
                case "rbAfternoonShift":
                    lbx = lbxAssignedEmployeesAfternoon;
                    lbl = lbLeftEmployeesAfternoon;
                    break;
                case "rbEveningShift":
                    lbx = lbxAssignedEmployeesEvening;
                    lbl = lbLeftEmployeesEvening;
                    break;
                case "rbNightShift":
                    lbx = lbxAssignedEmployeesNight;
                    lbl = lbLeftEmployeesNight;
                    break;
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedUser;
            RadioButton checkedButton = gbOverview.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
            if (checkedButton == null)
            {
                MessageBox.Show("Please select a shift");
            }
            else
            {
                GetSelectedShift(checkedButton);
                try
                {
                    if (lbx.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a store worker from the assigned store workers for the selected shift!");
                    }
                    else
                    {
                        selectedUser = Convert.ToInt32(lbx.SelectedItem.ToString().Substring(0, lbx.SelectedItem.ToString().IndexOf('.')));
                        if (shiftManager.RemoveEmployeeFromShift(foundShift, selectedUser))
                        {
                            MessageBox.Show("Employee was removed from this shift.");
                            UpdateAvailableEmployees(foundShift);
                            UpdateShifts(lbx, foundShift, lbl);
                        }
                        else
                        {
                            MessageBox.Show("System failed to remove the employee.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int selectedUser;
            RadioButton checkedButton = gbOverview.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
            if (checkedButton == null)
            {
                MessageBox.Show("Please select a shift");
            }
            else
            {
                GetSelectedShift(checkedButton);
                try
                {
                    if (lbxAvailableStoreWorkers.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a store worker from the available store workers for the selected shift!");
                    }
                    else
                    {
                        selectedUser = Convert.ToInt32(lbxAvailableStoreWorkers.SelectedItem.ToString().Substring(0, lbxAvailableStoreWorkers.SelectedItem.ToString().IndexOf('.')));
                        if (shiftManager.AssignEmployeeToShift(foundShift, selectedUser))
                        {
                            MessageBox.Show("Employee was assigned successfully!");
                            UpdateAvailableEmployees(foundShift);
                            UpdateShifts(lbx, foundShift, lbl);
                        }
                        else
                        {
                            MessageBox.Show("The limit of assigned employees for this shift is reached!");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnChangeSelectedWeek_Click(object sender, EventArgs e)
        {
            lbViewSchedule.Visible = false;
            calendarDate.Visible = true;
        }
        private int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        

        private void tcStoreWorkerSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            calendarDate.MinDate = today.AddMonths(-3);
            calendarDate.MaxDate = today.AddMonths(3);
        }

        private void btnShowShifts_Click(object sender, EventArgs e)
        {
            calendarDate.Visible = false;
            DateTime selectedDate = calendarDate.SelectionRange.Start;

            lbViewSchedule.Visible = true;
            lbViewSchedule.Items.Clear();
            btnChangeSelectedWeek.Visible = true;
            int weekNumberOfSelectedDate = GetWeekNumber(selectedDate);
            DateTime startDate = selectedDate;
            DateTime endDate = startDate.AddDays(7);
            List<DateTime> dates = new List<DateTime>();
            for (DateTime i = startDate; i > selectedDate.AddDays(-7); i = i.AddDays(-1))
            {
                if (GetWeekNumber(i.AddDays(-1)) != weekNumberOfSelectedDate)
                {
                    startDate = i;
                    endDate = startDate.AddDays(7);
                    break;
                }
            }
            for (DateTime i = startDate; i < endDate; i = i.AddDays(1))
            {
                dates.Add(i);
            }
            lbWeek.Text = $"Week: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}";
            Dictionary<DateTime, List<Shift>> shifts = shiftManager.GetAllShiftsPerDates(dates);

            foreach (KeyValuePair<DateTime, List<Shift>> d in shifts)
            {
                string date = d.Key.ToString("yyyy-MM-dd");
                lbViewSchedule.Items.Add("--> " + d.Key.ToShortDateString() + " - " + d.Key.DayOfWeek);
                lbViewSchedule.Items.Add("\n");
                foreach (Shift s in d.Value.OrderBy(x=>x.Type))
                {
                    lbViewSchedule.Items.Add("\t" + s.Type.ToString());
                    foreach (Employee employee in s.GetAssignedEmployees())
                    {
                        lbViewSchedule.Items.Add($"\t\t - {employee.Id}. {employee.GetEmployeeNames} - {employee.Contract}");
                    }
                }
                lbViewSchedule.Items.Add("\n");
            }

        }
    }
}
