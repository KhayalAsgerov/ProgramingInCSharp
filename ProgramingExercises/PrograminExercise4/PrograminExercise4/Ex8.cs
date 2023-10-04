using PrograminExercise4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex8
    {
        Ex7 exm = new Ex7();
        
        public int IsExpressSumOfTwoNums(int num)
        {
            int counter = 0;
             var k =exm.FindPrimeNums(num);
            for (int i = 0; i < k.Count; i++)
            {
                for (int j =i+1; j < k.Count-1; j++)
                {
                    if (k[i] + k[j]==num)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
