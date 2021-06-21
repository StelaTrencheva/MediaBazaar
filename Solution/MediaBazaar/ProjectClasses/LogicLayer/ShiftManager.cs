using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class ShiftManager
    {
        private DBMediatorShifts dbMediator;
        public ShiftManager()
        {
            dbMediator = new DBMediatorShifts();
        }

        //AutomaticSchedule
        public WeekSchedule CreateWeekSchedule(DateTime date,Department department)
        {
            WeekSchedule newSchedule = new WeekSchedule(date,department);
            return newSchedule;
        }
    }
}
