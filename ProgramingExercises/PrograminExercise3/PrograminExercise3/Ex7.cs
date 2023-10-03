using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum DayOfWeekEnum1
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}
namespace PrograminExercise3
{
   

    internal class Ex7
    {
      
        public void WeekDay(int num)
        {
            while (true) 
            {
                if (num < 1 && num > 7)
                {
                    Console.WriteLine("Input number between 1-7");
                    continue;
                }
                else
                {
                    Console.WriteLine((DayOfWeekEnum1)num);
                    break;
                }
            }
           
             }
    }
}
