using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProgramingExercise2
{
    internal class Ex2
    {
        public bool CheckTwoInputNes()
        {
            Console.WriteLine("Input first text");
           string text1=Console.ReadLine();
            Console.WriteLine("Input second text");
            string text2=Console.ReadLine();
            if (text1.Contains(text2)) 
                return true;
            else return false;
        }
    }
}
