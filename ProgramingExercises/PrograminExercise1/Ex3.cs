using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrograminLesson
{
    internal class Ex3
    {
        double pi = 3.16;
        public void CirclePerimetr(double r)
        {
            double circPer=2*pi*r;
            Console.WriteLine($"Perimeter of Circle = {circPer}");
        }
        public void CircleArea(double r)
        {
            double circArea =pi* r*r;
            Console.WriteLine($"Area of Circle = {circArea}");
        }
    }
}
