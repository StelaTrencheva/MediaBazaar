using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Shift
    {
        private ShiftType type;
        private List<Employee> assignedEmployees;
        public ShiftType Type
        {
            get { return this.type; }
        }
        public Shift(ShiftType shiftType)
        {
            this.type = shiftType;
            assignedEmployees = new List<Employee>();
        }
        public void AssignEmployee(Employee employee)
        {
            employee.AvailableWorkingHours += 4;
            assignedEmployees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            employee.AvailableWorkingHours -= 4;
            assignedEmployees.Remove(employee);
        }
        public List<Employee> GetAssignedEmployees()
        {
            return this.assignedEmployees;
        }
    }
}
