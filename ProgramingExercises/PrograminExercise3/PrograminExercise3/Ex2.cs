using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise3
{
    internal class Ex2
    {
        DateTime date;
        TimeSpan duration;
        public int DaysBetweenBirthAndNow(string birtday)
        {
            date = DateTime.Parse(birtday);
            duration= DateTime.Now - date;
            return duration.Days;
        }
    }
}
