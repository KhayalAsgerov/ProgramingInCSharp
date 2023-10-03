using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise3
{
    internal class Ex3
    {
        public DayOfWeek ForthyDaysAfter()
        {
            DateTime date=DateTime.Now;
            date.AddDays(40);
            return date.DayOfWeek;
        }
    }
}
