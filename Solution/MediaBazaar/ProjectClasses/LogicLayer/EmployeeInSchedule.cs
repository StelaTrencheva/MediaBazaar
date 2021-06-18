using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class EmployeeInSchedule
    {
        private Employee employee;
        private List<Shift> availableShifts;
        public EmployeeInSchedule(Employee employee)
        {
            this.employee = employee;
            availableShifts = new List<Shift>();
        }
        public void AddAvailability(Shift shift)
        {
            if (!availableShifts.Contains(shift))
            {
                availableShifts.Add(shift);
            }
        }
        public string ToString()
        {
            string result= $"ID: {employee.Id}";
            foreach (Shift availableShift in availableShifts)
            {
                result += $" - ({availableShift.Type}, {availableShift.Date})";
            }
            return result;
        }
    }
}
