using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise3
{
    internal class Ex1
    {
        DateTime date;
        public DayOfWeek BirtdayAsWeekday(string birtday)
        {
            date =DateTime.Parse(birtday);
            return date.DayOfWeek;
        }
    }
}
