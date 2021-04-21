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
        private DateTime date;
        private int assignableEmployees;
        private List<Employee> assignedEmployees;
        public ShiftType Type
        {
            get { return this.type; }

        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public int AssignableEmployees
        {
            get { return this.assignableEmployees; }
            set { this.assignableEmployees = value; }
        }
        public Shift(ShiftType shiftType, DateTime date, List<Employee> assignedEmployees, int assignableEmployees)
        {
            this.type = shiftType;
            this.date = date;
            this.assignedEmployees = assignedEmployees;
            this.assignableEmployees = assignableEmployees;

        }

        public List<Employee> GetAssignedEmployees()
        {
            return this.assignedEmployees;
        }

        public List<int> GetAssignedEmployeesIds()
        {
            List<int> ids = new List<int>();
            foreach (Employee employee in this.assignedEmployees)
            {
                ids.Add(employee.Id);
            }
            if (ids.Count == 0)
            {
                ids.Add(-1);
            }
            return ids;
        }
        public void AssignEmployee(Employee employee)
        {
            assignedEmployees.Add(employee);

        }
        public bool RemoveEmployee(int employeeId)
        {
            foreach (Employee employee in assignedEmployees)
            {
                if (employee.Id == employeeId)
                {
                    assignedEmployees.Remove(employee);
                    return true;
                }
            }

            return false;

        }
    }
}
