using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex9
    {
        public bool IsPolindrom(int num)
        {
            string num1 = num.ToString();
            char[] num1Array = num1.ToCharArray();
            Array.Reverse(num1Array);
            string num2 = new string(num1Array);
            if (num2 == num1)
                return true;
            else
                return false;
        }
    }
}
