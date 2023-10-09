using System.ComponentModel;

namespace PrograminExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# sort array both descending and ascending order
            // descending order
            EX1 eX1 = new EX1();
          var ex2 =  eX1.SortedAscendingOrder(3, 2, 5, 9);
          var ex3 =  eX1.SortedDescendingOrder(3, 2, 5, 9);
            foreach (var item in ex3) { Console.Write(item+" "); }
            Console.WriteLine("");
            foreach (var item in ex2) { Console.Write(item+" "); }
            Console.WriteLine();
            // Write a C# program to find the 3 max element of array.
            EX2 ex4 = new EX2();
           var result=ex4.MaxTreeValue(0, 78, 5, 46, 21);
            foreach (var item in result)
            {
                Console.Write(item);
            }

            //Write a program in C# to create a function to swap the values of two integer numbers without additional variable. Test Data :
            //Enter a number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            EX3 ex5 = new EX3();
            ex5.SwapNumbersWithoutVariable(ref num1, ref num2);

            Console.WriteLine("Now the 1st number is: " + num1 + ", and the 2nd number is: " + num2);
            // Write a program in C# to create a function to display the n number Fibonacci sequence.
            // Test Data : Input number of Fibonacci Series : 5 Expected Output : The Fibonacci series of 5 numbers is : 0 1 1 2 3 5 8
            EX4 ex6 = new EX4();
            ex6.Fibonacci();
            Console.WriteLine();
            //Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. Test Data :
            //Please input a string : This is a test string. Expected Output : "This is a test string." contains 4 spaces
            EX5 ex7 = new EX5();
            Console.WriteLine(ex7.SpaceCount("Hello World"));
        }
    }
}

