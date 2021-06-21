﻿using MySql.Data.MySqlClient;
using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class DBMediatorShifts : DBMediator
    {
        public DBMediatorShifts() : base() { }

        public Dictionary<DateTime, List<Shift>> GetAllShiftsPerDates(List<DateTime> dates)
        {
            List<string> formattedDates = new List<string>();
            foreach (DateTime date in dates)
            {
                formattedDates.Add("'" + date.ToString("yyyy-MM-dd") + "'");
            }
            string sqlStatement = "SELECT s.*,e.id as employeeID, e.* FROM `mb_employee` as e right join mb_shift_with_assigned_employee as es on e.id=es.employeeID " +
                "right join mb_shift as s on s.date=es.date and s.shiftType=es.shiftType where s.date in (" + string.Join(",", formattedDates) + ") and e.position='STORE_WORKER' and e.contracttype!='LEFT'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);

            Dictionary<DateTime, Dictionary<KeyValuePair<ShiftType, DateTime>, Shift>> shifts = new Dictionary<DateTime, Dictionary<KeyValuePair<ShiftType, DateTime>, Shift>>();
            try
            {
                MySqlDataReader shiftReader;
                DbConnection.Open();
                shiftReader = sqlCommand.ExecuteReader();
                while (shiftReader.Read())
                {
                    
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
                    bool shiftAlreadyAdded = shifts.ContainsKey(date) && shifts[date].ContainsKey(new KeyValuePair<ShiftType, DateTime>(shiftType,date));
                    if (shiftAlreadyAdded)
                    {
                        shift = shifts[date][new KeyValuePair<ShiftType, DateTime>(shiftType, date)];
                    }
                    else
                    {
                        if (!shifts.ContainsKey(date))
                        {
                            shifts.Add(date, new Dictionary< KeyValuePair<ShiftType, DateTime>, Shift>());
                        }
                        //shift = new Shift(shiftType, date, new List<Employee>(), assignableEmployees);
                        shift = new Shift(shiftType, date, new List<Employee>());
                    }

                    shift.AssignEmployee(foundEmployee);
                    shifts[date][new KeyValuePair<ShiftType, DateTime>(shiftType, date)] = shift;
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

        public bool AddShift(Shift shift)
        {
            string sqlStatement = "INSERT INTO `mb_shift`(`shiftType`, `date`,`assignableEmployees`) VALUES (@shiftType,@date,@assignableEmployees) on duplicate key update assignableEmployees=@assignableEmployees;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);

            sqlCommand.Parameters.AddWithValue("@shiftType", shift.Type.ToString());
            sqlCommand.Parameters.AddWithValue("@date", shift.Date.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@assignableEmployees", shift.AssignableEmployees);
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
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }

        }
        public Employee AssignEmployeeToShift(Shift shift, int employeeId)
        {
            string sqlStatement = "INSERT INTO `mb_shift_with_assigned_employee`(`shiftType`, `date`, `employeeID`) VALUES (@shiftType,@date,@employeeId);SELECT * from mb_employee where id=@employeeId;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@shiftType", shift.Type.ToString());
            sqlCommand.Parameters.AddWithValue("@date", shift.Date.ToString("yyyy-MM-dd"));
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
            string sqlStatement = "DELETE FROM `mb_shift_with_assigned_employee` WHERE employeeID=@employeeID and shiftType=@shiftType and date=@date";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@shiftType", shift.Type.ToString());
            sqlCommand.Parameters.AddWithValue("@date", shift.Date.ToString("yyyy-MM-dd"));
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
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
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
            string sqlStatement = "select IF(es.times IS NULL, 0, es.times*4) as assignedHours,IF(esd.times_day IS NULL, 0, esd.times_day*4) as assignedHoursPerDay, e.* from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where week(date, 1) = week(@date, 1) group by employeeID)es ON es.employeeID = e.id left join" +
                "(select count(*) as times_day, employeeID from mb_shift_with_assigned_employee where date = @date group by employeeID)esd ON esd.employeeID = e.id" +
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
                    if (Convert.ToInt32(shiftReader["assignedHoursPerDay"]) < 12)
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
            }
            finally
            {
                this.DbConnection.Close();

            }
            return availableEmployees;
        }

        //Automatic Schedule
        public virtual List<EmployeeInSchedule> GetEmployeesAvailabilityPerDepartmentAndWeekNumber(Department department, int week)
        {
            // gets employee info and available shifts per employee
            string sqlStatement = $"SELECT e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate',ea.shiftType,ea.date FROM mb_employee_availability as ea inner join mb_employee e on ea.employeeID=e.id inner join mb_employee_contract ec on e.id=ec.empid inner join mb_department_storeworker as ds on e.id=ds.storeworker_id where ec.startdate<now() and ec.lastdate>now() and week(ea.date,1)=@week and ds.dept_code=@department and e.id not in (select mb_holidays.employeeID from mb_holidays where ea.date between mb_holidays.start_date and mb_holidays.end_date)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);
            sqlCommand.Parameters.AddWithValue("@department", department.Code);

            Dictionary<int, EmployeeInSchedule> employeesInSchedule = new Dictionary<int, EmployeeInSchedule>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    Shift availableShift = new Shift(shiftType, Convert.ToDateTime(EmployeeReader["date"]), new List<Employee>());

                    AddEmployeeInSchedule(employeesInSchedule, emp, availableShift);
                }
                return employeesInSchedule.Values.ToList();
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public List<EmployeeInSchedule> GetAllFlexContractEmployees(int week,Department department)
        {
            // gets employee info and available shifts per employee
            string sqlStatement = $"SELECT e.*,ec.contract as 'contracttype',ec.startdate as 'contractstartdate',ea.shiftType,ea.date FROM mb_employee_availability as ea inner join mb_employee e on ea.employeeID=e.id inner join mb_employee_contract ec on e.id=ec.empid where ec.startdate<now() and ec.lastdate>now() and week(ea.date,1)=@week and e.id not in (select mb_holidays.employeeID from mb_holidays where ea.date between mb_holidays.start_date and mb_holidays.end_date) and e.id not in(SELECT mb_department_storeworker.storeworker_id from mb_department_storeworker where mb_department_storeworker.dept_code=@department) and ec.contract='FLEX'";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);
            sqlCommand.Parameters.AddWithValue("@department", department.Code);
            Dictionary<int, EmployeeInSchedule> employeesInSchedule = new Dictionary<int, EmployeeInSchedule>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    Enum.TryParse(EmployeeReader["shiftType"].ToString(), out ShiftType shiftType);
                    Employee emp = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    Shift availableShift = new Shift(shiftType, Convert.ToDateTime(EmployeeReader["date"]), new List<Employee>());

                    AddEmployeeInSchedule(employeesInSchedule, emp, availableShift);
                }
                return employeesInSchedule.Values.ToList();
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        private void AddEmployeeInSchedule(Dictionary<int, EmployeeInSchedule> employeesInSchedule, Employee employee, Shift shift)
        {
            if (!employeesInSchedule.ContainsKey(employee.Id))
            {
                employeesInSchedule.Add(employee.Id, new EmployeeInSchedule(employee));
            }

            employeesInSchedule[employee.Id].AddAvailability(shift);
        }
    }
}
