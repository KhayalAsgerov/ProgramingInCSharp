using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex3
    {
        public string SumAndAvarageOfGivenNums(params int[] nums)
        {
            int sum= 0;
            int average=0;
            if (nums.Length>5)
            {
                Console.WriteLine("Input 5 numbers");
            }
            else
            {
                foreach (int num in nums)
                {
                    sum+= num;
                }
            }

            return ($"Sum of numbers = {sum} Average of numbers = {sum/5}");
        }
           
    }
}
