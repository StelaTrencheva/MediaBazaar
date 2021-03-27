using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace MediaBazaar
{
    public class Schedule
    {
        private DatabaseMediator DBMediator;
        private List<Employee> assignedEmployees;
        private List<Employee> availableEmployees;
        public Schedule()
        {
            DBMediator = new DatabaseMediator();
        }
        private List<Employee> GetStoreWorkers(string query, ShiftType shift, string date)
        {
            List<Employee> storeWorkers = new List<Employee>();
            string sqlStatement = query;
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@shift", shift.ToString());
            sqlCommand.Parameters.AddWithValue("@date", date);
            MySqlDataReader mySqlDataReader = null;
            try
            {
                mySqlDataReader = this.DBMediator.OpenExecuteReader(sqlCommand);
                while (mySqlDataReader.Read())
                {
                    Enum.TryParse(mySqlDataReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(mySqlDataReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(mySqlDataReader["gender"].ToString(), out Gender gender);
                    Employee foundEmployee = new Employee
                        (
                           Convert.ToInt32(mySqlDataReader["id"]),
                           mySqlDataReader["bsn"].ToString(),
                           mySqlDataReader["fname"].ToString(),
                           mySqlDataReader["lname"].ToString(),
                           gender,
                           mySqlDataReader["email"].ToString(),
                           mySqlDataReader["uname"].ToString(),
                           mySqlDataReader["pwd"].ToString(),
                           DateTime.Parse(mySqlDataReader["birthdate"].ToString()),
                           mySqlDataReader["street"].ToString(),
                           mySqlDataReader["streetnumber"].ToString(),
                           mySqlDataReader["zipcode"].ToString(),
                           mySqlDataReader["town"].ToString(),
                           mySqlDataReader["country"].ToString(),
                           DateTime.Parse(mySqlDataReader["firstworkingday"].ToString()),
                           mySqlDataReader["emergphonenumber"].ToString(),
                           mySqlDataReader["iban"].ToString(),
                           Convert.ToDouble(mySqlDataReader["hourlywage"]),
                           contracttype,
                           position
                        );
                    if (position == EmployeeType.STORE_WORKER&& contracttype !=ContractType.LEFT)
                    {
                        storeWorkers.Add(foundEmployee);
                    }

                }
            }

            finally
            {
                this.DBMediator.CloseExecuteReader(mySqlDataReader);

            }
            return storeWorkers;
        }

        private Shift AddShift(ShiftType shift, string date)
        {
            string sqlStatement = "INSERT INTO `mb_shift`(`id`, `shiftType`, `date`) VALUES (id,@shift,@date); SELECT LAST_INSERT_ID(); ";
            MySqlCommand sqlCommand =
                new MySqlCommand(sqlStatement, this.DBMediator.GetDBConnection());

            sqlCommand.Parameters.AddWithValue("@shift", shift.ToString());
            sqlCommand.Parameters.AddWithValue("@date", date);

            int n = this.DBMediator.ExecuteScalar(sqlCommand);
            Shift newShift = new Shift(n, shift, DateTime.Parse(date), assignedEmployees, availableEmployees);
            return newShift;

        }
        public Shift GetShift(ShiftType shift, string date)
        {
            assignedEmployees = GetStoreWorkers("SELECT * FROM `mb_employee` where mb_employee.id in (select mb_shift_with_assigned_employee.employeeID from mb_shift_with_assigned_employee WHERE mb_shift_with_assigned_employee.shiftID in (SELECT mb_shift.id from mb_shift where mb_shift.shiftType=@shift and date=@date))", shift, date);
            availableEmployees = GetStoreWorkers("SELECT * FROM `mb_employee` where mb_employee.id not in (select mb_shift_with_assigned_employee.employeeID from mb_shift_with_assigned_employee WHERE mb_shift_with_assigned_employee.shiftID in (SELECT mb_shift.id from mb_shift where mb_shift.shiftType=@shift and date=@date))", shift, date);
            string sqlStatement = "SELECT id from mb_shift where shiftType = @shift and date=@date";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@shift", shift.ToString());
            sqlCommand.Parameters.AddWithValue("@date", date);
            MySqlDataReader shiftReader = null;
            Shift foundShift = null;
            try
            {
                shiftReader = this.DBMediator.OpenExecuteReader(sqlCommand);
                while (shiftReader.Read())
                {
                    foundShift = new Shift((int)shiftReader["id"], shift, DateTime.Parse(date), assignedEmployees, availableEmployees);
                }
            }
            finally
            {
                this.DBMediator.CloseExecuteReader(shiftReader);

            }
            if (foundShift == null)
            {
                foundShift = AddShift(shift, date);
            }
            return foundShift;
        }

        public Employee AssignEmployeeToShift(Shift shift, string bsn)
        {
            Employee employee = shift.AssignEmployee(bsn);

            string sqlStatement = "INSERT INTO `mb_shift_with_assigned_employee`(`shiftID`, `employeeID`) VALUES (@shiftId,@employeeId)";
            MySqlCommand sqlCommand =
                new MySqlCommand(sqlStatement, this.DBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@shiftId", shift.Id);
            sqlCommand.Parameters.AddWithValue("@employeeId", employee.Id);


            int n = this.DBMediator.ExecuteNonQuery(sqlCommand);
            shift.AssignEmployee(bsn);
            if (n == 0)
                return null;
            else if (n == 1)
                return employee;
            else
                throw new ArgumentOutOfRangeException(
                    "--This should not be happening--\n" +
                    "Unexpected result from database manager:\n" +
                    "addition of film entry results in number " + n
                );
        }

        public Employee RemoveEmployeeFromShift(Shift shift, string bsn)
        {
            Employee employee = shift.RemoveEmployee(bsn);

            string sqlStatement = "DELETE FROM `mb_shift_with_assigned_employee` WHERE shiftID=@shiftId and employeeID=@employeeID";
            MySqlCommand sqlCommand =
                new MySqlCommand(sqlStatement, this.DBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@shiftId", shift.Id);
            sqlCommand.Parameters.AddWithValue("@employeeId", employee.Id);


            int n = this.DBMediator.ExecuteNonQuery(sqlCommand);
            shift.RemoveEmployee(bsn);
            if (n == 0)
                return null;
            else if (n == 1)
                return employee;
            else
                throw new ArgumentOutOfRangeException(
                    "--This should not be happening--\n" +
                    "Unexpected result from database manager:\n" +
                    "addition of film entry results in number " + n
                );
        }
        public Dictionary<int, int> GetEmployeesAssignedHours(List<int> employees, string date)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where week(date, 1) = week(@date, 1)) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id in (" + string.Join(",", employees) + ")";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DBMediator.GetDBConnection());
            sqlCommand.Parameters.AddWithValue("@date", date);
            Dictionary<int, int> assignedHours = new Dictionary<int, int>();
            MySqlDataReader Reader = null;
            try
            {
                Reader = this.DBMediator.OpenExecuteReader(sqlCommand);
                while (Reader.Read())
                {
                    assignedHours.Add(Convert.ToInt32(Reader["id"]), Convert.ToInt32(Reader["assignedHours"]) * 4);
                }
            }
            finally
            {
                this.DBMediator.CloseExecuteReader(Reader);

            }
            return assignedHours;


        }


    }
}
