using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex2
    {
        public int SumfirstTwentyOddNum()
        {
            int counter = 0;
            int k = 1;
            int sum = 0;
            while (k%2==1) 
            {
              
                counter++;
                if (counter < 21)
                {
                    sum += k;
                }
                else
                    break;
                k += 2;
            }
            return sum;
        }
    }
}
