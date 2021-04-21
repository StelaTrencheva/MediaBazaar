using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class DBMediatorEmpStatistic : DBMediator
    {
        public DBMediatorEmpStatistic() : base() { }
        public int GetEmployeeAssignedHoursForStatPerDay(int id, string date)
        {
            string sqlStatement = " SELECT IFNULL(Count(*),0) as assignedHours " +
                "FROM `mb_shift_with_assigned_employee` as em  " +
                "INNER JOIN `mb_employee`as emp " +
                "ON em.employeeID = emp.id " +
                "WHERE EXTRACT(DAY FROM em.date) = @date AND emp.id = @id " +
                "GROUP BY emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@id", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return assignedHours;
        }
        public int GetEmployeeAssignedHoursForStatPerWeek(int id, int week)
        {
            string sqlStatement = " SELECT IFNULL(Count(*),0) as assignedHours " +
                "FROM `mb_shift_with_assigned_employee` as em  " +
                "INNER JOIN `mb_employee`as emp " +
                "ON em.employeeID = emp.id " +
                "WHERE EXTRACT(WEEK FROM em.date) = @week AND emp.id = @id " +
                "GROUP BY emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@week", week);
            sqlCommand.Parameters.AddWithValue("@id", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return assignedHours;
        }
        public int GetEmployeeAssignedHoursForStatPerMonth(int id, string month)
        {
            string sqlStatement = " SELECT IFNULL(Count(*),0) as assignedHours " +
                "FROM `mb_shift_with_assigned_employee` as em  " +
                "INNER JOIN `mb_employee`as emp " +
                "ON em.employeeID = emp.id " +
                "WHERE EXTRACT(MONTH FROM em.date) = @month AND emp.id = @id " +
                "GROUP BY emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@month", month);
            sqlCommand.Parameters.AddWithValue("@id", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return assignedHours;
        }

        public int GetEmployeeAssignedHoursForStatPerYear(int id, string year)
        {
            string sqlStatement = "SELECT IFNULL(Count(*),0) as assignedHours " +
                                  "FROM `mb_shift_with_assigned_employee` AS em " +
                                  "INNER JOIN `mb_employee`AS emp " +
                                  "ON em.employeeID = emp.id " +
                                  "WHERE EXTRACT(YEAR FROM em.date) = @year AND emp.id = @id " +
                                  "GROUP BY emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@year", year);
            sqlCommand.Parameters.AddWithValue("@id", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.DbConnection.Close();

            }
            return assignedHours;
        }

        public List<double> GetOverallEmpStatTotalSalaryForYear(string year, string conditionTotal, string conditionAvg)
        {
            string sqlStatement = "SELECT IFNULL(Count(*),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(MONTH FROM sh.date) AS month " +
                                  "FROM `mb_shift_with_assigned_employee` as em  " +
                                  "INNER JOIN `mb_shift` as sh " +
                                  "ON sh.shiftType = em.shiftType " +
                                  "INNER JOIN `mb_employee`as emp " +
                                  "ON em.employeeID = emp.id " +
                                  "WHERE EXTRACT(YEAR FROM sh.date) = @year " +
                                  "GROUP BY month, emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@year", year);
            List<double> TotalSalaryPerMonths = new List<double>();
            List<int> Months = new List<int>();
            List<double> counter = new List<double>();
            for (int i = 1; i < 13; i++)
            {
                Months.Add(i);
                TotalSalaryPerMonths.Add(0);
                counter.Add(1);
            }
            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int month = Convert.ToInt32(reader["month"]);
                    double hours = Convert.ToDouble(reader["assignedHours"]);
                    double wage = Convert.ToDouble(reader["wage"]);
                    if (conditionTotal == "Total salary")
                    {
                        foreach (int m in Months)
                        {
                            if (m == month)
                            {
                                TotalSalaryPerMonths[m - 1] += (hours * wage * 4);
                                counter[m - 1] += 1;
                            }

                        }


                    }
                    else if (conditionTotal == "Total hours worked")
                    {
                        foreach (int m in Months)
                        {
                            if (m == month)
                            {
                                TotalSalaryPerMonths[m - 1] += (hours);
                                counter[m - 1] += 1;
                            }

                        }
                    }

                }
            }
            finally
            {
                this.DbConnection.Close();
                if (conditionAvg == "Average")
                {
                    for (int i = 0; i < 12; i++)
                    {
                        TotalSalaryPerMonths[i] /= counter[i];
                    }
                }
            }
            return TotalSalaryPerMonths;
        }
        public List<double> GetOverallEmpStatTotalSalaryForMonth(DateTime date, string conditionTotal, string conditionAvg)
        {
            string sqlStatement = "SELECT IFNULL(Count(*),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(DAY FROM sh.date) AS day " +
                "FROM `mb_shift_with_assigned_employee` as em " +
                "INNER JOIN `mb_shift` as sh " +
                "ON sh.shiftType = em.shiftType " +
                "INNER JOIN `mb_employee`as emp " +
                "ON em.employeeID = emp.id " +
                "WHERE EXTRACT(MONTH FROM sh.date) = @month " +
                "GROUP BY day, emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@month", date.Month.ToString());
            List<double> TotalSalaryPerMonths = new List<double>();
            List<int> Days = new List<int>();
            List<double> counter = new List<double>();
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            for (int j = 1; j < days + 1; j++)
            {
                Days.Add(j);
                TotalSalaryPerMonths.Add(0);
                counter.Add(1);
            }
            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int day = Convert.ToInt32(reader["day"]);
                    double hours = Convert.ToDouble(reader["assignedHours"]);
                    double wage = Convert.ToDouble(reader["wage"]);
                    if (conditionTotal == "Total salary")
                    {
                        foreach (int d in Days)
                        {
                            if (d == day)
                            {
                                TotalSalaryPerMonths[d - 1] += (hours * wage * 4);
                                counter[d - 1] += 1;
                            }

                        }
                    }
                    else if (conditionTotal == "Total hours worked")
                    {
                        foreach (int d in Days)
                        {
                            if (d == day)
                            {
                                TotalSalaryPerMonths[d - 1] += (hours);
                                counter[d - 1] += 1;
                            }

                        }
                    }

                }
            }
            finally
            {
                this.DbConnection.Close();
                if (conditionAvg == "Average")
                {
                    for (int i = 0; i < days; i++)
                    {
                        TotalSalaryPerMonths[i] /= counter[i];
                    }
                }
            }
            return TotalSalaryPerMonths;
        }
        public List<double> GetOverallEmpStatTotalSalaryForWeek(List<DateTime> DaysOfTheWeek, int week, DateTime date, string conditionTotal, string conditionAvg)
        {
            string sqlStatement = "SELECT IFNULL(Count(*),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(DAY FROM sh.date) AS day " +
            "FROM `mb_shift_with_assigned_employee` as em " +
            "INNER JOIN `mb_shift` as sh " +
            "ON sh.shiftType = em.shiftType " +
            "INNER JOIN `mb_employee`as emp " +
            "ON em.employeeID = emp.id " +
            "WHERE EXTRACT(MONTH FROM sh.date) = @month AND EXTRACT(WEEK FROM sh.date) = @week " +
            "GROUP BY day, emp.id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@month", date.Month.ToString());
            sqlCommand.Parameters.AddWithValue("@week", week);
            List<double> TotalSalaryPerWeek = new List<double>();
            List<double> counter = new List<double>();
            for (int i = 0; i < 7; i++)
            {
                TotalSalaryPerWeek.Add(0);
                counter.Add(1);
            }
            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    //DateTime dayy = Convert.ToDateTime(reader["day"]);
                    string day = reader["day"].ToString();
                    double hours = Convert.ToDouble(reader["assignedHours"]);
                    double wage = Convert.ToDouble(reader["wage"]);
                    if (conditionTotal == "Total salary")
                    {
                        foreach (DateTime d in DaysOfTheWeek)
                        {
                            if (d.Day.ToString() == day)
                            {
                                TotalSalaryPerWeek[DaysOfTheWeek.IndexOf(d)] += (hours * wage * 4);
                                counter[DaysOfTheWeek.IndexOf(d)] += 1;
                            }
                        }
                    }
                    else if (conditionTotal == "Total hours worked")
                    {
                        foreach (DateTime d in DaysOfTheWeek)
                        {
                            if (d.Day.ToString() == day)
                            {
                                TotalSalaryPerWeek[DaysOfTheWeek.IndexOf(d)] += (hours);
                                counter[DaysOfTheWeek.IndexOf(d)] += 1;
                            }
                        }
                    }

                }
            }
            finally
            {
                this.DbConnection.Close();
                if (conditionAvg == "Average")
                {
                    for (int h = 0; h < 7; h++)
                    {
                        TotalSalaryPerWeek[h] /= counter[h];
                    }
                }
            }
            return TotalSalaryPerWeek;
        }
    }
}
