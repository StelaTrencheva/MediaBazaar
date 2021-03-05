using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Week
    {
        private int weekNumber;
        List<Day> days;
        public int WeekNumber
        {
            get { return this.weekNumber; }
        }
        public Week(int weekNumber)
        {
            this.weekNumber = weekNumber;
            days = new List<Day>();
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day((DayOfWeek)i));
            }
        }
        public Day GetDay(DayOfWeek day)
        {
            foreach (Day d in days)
            {
                if (d.DayOfTheWeek == day)
                {
                    return d;
                }
            }
            return null;
        }
    }
}
