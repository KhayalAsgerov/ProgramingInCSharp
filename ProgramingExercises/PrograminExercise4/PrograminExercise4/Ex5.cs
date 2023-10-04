using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex5
    {
        public Ex5() 
        {
            string sign = "*";
            for(int i = 0; i < 6; i++) 
            {
                for (int j = 0; j <= i; j++)
                { Console.Write($"{sign}"); }
                Console.WriteLine("");
            }
        }
    }
}
