using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ProjectClasses;
using ProjectClasses.Exceptions;
using ProjectClasses.LogicLayer;

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
        private List<Shift> shifts = null;
        private Color cellColor = Color.White;
        private DepartmentManager dm;
        private WeekSchedule newSchedule;
        private Shift currentSelectedShift;

        public StoreWorkerScheduleInterface()
        {
            InitializeComponent();
            shiftManager = new ShiftManager(DatabaseType.MAIN);
            dm = new DepartmentManager(DatabaseType.MAIN);
            ShowDepartments();
        }
       
        // View Schedule
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
        private void AddDefaultRows(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i= 0; i<7; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].HeaderCell.Value = ((DayOfWeek)i).ToString();
                dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
            }


        }

        private void btnShowShifts_Click(object sender, EventArgs e)
        {
            calendarDate.Visible = false;
            DateTime selectedDate = calendarDate.SelectionRange.Start;
            DisplayAllPanelsInView(true);
            AddDefaultRows(dgvViewShifts);
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
            lblDisplayedDates.Text = $"Week: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}";
            //shifts = shiftManager.GetAllShiftsPerDates(dates);
            
            //foreach (KeyValuePair<DateTime, List<Shift>> d in shifts)
            //{   
            //    foreach (Shift s in d.Value.OrderBy(x => x.Type))
            //    {
            //        int rowIndex = dgvViewShifts.Rows.IndexOf(dgvViewShifts.Rows[(int)(d.Key.DayOfWeek)-1]);
                    
            //        if (s.AssignableEmployees == s.GetAssignedEmployees().Count)
            //        {
            //            dgvViewShifts.Rows[rowIndex].Cells[$"cl{s.Type}"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#63A375");
            //        }
            //        if (s.GetAssignedEmployees().Count > 0 && s.GetAssignedEmployees().Count<s.AssignableEmployees)
            //        {
            //            dgvViewShifts.Rows[rowIndex].Cells[$"cl{s.Type}"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFB563");
            //        }
            //        if (s.GetAssignedEmployees().Count == 0)
            //        {
            //            dgvViewShifts.Rows[rowIndex].Cells[$"cl{s.Type}"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
            //        }
            //        dgvViewShifts[$"cl{s.Type}",rowIndex].Value=$"{s.GetAssignedEmployees().Count}/{s.AssignableEmployees} emp. assigned";
            //    }
            //}

        }
       

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //pnlDisplayEmployees.Visible = true;
            //int rowIndex = dgvViewShifts.CurrentCell.RowIndex;
            //int columnIndex = dgvViewShifts.CurrentCell.ColumnIndex;
            //Enum.TryParse(dgvViewShifts.Rows[rowIndex].HeaderCell.Value.ToString(), out DayOfWeek day);
            //string formatedDate = "";
            //foreach (DateTime date in dates)
            //{
            //    if (date.DayOfWeek == day)
            //    {
            //        formatedDate = date.ToString("yyyy-MM-dd");
            //    }
            //}
            //Enum.TryParse(dgvViewShifts.Columns[columnIndex].HeaderText.ToString(), out ShiftType shiftType);
            //Shift shift = shiftManager.GetShift(shiftType,formatedDate);
            //if (shift.GetAssignedEmployees().Count == 0)
            //{
            //    lbDisplayEmployees.Items.Add($"0 out of {shift.AssignableEmployees} employees are assigned to this shift!");
            //}
            //else
            //{
            //    foreach (Employee employee in shift.GetAssignedEmployees())
            //    {
            //        lbDisplayEmployees.Items.Add($"{employee.Id}. {employee.GetEmployeeNames}");
            //    }
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlDisplayEmployees.Visible = false;
            lbDisplayEmployees.Items.Clear();
        }


       // Automatic Schedule
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DisplayAllPanelsInAutoSchedule(false);
            pnlGenerateSchedule.Visible = true;
        }
        private void DisplayAllPanelsInAutoSchedule(bool visible)
        {
            pnlSelectedWeek.Visible = visible;
            pnlManageCreatedSchedule.Visible = visible;
            pnlSchedule.Visible = visible;
        }
        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayAllPanelsInAutoSchedule(true);
                pnlGenerateSchedule.Visible = false;
                DateTime selectedDate = monthCalendarAutoSchedule.SelectionRange.Start;

                Department department = new Department(Convert.ToInt32(cbxDepartment.SelectedItem.ToString().Substring(6, cbxDepartment.SelectedItem.ToString().IndexOf('-') - 7)), cbxDepartment.SelectedItem.ToString().Substring(cbxDepartment.SelectedItem.ToString().IndexOf('-') + 2, cbxDepartment.SelectedItem.ToString().Length - (cbxDepartment.SelectedItem.ToString().IndexOf('-') + 2)));

                newSchedule = shiftManager.CreateWeekSchedule(selectedDate, department);

                lblSelectedWeekAndDepartment.Text = $"Week: {newSchedule.WeekStartDate.ToShortDateString()} - {newSchedule.WeekEndDate.ToShortDateString()} - Department: {newSchedule.Department.Name}";
                shifts = newSchedule.GetAllShifts();
                AddDefaultRows(dgvViewGeneratedSchedule);
                UpdateDisplayOfShiftsInGrid();
                
            }
            catch(NotEnoughEmmployeesException ex)
            {
                DisplayAllPanelsInAutoSchedule(false);
                pnlGenerateSchedule.Visible = true;
                MessageBox.Show(ex.Message);
                
            }
        }

        private void picInfo_MouseHover_1(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void picInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
        private void ShowDepartments()
        {
            cbxDepartment.Items.Clear();
            foreach (Department department in dm.GetDepartments())
            {
                cbxDepartment.Items.Add(department.ToString());
            }
        }
        private void cbxDepartment_Click(object sender, EventArgs e)
        {
            ShowDepartments();
        }

        private void btnClosePanelAssignedEmployees_Click(object sender, EventArgs e)
        {
            pnlDisplayAssignedEmployees.Visible = false;
        }

        private void dgvViewGeneratedSchedule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlDisplayAssignedEmployees.Visible = true;
            pnlDisplayAssignedEmployees.BringToFront();
            lbxAssignedEmployees.Items.Clear();
            int rowIndex = dgvViewGeneratedSchedule.CurrentCell.RowIndex;
            int columnIndex = dgvViewGeneratedSchedule.CurrentCell.ColumnIndex;
            Enum.TryParse(dgvViewGeneratedSchedule.Rows[rowIndex].HeaderCell.Value.ToString(), out DayOfWeek day);
            Enum.TryParse(dgvViewGeneratedSchedule.Columns[columnIndex].HeaderText.ToString(), out ShiftType shiftType);
            currentSelectedShift = newSchedule.GetShift(shiftType, day);
            if (currentSelectedShift.GetAssignedEmployees().Count == 0)
            {
                lbxAssignedEmployees.Items.Add($"0 out of {currentSelectedShift.AssignableEmployees} employees are assigned to this shift!");
            }
            else
            {
                foreach (Employee employee in currentSelectedShift.GetAssignedEmployees())
                {
                    lbxAssignedEmployees.Items.Add($"{employee.Id}. {employee.GetEmployeeNames}");
                }
            }
        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {
            pnlDisplayAssignedEmployees.Visible = false;
            btnSave.Enabled = false;
            btnDiscard.Enabled = false;
            pnlEditShift.Visible = true;
            pnlEditShift.BringToFront();
            UpdateInfoInAutoSchedule();
            tbMaxAssignableEmployees.Text = currentSelectedShift.AssignableEmployees.ToString();
            
        }
        private void UpdateInfoInAutoSchedule()
        {
            lbxAvailableEmployeesForShift.Items.Clear();
            lbxAssignedEmployeesToShift.Items.Clear();
            foreach (Employee employee in currentSelectedShift.GetAssignedEmployees())
            {
                lbxAssignedEmployeesToShift.Items.Add($"{employee.Id}. {employee.GetEmployeeNames} - {newSchedule.GetAssignedHoursPerWeek(employee)}h assigned for the week");
            }
            foreach (EmployeeInSchedule employeeInSchedule in newSchedule.GetAllAvailableEmployees(currentSelectedShift))
            {
                ListViewItem newItem = new ListViewItem($"{employeeInSchedule.Employee.Id}. {employeeInSchedule.Employee.GetEmployeeNames} - {newSchedule.GetAssignedHoursPerWeek(employeeInSchedule.Employee)}h assigned for the week");
                lbxAvailableEmployeesForShift.Items.Add(newItem);
                if (newSchedule.HasEmployeeReachedWeeklyHoursLimit(employeeInSchedule))
                {
                    lbxAvailableEmployeesForShift.Items[lbxAvailableEmployeesForShift.Items.IndexOf(newItem)].BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
                }
            }
        }
        private void btnCloseEditMode_Click(object sender, EventArgs e)
        {
            btnDiscard.Enabled = true;
            btnSave.Enabled = true;
            pnlEditShift.Visible = false;
            pnlDisplayAssignedEmployees.Visible = false;
            UpdateDisplayOfShiftsInGrid();

        }
        private void UpdateDisplayOfShiftsInGrid()
        {
            foreach (Shift s in shifts)
            {
                int rowIndex = dgvViewGeneratedSchedule.Rows.IndexOf(dgvViewGeneratedSchedule.Rows[Convert.ToInt32(s.Date.DayOfWeek)]);
                if (s.AssignableEmployees == s.GetAssignedEmployees().Count)
                {
                    dgvViewGeneratedSchedule.Rows[rowIndex].Cells[$"cl{s.Type}Schedule"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#63A375");
                }
                if (s.GetAssignedEmployees().Count > 0 && s.GetAssignedEmployees().Count < s.AssignableEmployees)
                {
                    dgvViewGeneratedSchedule.Rows[rowIndex].Cells[$"cl{s.Type}Schedule"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFB563");
                }
                if (s.GetAssignedEmployees().Count == 0)
                {
                    dgvViewGeneratedSchedule.Rows[rowIndex].Cells[$"cl{s.Type}Schedule"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
                }
                dgvViewGeneratedSchedule[$"cl{s.Type}Schedule", rowIndex].Value = $"{s.GetAssignedEmployees().Count}/{s.AssignableEmployees} emp. assigned";
            }
        }
        private void btnChangeMaxAssignableEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                int newValue = Convert.ToInt32(tbMaxAssignableEmployees.Text);
                currentSelectedShift.AssignableEmployees = newValue;
                tbMaxAssignableEmployees.Text = newValue.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            int selectedUser;
            try
            {
                if (lbxAssignedEmployeesToShift.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a store worker from the assigned store workers for the selected shift!");
                }
                else
                {
                    selectedUser = Convert.ToInt32(lbxAssignedEmployeesToShift.SelectedItem.ToString().Substring(0, lbxAssignedEmployeesToShift.SelectedItem.ToString().IndexOf('.')));
                    if (currentSelectedShift.RemoveEmployee(selectedUser))
                    {
                        MessageBox.Show("Employee was removed from this shift.");
                        UpdateInfoInAutoSchedule();
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

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            int selectedUser;
            
                if (lbxAvailableEmployeesForShift.SelectedItems.Count<=0)
                {
                    MessageBox.Show("Please select a store worker from the available store workers for the selected shift!");
                }
                else
                {
                    string selectedItem = lbxAvailableEmployeesForShift.SelectedItems[0].Text;
                    selectedUser = Convert.ToInt32(selectedItem.Substring(0, selectedItem.IndexOf('.')));
                    EmployeeInSchedule foundEmployee = newSchedule.GetEmployeeFromAvailableEmployees(currentSelectedShift, selectedUser);
                    if (newSchedule.AssignEmployeeToShift(currentSelectedShift,foundEmployee))
                    {
                        UpdateInfoInAutoSchedule();
                    }
                    else
                    {
                        MessageBox.Show("The employee cannot be assigned to the shift!");
                    }

                }
        }
    }
}
