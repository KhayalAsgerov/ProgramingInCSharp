using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise5
{
    internal class EX4
    {
        public void Fibonacci()
        {
            Console.WriteLine("Input the number of Fibonacci series");
            int num=int.Parse(Console.ReadLine());
            int first = 0, second = 1;

            for (int i = 0; i < num; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
