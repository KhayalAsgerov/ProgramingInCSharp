using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrograminExercise5
{
    internal class EX5
    {
        public int SpaceCount(string text)
        { 
       string[] text1=text.Split(' ');
            return text1.Length - 1;
        }
    }
}
