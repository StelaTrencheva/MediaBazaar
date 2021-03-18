using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Shift
    {
        private int id;
        private ShiftType type;
        private DateTime date;

        private List<Employee> assignedEmployees;
        private List<Employee> availableEmployees;
        public int Id
        {
            get { return this.id; }
        }
        public ShiftType Type
        {
            get { return this.type; }

        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public Shift(int id, ShiftType shiftType, DateTime date, List<Employee> assignedEmployees, List<Employee> availableEmployees)
        {
            this.id = id;
            this.type = shiftType;
            this.date = date;
            this.assignedEmployees = assignedEmployees;
            this.availableEmployees = availableEmployees;
        }

        public List<Employee> GetAssignedEmployees()
        {
            return this.assignedEmployees;
        }
        public List<Employee> GetAvailableEmployees()
        {

            return this.availableEmployees;
        }
        public List<int> GetAvailableEmployeesIds()
        {
            List<int> ids = new List<int>();
            foreach (Employee e in availableEmployees)
            {
                ids.Add(e.Id);
            }
            return ids;
        }
        private Employee FindEmployee(string bsn, List<Employee> listOfEmployees)
        {
            foreach (Employee employee in listOfEmployees)
            {
                if (employee.BSN == bsn)
                {
                    return employee;
                }
            }
            return null;
        }
        public Employee AssignEmployee(string bsn)
        {
            Employee foundEmployee = FindEmployee(bsn, availableEmployees);
            assignedEmployees.Add(foundEmployee);
            availableEmployees.Remove(foundEmployee);
            return foundEmployee;
        }

        public Employee RemoveEmployee(string bsn)
        {
            Employee foundEmployee = FindEmployee(bsn, assignedEmployees);
            availableEmployees.Add(foundEmployee);
            assignedEmployees.Remove(foundEmployee);
            return foundEmployee;

        }
    }
}
