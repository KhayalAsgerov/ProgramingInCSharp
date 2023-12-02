namespace ProgramingExercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Write a program in C# Sharp to create and read the last line of a file.
            //Test Data:
            //Input number of lines to write in the file :3
            //Input 3 strings below :
            //Input line 1 : line1
            //Input line 2 : line2
            //Input line 3 : line3
            //Expected Output:
            //The content of the last line of the file mytest.txt is: line3

            Console.WriteLine("Input number of lines to write in the file:");
int lineNumber = int.Parse(Console.ReadLine());
string[] lines = new string[lineNumber];
for (int i = 0; i < lineNumber; i++)
{
    Console.WriteLine($"Input line {i + 1} :");
    lines[i] = Console.ReadLine();
}
string filePath = @"C:\Users\User\Desktop\myFile.txt"; 
File.WriteAllLines(filePath, lines);
        }
    }
}
