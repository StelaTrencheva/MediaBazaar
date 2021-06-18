using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class WeekSchedule
    {
        private int weekNumber;
        private Dictionary<DateTime, List<Shift>> datesWithShifts;
        private Department department;
        private EmployeeInScheduleManager employeesInScheduleManager;
        public int WeekNumber
        {
            get { return this.weekNumber; }
        }
        public DateTime WeekStartDate
        {
            get { return this.datesWithShifts.Keys.First(); }
        }
        public DateTime WeekEndDate
        {
            get { return this.datesWithShifts.Keys.Last(); }
        }
        public Department Department
        {
            get { return this.department; }
        }
        public EmployeeInScheduleManager EmployeesInScheduleManager
        {
            get { return this.employeesInScheduleManager; }
        }
        public WeekSchedule(DateTime selectedDate,Department department)
        {
            this.weekNumber = GetWeekNumber(selectedDate);
            this.department = department;
            this.employeesInScheduleManager = new EmployeeInScheduleManager(department,this.weekNumber);
            DateTime startDate = selectedDate;
            DateTime endDate = startDate.AddDays(7);
            datesWithShifts = new Dictionary<DateTime, List<Shift>>();
            for (DateTime i = startDate; i > selectedDate.AddDays(-7); i = i.AddDays(-1))
            {
                if (GetWeekNumber(i.AddDays(-1)) != weekNumber)
                {
                    startDate = i;
                    endDate = startDate.AddDays(6);
                    break;
                }
            }
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                datesWithShifts.Add(i, new List<Shift>());
                for (int j = 0; j < 4; j++)
                {
                    datesWithShifts[i].Add(new Shift((ShiftType)j, i, new List<Employee>()));
                }

            }
        }
        private int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

        }

    }
}
