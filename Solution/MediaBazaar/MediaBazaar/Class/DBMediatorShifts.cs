using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Class
{
    class DBMediatorShifts : DBMediator
    {
        public DBMediatorShifts() : base() { }

        public Dictionary<DateTime, List<Shift>> GetAllShiftsPerDates(List<DateTime> dates)
        {
            List<string> formattedDates = new List<string>();
            foreach (DateTime date in dates)
            {
                formattedDates.Add("'" + date.ToString("yyyy-MM-dd") + "'");
            }


            string sqlStatement = "SELECT s.id as shiftID,s.*,e.id as employeeID, e.* FROM `mb_employee` as e right join mb_shift_with_assigned_employee as es on e.id=es.employeeID right join mb_shift as s on s.id=es.shiftID " +
                "where date in (" + string.Join(",", formattedDates) + ") and e.position='STORE_WORKER' and e.contracttype!='LEFT' order by s.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);

            Dictionary<DateTime, Dictionary<int, Shift>> shifts = new Dictionary<DateTime, Dictionary<int, Shift>>();
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                    int shiftId = Convert.ToInt32(shiftReader["shiftID"]);
                    DateTime date = DateTime.Parse(shiftReader["date"].ToString());
                    int assignableEmployees = Convert.ToInt32(shiftReader["assignableEmployees"]);
                    Enum.TryParse(shiftReader["shiftType"].ToString(), out ShiftType shiftType);
                    Enum.TryParse(shiftReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(shiftReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(shiftReader["gender"].ToString(), out Gender gender);
                    Employee foundEmployee = new Employee
                        (
                           Convert.ToInt32(shiftReader["employeeID"]),
                           shiftReader["bsn"].ToString(),
                           shiftReader["fname"].ToString(),
                           shiftReader["lname"].ToString(),
                           gender,
                           shiftReader["email"].ToString(),
                           shiftReader["uname"].ToString(),
                           DateTime.Parse(shiftReader["birthdate"].ToString()),
                           shiftReader["street"].ToString(),
                           shiftReader["streetnumber"].ToString(),
                           shiftReader["zipcode"].ToString(),
                           shiftReader["town"].ToString(),
                           shiftReader["country"].ToString(),
                           DateTime.Parse(shiftReader["firstworkingday"].ToString()),
                           shiftReader["emergphonenumber"].ToString(),
                           shiftReader["iban"].ToString(),
                           Convert.ToDouble(shiftReader["hourlywage"]),
                           Convert.ToDateTime(shiftReader["contractstartdate"].ToString()),
                           contracttype,
                           position
                        );

                    Shift shift;
                    bool shiftAlreadyAdded = shifts.ContainsKey(date) && shifts[date].ContainsKey(shiftId);
                    if (shiftAlreadyAdded)
                    {
                        shift = shifts[date][shiftId];
                    }
                    else
                    {
                        if (!shifts.ContainsKey(date))
                        {
                            shifts.Add(date, new Dictionary<int, Shift>());
                        }
                        shift = new Shift(shiftId, shiftType, date, new List<Employee>(), assignableEmployees);
                    }

                    shift.AssignEmployee(foundEmployee);
                    shifts[date][shiftId] = shift;
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            Dictionary<DateTime, List<Shift>> shiftsPerDates = new Dictionary<DateTime, List<Shift>>();
            foreach (var dateShifts in shifts)
            {
                shiftsPerDates[dateShifts.Key] = dateShifts.Value.Values.ToList();
            }

            return shiftsPerDates;
        }

        public List<Shift> GetAllShiftsPerDate(DateTime date)
        {
            Dictionary<DateTime, List<Shift>> shifts = GetAllShiftsPerDates(new List<DateTime>() { date });

            if (shifts.ContainsKey(date))
            {
                return shifts[date];
            }

            return new List<Shift>();
        }

        public int AddShift(ShiftType shift, string date, int assignableEmployees)
        {
            string sqlStatement = "INSERT INTO `mb_shift`(`id`, `shiftType`, `date`,`assignableEmployees`) VALUES (id,@shift,@date,@assignableEmployees); SELECT LAST_INSERT_ID(); ";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);

            sqlCommand.Parameters.AddWithValue("@shift", shift.ToString());
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@assignableEmployees", assignableEmployees);
            try
            {
                DbConnection.Open();
                int n = int.Parse(sqlCommand.ExecuteScalar().ToString());
                return n;
            }

            finally
            {
                this.DbConnection.Close();
            }

        }
        public Employee AssignEmployeeToShift(Shift shift, int employeeId)
        {
            string sqlStatement = "INSERT INTO `mb_shift_with_assigned_employee`(`shiftID`, `employeeID`) VALUES (@shiftId,@employeeId); SELECT * from mb_employee where id=@employeeId;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@shiftId", shift.Id);
            sqlCommand.Parameters.AddWithValue("@employeeId", employeeId);
            Employee foundEmployee = null;
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                    Enum.TryParse(shiftReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(shiftReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(shiftReader["gender"].ToString(), out Gender gender);
                    foundEmployee = new Employee
                        (
                           Convert.ToInt32(shiftReader["id"]),
                           shiftReader["bsn"].ToString(),
                           shiftReader["fname"].ToString(),
                           shiftReader["lname"].ToString(),
                           gender,
                           shiftReader["email"].ToString(),
                           shiftReader["uname"].ToString(),
                           DateTime.Parse(shiftReader["birthdate"].ToString()),
                           shiftReader["street"].ToString(),
                           shiftReader["streetnumber"].ToString(),
                           shiftReader["zipcode"].ToString(),
                           shiftReader["town"].ToString(),
                           shiftReader["country"].ToString(),
                           DateTime.Parse(shiftReader["firstworkingday"].ToString()),
                           shiftReader["emergphonenumber"].ToString(),
                           shiftReader["iban"].ToString(),
                           Convert.ToDouble(shiftReader["hourlywage"]),
                           Convert.ToDateTime(shiftReader["contractstartdate"].ToString()),
                           contracttype,
                           position
                        );
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return foundEmployee;
        }
        public bool RemoveEmployeeFromShift(Shift shift, int employeeId)
        {
            string sqlStatement = "DELETE FROM `mb_shift_with_assigned_employee` WHERE shiftID=@shiftId and employeeID=@employeeID";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@shiftId", shift.Id);
            sqlCommand.Parameters.AddWithValue("@employeeId", employeeId);
            try
            {
                DbConnection.Open();
                int n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool ChangeAssignableEmployees(Shift shift, int newValue)
        {
            string sqlStatement = "UPDATE mb_shift SET assignableEmployees = @newValue WHERE id = @shiftId";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@shiftId", shift.Id);
            sqlCommand.Parameters.AddWithValue("@newValue", newValue);
            try
            {
                DbConnection.Open();
                int n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e) { 
            
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public Dictionary<Employee, int> GetAvailableEmployees(Shift shift, string date)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times*4) as assignedHours, e.* from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where week(date, 1) = week(@date, 1)) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id not in (" + string.Join(",", shift.GetAssignedEmployeesIds()) + ") and e.position='STORE_WORKER' and e.contracttype!='LEFT'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@date", date);
            Dictionary<Employee, int> availableEmployees = new Dictionary<Employee, int>();
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                    Enum.TryParse(shiftReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(shiftReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(shiftReader["gender"].ToString(), out Gender gender);
                    Employee foundEmployee = new Employee
                        (
                           Convert.ToInt32(shiftReader["id"]),
                           shiftReader["bsn"].ToString(),
                           shiftReader["fname"].ToString(),
                           shiftReader["lname"].ToString(),
                           gender,
                           shiftReader["email"].ToString(),
                           shiftReader["uname"].ToString(),
                           DateTime.Parse(shiftReader["birthdate"].ToString()),
                           shiftReader["street"].ToString(),
                           shiftReader["streetnumber"].ToString(),
                           shiftReader["zipcode"].ToString(),
                           shiftReader["town"].ToString(),
                           shiftReader["country"].ToString(),
                           DateTime.Parse(shiftReader["firstworkingday"].ToString()),
                           shiftReader["emergphonenumber"].ToString(),
                           shiftReader["iban"].ToString(),
                           Convert.ToDouble(shiftReader["hourlywage"]),
                           Convert.ToDateTime(shiftReader["contractstartdate"].ToString()),
                           contracttype,
                           position
                        );
                    availableEmployees.Add(foundEmployee, Convert.ToInt32(shiftReader["assignedHours"]));
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return availableEmployees;
        }
    }
}
