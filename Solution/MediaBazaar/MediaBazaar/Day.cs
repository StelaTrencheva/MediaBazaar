using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Day
    {
        private DayOfWeek dayOfTheWeek;
        List<Shift> shifts;
        public DayOfWeek DayOfTheWeek
        {
            get { return this.dayOfTheWeek; }
        }
        public Day(DayOfWeek day)
        {
            this.dayOfTheWeek = day;
            shifts = new List<Shift>();
            for (int i = 0; i < 4; i++)
            {
                shifts.Add(new Shift((ShiftType)i));
            }
            
        }
        public Shift GetShift(ShiftType shift)
        {
            foreach (Shift s in shifts)
            {
                if (s.Type == shift)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
