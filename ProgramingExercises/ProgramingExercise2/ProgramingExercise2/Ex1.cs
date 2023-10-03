using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingExercise2
{
    internal class Ex1
    {
        public bool BothEvorOd(int num1, int num2)
        {
            if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 2 == 1 && num2 % 2 == 1)
                return true;
            else
                return false;
        }
    }
}
