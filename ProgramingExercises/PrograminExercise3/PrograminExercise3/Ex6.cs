using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise3
{
    internal class Ex6
    {
        public Ex6(int num1,int num2,int num3)
        {
            if (num1 >= num2 && num1 >= num3) { Console.WriteLine("Biggest num s " + num1); }
           else if (num2 >= num1 && num2 >= num3) { Console.WriteLine("Biggest num s " + num2); }
            else
            { Console.WriteLine("Biggest num s " + num3); }
        
        }
    }
}
