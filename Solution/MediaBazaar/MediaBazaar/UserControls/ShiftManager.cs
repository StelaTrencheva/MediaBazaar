using MediaBazaar.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.UserControls
{
    public class ShiftManager
    {
        private DBMediatorShifts dbMediator;
        private List<Shift> shifts;
        public ShiftManager()
        {
            dbMediator = new DBMediatorShifts();
            shifts = new List<Shift>();
        }
        public Shift AddShift(ShiftType shiftType, string dateString)
        {
            int assignableEmployees = 0;
            DateTime date = DateTime.Parse(dateString);
            if ((shiftType == ShiftType.Morning || shiftType == ShiftType.Night) && (date.DayOfWeek != DayOfWeek.Friday && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday))
            {
                assignableEmployees = 5;
            }
            else
            {
                assignableEmployees = 10;
            }

            int n = dbMediator.AddShift(shiftType, dateString, assignableEmployees);
            Shift newShift = new Shift(n, shiftType, date, new List<Employee>(), assignableEmployees);
            shifts.Add(newShift);
            return newShift;
        }
        public Shift GetShift(ShiftType shiftType, string date)
        {
            foreach (Shift shift in shifts)
            {
                if (shift.Type == shiftType && shift.Date == DateTime.Parse(date))
                {
                    return shift;
                }
            }

            return AddShift(shiftType, date);
        }

        public List<Shift> GetAllShiftsPerDate(string date)
        {
            List<Shift> foundShifts = dbMediator.GetAllShiftsPerDate(DateTime.Parse(date));
            if (foundShifts.Count != 4)
            {
                List<ShiftType> shiftTypes = new List<ShiftType>();
                for (int i = 0; i < foundShifts.Count; i++)
                {
                    shiftTypes.Add(foundShifts[i].Type);
                }
                foreach (ShiftType type in (ShiftType[])Enum.GetValues(typeof(ShiftType)))
                {
                    if (!shiftTypes.Contains(type))
                    {
                        foundShifts.Add(AddShift(type, date));
                    }
                }
            }
            foreach (Shift shift in foundShifts)
            {
                if (!shifts.Contains(shift))
                {
                    shifts.Add(shift);
                }
            }
            return foundShifts;

        }
        public int GetAssignableEmployeesLeft(Shift shift)
        {
            return shift.AssignableEmployees - shift.GetAssignedEmployees().Count;
        }
        public bool ChangeMaxAssignableEmployeesValue(Shift shift, int newValue)
        {
            if (shift.AssignableEmployees > newValue && shift.GetAssignedEmployees().Count > newValue || newValue < 0)
            {
                return false;
            }
            else
            {
                shift.AssignableEmployees = newValue;
                dbMediator.ChangeAssignableEmployees(shift, newValue);
                return true;
            }
        }
        public bool AssignEmployeeToShift(Shift shift, int employeeId)
        {
            Employee assignedEmployeee = null;
            if (GetAssignableEmployeesLeft(shift) > 0)
            {
                assignedEmployeee = dbMediator.AssignEmployeeToShift(shift, employeeId);
                if (assignedEmployeee != null)
                {
                    shift.AssignEmployee(assignedEmployeee);
                    return true;
                }
            }
            return false;
        }
        public bool RemoveEmployeeFromShift(Shift shift, int employeeId)
        {
            if (dbMediator.RemoveEmployeeFromShift(shift, employeeId))
            {
                shift.RemoveEmployee(employeeId);
                return true;
            }
            return false;
        }
        public Dictionary<Employee, int> GetAvailableEmployees(Shift shift, string date)
        {
            Dictionary<Employee, int> availableEmployees = new Dictionary<Employee, int>();
            availableEmployees = dbMediator.GetAvailableEmployees(shift, date);
            return availableEmployees;
        }

        public Dictionary<DateTime, List<Shift>> GetAllShiftsPerDates(List<DateTime> dates)
        {
            Dictionary<DateTime, List<Shift>> shifts = dbMediator.GetAllShiftsPerDates(dates);

            return shifts;
        }
    }
}
