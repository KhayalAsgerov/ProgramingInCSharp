using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise4
{
    internal class Ex1
    {
        public Ex1 () 
        { 
        for (int i = 0; i < 11; i++) 
            if (i == 10)
            { Console.Write(i); }
        else { Console.Write(i + ", "); }
        }
    }
}
