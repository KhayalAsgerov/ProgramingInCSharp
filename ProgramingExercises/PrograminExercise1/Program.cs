using System.ComponentModel;
using System.Threading.Channels;

namespace FirstPrograminLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson1 
           // ex1
            // Write a C# program that takes three letters as input and display them in reverse order.
            Ex1 ex1 = new Ex1();
            Console.WriteLine(ex1.ReversedChars('A','B','C'));
            //ex2
            // Write a C# program that takes 2 inputs form user respectively name and surname,
            // and then print it as "NAME SURNAME" (both uppercase) in console
            Ex2 ex2 = new Ex2();
            Console.WriteLine(ex2.NameSurnameUpper("Arif","Samedov"));

            //ex3 
            //Write a C# program that takes the radius of a circle 
            //as input and calculate the perimeter and area of the circle and print it in console
            Ex3 ex3 = new Ex3();
            ex3.CirclePerimetr(5);
            ex3.CircleArea(5);
            string s = "rr";
            
            while(true)
            {
                int.TryParse(Console.ReadLine(), out int result);
                if (result == 0)
                {
                    Console.WriteLine("Please input number type int");
                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }
           
            #endregion



        }

    }
}
