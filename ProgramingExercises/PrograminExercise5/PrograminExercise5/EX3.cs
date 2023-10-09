using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise5
{
    internal class EX3
    {
       public  void SwapNumbersWithoutVariable(ref int a, ref int b)
        {
            // Use arithmetic operations to swap the values
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
