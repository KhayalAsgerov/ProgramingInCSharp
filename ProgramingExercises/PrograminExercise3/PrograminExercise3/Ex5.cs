using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise3
{
    
    internal class Ex5
    {
        public void FindLastDayOfWeek()
        {
            Console.WriteLine("Input the day");
            int day=int.Parse(Console.ReadLine());
            Console.WriteLine("Input the month");
            int month=int.Parse(Console.ReadLine());
            Console.WriteLine("Input the year");
            int year=int.Parse(Console.ReadLine());
            DateTime inputdate =DateTime.Parse(day+"/"+month+"/"+year);

           DayOfWeek inputdayofweek =inputdate.DayOfWeek;
            switch ((int)inputdayofweek)
            {
                case 1:
                    Console.WriteLine(inputdate.AddDays(6));
                    break;
                case 2:
                    Console.WriteLine(inputdate.AddDays(5));
                    break;
                case 3:
                    Console.WriteLine(inputdate.AddDays(4));
                    break;
                case 4:
                    Console.WriteLine(inputdate.AddDays(3));
                    break;
                case 5:
                    Console.WriteLine(inputdate.AddDays(2));
                    break;
                case 6:
                    Console.WriteLine(inputdate.AddDays(1));
                    break;
                case 0:
                    Console.WriteLine(inputdate);
                    break;
            }
        }
        
    }
}
