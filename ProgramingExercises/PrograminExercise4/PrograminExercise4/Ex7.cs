using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PrograminExercise4
{
    public class Ex7
    {
        List<int> primes = new List<int>();
        public List<int> FindPrimeNums(int num)
        {
            int check;
            for (int i = 2; i < num; i++)
            {
                check = CountOfFactors(i);
                if (check <= 2)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
        public int CountOfFactors(int k)
        {
            int counter = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i ==0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }

}
