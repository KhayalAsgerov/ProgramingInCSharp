namespace PrograminExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# to display the first 10 natural numbers
            new Ex1();
            Console.WriteLine(" ");

            // Write a C# program to find the sum of first 20 odd natural numbers.
            Ex2 ex2 = new Ex2();
            Console.WriteLine(ex2.SumfirstTwentyOddNum());

            // Write a program in C# to read 5 numbers from keyboard and find their sum and average.

            Ex3 ex3 = new Ex3();
            Console.WriteLine(ex3.SumAndAvarageOfGivenNums(1, 2, 3, 4, 5));

            // Write a program in C# to display the multiplication table vertically from 1 to n.
            Ex4 ex4 = new Ex4();
            ex4.MultiplicationTable();

            // Write a program in C# to display the pattern like right angle triangle using an asterisk.
            new Ex5();

            // Write a program in C# to make such a pattern like right angle triangle with number increased by 1.
            new Ex6();

            // Write a C# program to find prime numbers up to users entered value.
            Ex7 ex7 = new Ex7();
           var result= ex7.FindPrimeNums(200);
            foreach (var item in result) { Console.WriteLine(item); }

            // Write a program in C# to check whether a number can be express as sum of two prime numbers.
            Ex8 ex8 = new Ex8();
            int p =ex8.IsExpressSumOfTwoNums(20);
            if (p!=0)
            {
                Console.WriteLine("yes");
            }
            else
            { Console.WriteLine("no"); }

            // Write a program in C# to check whether a number is a palindrome (visual simmetric) or not.
            Ex9 ex9 = new Ex9();
            Console.WriteLine(ex9.IsPolindrom(232));

        }

    }
}
