using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Schedule
    {
        private List<Week> weeks;
        public Schedule(int currentWeek)
        {
            weeks = new List<Week>();
            for (int i = currentWeek; i <= currentWeek+10; i++)
            {
                weeks.Add(new Week(i));
            }
        }
        public Week GetWeek(int week)
        {
            foreach (Week w in weeks)
            {
                if (week == w.WeekNumber)
                {
                    return w;
                }
            }
            return null;
        }
       public Shift GetShift(int week, DayOfWeek day,ShiftType shift)
        {
            Week foundWeek = GetWeek(week);
            Day foundDay = foundWeek.GetDay(day);
            Shift foundShift = foundDay.GetShift(shift);
            return foundShift;
                
       }
    }
}
