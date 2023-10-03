using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrograminExercise3
{
    internal class Ex8
    {
        public int num1;
        public int num2;
        public void GetNums()
        {
            Console.WriteLine("Input first integer");
             num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer");
             num2=int.Parse(Console.ReadLine());
        }
        public int GetOperation()
        {
            Console.WriteLine(@"Here are the options :
           1 - Addition.
           2 - Substraction.
           3 - Multiplication.
           4 - Division.
           5 - Exit.
           Input Your Operation");
            int opnum=int.Parse(Console.ReadLine());
          return opnum;
        }
        public void Addition()
        {
           
            Console.WriteLine("Sum of your numbers s "+(num1+num2));
        }
        public void Subtraction()
        {
           
            Console.WriteLine("Subtraction of your numbers s " + (num1 - num2));
        }
        public void Multiplication()
        {
          
            Console.WriteLine("Multiplication of your numbers s " + (num1 * num2));
        }
        public void Division()
        {
           
            Console.WriteLine("Division of your numbers s " + (num1 / num2));
        }
    }
}
