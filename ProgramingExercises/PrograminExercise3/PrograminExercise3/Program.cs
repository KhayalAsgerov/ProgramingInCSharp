using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrograminExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# that calculates the day of week (ex: Monday) of your birthday
            Ex1 ex1 = new Ex1();
            Console.WriteLine(ex1.BirtdayAsWeekday("06 19 1997"));

            // Write a C# that calculates you current life days (how many days past since your birth)
            Ex2 ex2 = new Ex2();
            Console.WriteLine(ex2.DaysBetweenBirthAndNow("06  19 1997"));

            // Write a C# program to calculate what day of the week is after 40 days from this moment
            Ex3 ex3 = new Ex3();
            Console.WriteLine(ex3.ForthyDaysAfter());

            //Write a program in C# to check whether the given year, month and day are the current or not. Test Data :
            // Input the Day: 17
            //Input the Month: 09
            //Input the Year: 2016
            //Expected Output :
            //The formatted Date is : 17 / 09 / 2016 The current date status : True

            Ex4 ex4 = new Ex4();
            Console.WriteLine(ex4.CheckDateTimeNow(10, 3, 2023));

            // Write a program in C# Sharp to find the last day of a week against a given date. Test Data:
            // Input the Day: 16
            // Input the Month: 06
            // Input the Year: 2016
            // Expected Output :
            // The formatted Date is : 16 / 06 / 2016 The last day of the week for the above date is: 18 / 06 / 2016

            Ex5 ex5 = new();
            // ex5.FindLastDayOfWeek();

            // Write a C# Sharp program to find the largest of three numbers.
            Console.WriteLine(new Ex6(3, 4, 5));
            Console.WriteLine(new Ex6(6, 4, 5));
            Console.WriteLine(new Ex6(8, 4, 3));
            Console.WriteLine(new Ex6(8, 20, 3));

            // Write a program in C# Sharp to read any day number in integer and display day name in the word.
            // Test Data : 4 Expected Output : Thursday
            Ex7 ex7 = new Ex7();
            ex7.WeekDay(7);

            // Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
            //Test Date and Expected Output
            //Enter the first Integer: 10
            //Enter the second Integer :2

           // Here are the options :
           //1 - Addition.
           //2 - Substraction.
          //3 - Multiplication.
          //4 - Division.
          //5 - Exit.

         //Input your choice: 3
         //The Multiplication of 10 and 2 is: 20

            Ex8 ex8 = new Ex8();
            ex8.GetNums();
            int k =ex8.GetOperation();
            if (k == 1)
                ex8.Addition();
             if (k == 2) ex8.Subtraction();
            if (k == 3) ex8.Multiplication();
             if (k == 4) ex8.Division();
            else
                return;
        }
    }
}
