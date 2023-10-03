namespace ProgramingExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd
            Ex1 ex1 = new Ex1();
            Console.WriteLine(ex1.BothEvorOd(5, 3));

            // C# program which takes 2 string input from user and return if second string is in first string.
            // Example. 1st input: Azərbaycan, 2nd input: can, Result should be true because can is in Azərbaycan
            Ex2 ex2 = new Ex2();
            Console.WriteLine(ex2.CheckTwoInputNes());

            // Get 2 int number input from user and calculate the exact input1 / input2. Example: 16, 5. Result should be 3.2 not 3.
            new Ex3(16,5);

         
        }
    }
}
