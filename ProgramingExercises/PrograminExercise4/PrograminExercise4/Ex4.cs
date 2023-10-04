using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex4
    {
        public void MultiplicationTable()
        { 
        
        for (int i = 1; i < 9; i++) 
            {
            for(int j = 1; j < 9; j++)
                {
                    Console.Write($"{j}x{i}={i*j} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
