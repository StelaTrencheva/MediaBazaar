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
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where EXTRACT(DAY FROM date) = @date ) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
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
        public int GetEmployeeAssignedHoursForStatPerWeek(int id, string date)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where week(date, 1) = week(@date, 1)) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
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
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where EXTRACT(MONTH FROM date) = @month ) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@month", month);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
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
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where EXTRACT(YEAR FROM date) = @year ) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@year", year);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
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
            string sqlStatement = "SELECT IFNULL((em.employeeID),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(MONTH FROM sh.date) AS month " +
                                  "FROM `mb_shift_with_assigned_employee` as em  " +
                                  "INNER JOIN `mb_shift` as sh " +
                                  "ON sh.id = em.shiftID " +
                                  "INNER JOIN `mb_employee`as emp " +
                                  "ON em.employeeID = emp.id " +
                                  "WHERE EXTRACT(YEAR FROM sh.date) = @year " +
                                  "GROUP BY EXTRACT(DAY FROM sh.date), month";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@year", year);
            List<double> TotalSalaryPerMonths = new List<double>();
            List<double> counter = new List<double>();
            for (int i = 0; i < 12; i++)
            {
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
                        for (int i = 1; i < 13; i++)
                        {
                            if (i == month)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours * wage * 4);
                                counter[i - 1] += 1;
                            }
                        }
                    }
                    else if (conditionTotal == "Total hours worked")
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            if (i == month)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours);
                                counter[i - 1] += 1;
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
            string sqlStatement = "SELECT IFNULL((em.employeeID),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(DAY FROM sh.date) AS day " +
                "FROM `mb_shift_with_assigned_employee` as em " +
                "INNER JOIN `mb_shift` as sh " +
                "ON sh.id = em.shiftID " +
                "INNER JOIN `mb_employee`as emp " +
                "ON em.employeeID = emp.id " +
                "WHERE EXTRACT(MONTH FROM sh.date) = @month " +
                "GROUP BY day";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@month", date.Month.ToString());
            List<double> TotalSalaryPerMonths = new List<double>();
            List<double> counter = new List<double>();
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            for (int j = 0; j < days; j++)
            {
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
                        for (int i = 1; i < days + 1; i++)
                        {
                            if (i == day)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours * wage * 4);
                                counter[i - 1] += 1;
                            }
                        }
                    }
                    else if (conditionTotal == "Total hours worked")
                    {
                        for (int i = 1; i < days + 1; i++)
                        {
                            if (i == day)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours);
                                counter[i - 1] += 1;
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
        public List<double> GetOverallEmpStatTotalSalaryForWeek(int week, DateTime date, string conditionTotal, string conditionAvg)
        {
            string sqlStatement = "SELECT IFNULL((em.employeeID),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(DAY FROM sh.date) AS day " +
            "FROM `mb_shift_with_assigned_employee` as em " +
            "INNER JOIN `mb_shift` as sh " +
            "ON sh.id = em.shiftID " +
            "INNER JOIN `mb_employee`as emp " +
            "ON em.employeeID = emp.id " +
            "WHERE EXTRACT(MONTH FROM sh.date) = @month AND EXTRACT(WEEK FROM sh.date) = @week " +
            "GROUP BY day";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
            sqlCommand.Parameters.AddWithValue("@month", date.Month.ToString());
            sqlCommand.Parameters.AddWithValue("@week", week);
            List<double> TotalSalaryPerWeek = new List<double>();
            List<double> counter = new List<double>();
            for (int j = 0; j < 7; j++)
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
                    int day = Convert.ToInt32(reader["day"]);
                    double hours = Convert.ToDouble(reader["assignedHours"]);
                    double wage = Convert.ToDouble(reader["wage"]);
                    if (conditionTotal == "Total salary")
                    {
                        for (int i = 1; i < date.Day; i++)
                        {
                            if (i == day)
                            {
                                TotalSalaryPerWeek[i - 1] += (hours * wage * 4);
                                counter[i - 1] += 1;
                            }
                        }
                    }
                    else if (conditionTotal == "Total hours worked")
                    {
                        for (int i = 1; i < 8; i++)
                        {
                            if (i == day)
                            {
                                TotalSalaryPerWeek[i - 1] += (hours);
                                counter[i - 1] += 1;
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
                    for (int i = 0; i < 7; i++)
                    {
                        TotalSalaryPerWeek[i] /= counter[i];
                    }
                }
            }
            return TotalSalaryPerWeek;
        }
    }
}
