using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise3
{
    internal class Ex4
    {
        public bool CheckDateTimeNow(int day, int mont, int year)
        {
          DateTime input=DateTime.Parse(String.Format("{0}/{1}/{2}",day,mont,year));
            if (input==DateTime.Today)
            {
                return true;
            }
            else
                return false;
        }
    }
}
