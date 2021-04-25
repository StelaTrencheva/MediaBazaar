﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{
    public partial class StoreWorkerScheduleInterface : UserControl
    {
        private DateTime today = DateTime.Today;
        private ShiftManager shiftManager;
        private Shift foundShift;
        private ListBox lbx = null;
        private Label lbl = null;
        private List<DateTime> dates = new List<DateTime>();
        private Dictionary<DateTime, List<Shift>> shifts = null;
        private Color cellColor = Color.White;

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
                        string selectedItem = lbxAvailableStoreWorkers.SelectedItem.ToString();
                        selectedUser = Convert.ToInt32(selectedItem.Substring(0, selectedItem.IndexOf('.')));
                        int selectedUserAssignedHours = Convert.ToInt32(selectedItem.Substring(selectedItem.LastIndexOf('-')+2, selectedItem.Length-24- (selectedItem.LastIndexOf('-') + 2)));
                        Employee assignedEmployee = shiftManager.AssignEmployeeToShift(foundShift, selectedUser);
                        if (assignedEmployee!=null)
                        {
                            if ((assignedEmployee.Contract == ContractType.FULLTIME && selectedUserAssignedHours == 40) || (assignedEmployee.Contract == ContractType.EIGHTYPERCENT && selectedUserAssignedHours == 32))
                            {
                                MessageBox.Show("This employee was assigned with more than the contractual hours they have to work for the week!");
                            }
                            else
                            {
                                MessageBox.Show("Employee was assigned successfully!");
                            }
                                
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
            DisplayAllPanelsInView(false);
            calendarDate.Visible = true;
        }
        private int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        private void tcStoreWorkerSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            calendarDate.Visible = true;
            calendarDate.MinDate = today.AddMonths(-3);
            calendarDate.MaxDate = today.AddMonths(3);
            DisplayAllPanelsInView(false);

        }
        private void DisplayAllPanelsInView(bool visible)
        {
            pnlChangeWeek.Visible = visible;
            pnlDisplayDate.Visible = visible;
            dgvViewShifts.Visible = visible;
        }
        private void AddDefaultRows()
        {
            dgvViewShifts.Rows.Clear();
            foreach (Day day in Enum.GetValues(typeof(DayOfWeek)))
            {
                dgvViewShifts.Rows.Add();
                dgvViewShifts.Rows[(int)day].HeaderCell.Value = day.ToString();
                dgvViewShifts.Rows[(int)day].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
            }

        }

        private void btnShowShifts_Click(object sender, EventArgs e)
        {
            calendarDate.Visible = false;
            DateTime selectedDate = calendarDate.SelectionRange.Start;
            DisplayAllPanelsInView(true);
            AddDefaultRows();
            int weekNumberOfSelectedDate = GetWeekNumber(selectedDate);
            DateTime startDate = selectedDate;
            DateTime endDate = startDate.AddDays(7);
            dates = new List<DateTime>();
            for (DateTime i = startDate; i > selectedDate.AddDays(-7); i = i.AddDays(-1))
            {
                if (GetWeekNumber(i.AddDays(-1)) != weekNumberOfSelectedDate)
                {
                    startDate = i;
                    endDate = startDate.AddDays(6);
                    break;
                }
            }
            for (DateTime i = startDate; i < endDate; i = i.AddDays(1))
            {
                dates.Add(i);
            }
            ///
            lblDisplayedDates.Text = $"Week: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}";
            shifts = shiftManager.GetAllShiftsPerDates(dates);
            
            foreach (KeyValuePair<DateTime, List<Shift>> d in shifts)
            {   
                foreach (Shift s in d.Value.OrderBy(x => x.Type))
                {
                    int rowIndex = dgvViewShifts.Rows.IndexOf(dgvViewShifts.Rows[(int)(d.Key.DayOfWeek)-1]);
                    
                    if (s.AssignableEmployees == s.GetAssignedEmployees().Count)
                    {
                        dgvViewShifts.Rows[rowIndex].Cells[$"cl{s.Type}"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#63A375");
                    }
                    if (s.GetAssignedEmployees().Count > 0 && s.GetAssignedEmployees().Count<s.AssignableEmployees)
                    {
                        dgvViewShifts.Rows[rowIndex].Cells[$"cl{s.Type}"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFB563");
                    }
                    if (s.GetAssignedEmployees().Count == 0)
                    {
                        dgvViewShifts.Rows[rowIndex].Cells[$"cl{s.Type}"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#AC1A00");
                    }
                    dgvViewShifts[$"cl{s.Type}",rowIndex].Value=$"{s.GetAssignedEmployees().Count}/{s.AssignableEmployees} emp. assigned";
                }
            }

        }
       

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlDisplayEmployees.Visible = true;
            int rowIndex = dgvViewShifts.CurrentCell.RowIndex;
            int columnIndex = dgvViewShifts.CurrentCell.ColumnIndex;
            Enum.TryParse(dgvViewShifts.Rows[rowIndex].HeaderCell.Value.ToString(), out DayOfWeek day);
            string formatedDate = "";
            foreach (DateTime date in dates)
            {
                if (date.DayOfWeek == day)
                {
                    formatedDate = date.ToString("yyyy-MM-dd");
                }
            }
            Enum.TryParse(dgvViewShifts.Columns[columnIndex].HeaderText.ToString(), out ShiftType shiftType);
            Shift shift = shiftManager.GetShift(shiftType,formatedDate);
            if (shift.GetAssignedEmployees().Count == 0)
            {
                lbDisplayEmployees.Items.Add($"0 out of {shift.AssignableEmployees} employees are assigned to this shift!");
            }
            else
            {
                foreach (Employee employee in shift.GetAssignedEmployees())
                {
                    lbDisplayEmployees.Items.Add($"{employee.Id}. {employee.GetEmployeeNames}");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDisplayEmployees.Visible = false;
            lbDisplayEmployees.Items.Clear();
        }

        // have to be changed
        private void lbxAvailableStoreWorkers_DrawItem(object sender, DrawItemEventArgs e)
        {
            //// Draw the background of the ListBox control for each item.
            //e.DrawBackground();
            //// Define the default color of the brush as black.
            //Brush myBrush = Brushes.Red;
            //switch (e.Index)
            //{
            //    case 0:
            //        myBrush = Brushes.Red;
            //        break;
            //    case 1:
            //        myBrush = Brushes.Orange;
            //        break;
            //    case 2:
            //        myBrush = Brushes.Purple;
            //        break;
            //}
            //// Draw the current item text based on the current Font 
            //// and the custom brush settings.
            //e.Graphics.DrawString(lbxAvailableStoreWorkers.Items[e.Index].ToString(),
            //    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //// If the ListBox has focus, draw a focus rectangle around the selected item.
            //e.DrawFocusRectangle();
        }
    }
}