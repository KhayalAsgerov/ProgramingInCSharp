using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex6
    {
        public Ex6()
        {
            int k = 1;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine("");
            }
        }
    }
}
