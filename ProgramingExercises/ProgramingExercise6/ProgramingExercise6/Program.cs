using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ProgramingExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
            // Then print the respective minimum and maximum values as a single line of two space-separated long integers.

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            List<decimal> list2 = new List<decimal>() { -4, 3, -9, 0, 4, 1 };
            List<int> list3 = new List<int>() {4,4,1,3};

            Result1 rslt = new Result1();
            rslt.MinMaxSum(list);
            Console.WriteLine("******************************************************");
            Result2 rslt2 = new Result2();
            rslt2.plusMinus(list2);
            Console.WriteLine("******************************************************");
            Result3 rslt3 = new Result3();
            Console.WriteLine(rslt3.birthdayCakeCandles(list3));
            Console.WriteLine("******************************************************");
            Result4 rslt4 = new Result4();
            Console.WriteLine(rslt4.timeConversion("07:05:45PM"));
            Console.WriteLine("******************************************************");
            Result5 rslt5 = new Result5();
            rslt5.staircase(4);
        }
        public class Result1
        {
            public void MinMaxSum(List<int> numbers)
            {
                long minnum = numbers[0];
                long maxnum = 0;
                long sum = 0;
                foreach (var item in numbers)
                {

                    if (item > maxnum)
                        maxnum = item;
                    else
                        maxnum = maxnum;
                    if (item > minnum)
                        minnum = minnum;
                    else
                        minnum = item;
                    sum += item;

                }
                long maxsum = sum - minnum;
                long minsum = sum - maxnum;
                Console.WriteLine($"Minimum Sum is : {minsum}");
                Console.WriteLine($"Maximum Sum is: {maxsum}");
            }
        }

        // 2 Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
        // Print the decimal value of each fraction on a new line with 6  places after the decimal.
        public class Result2
        {
            public void plusMinus(List<decimal> arr)
            {
                int positivenumcount = 0;
                int negativenumcount = 0;
                int zeronumcount = 0;
                foreach (var item in arr)
                {
                    if (item > 0)
                    {
                        positivenumcount++;
                    }
                    else if (item < 0)
                    {
                        negativenumcount++;
                    }
                    else
                    {
                        zeronumcount++;
                    }

                }
                decimal result1 = (decimal)positivenumcount / arr.Count;
                decimal result2 = (decimal)negativenumcount / arr.Count;
                decimal result3 = (decimal)zeronumcount / arr.Count;
                Console.WriteLine(result1.ToString("F6"));
                Console.WriteLine(result2.ToString("F6"));
                Console.WriteLine(result3.ToString("F6"));
            }
        }

            // 3 You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age.
            // They will only be able to blow out the tallest of the candles. Count how many candles are tallest.
            public class Result3
            {
                public int birthdayCakeCandles(List<int> candles)
                {
                    int check = 0;
                    int counter = 0;
                    foreach (var candle in candles)
                    {
                        if (candle>check)
                        {
                            check=candle;
                        }
                    }
                    foreach (var item in candles)
                    {
                        if (check==item)
                        {
                            counter++;
                        }
                    }
                    return counter;
                }
            }
        // Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

        public class Result4
        {
            public string timeConversion(string s)
            {
                DateTime dateTime = DateTime.Parse(s);
                return dateTime.ToString("HH:mm:ss");
            }
        }

        // Staircase detail This is a staircase of size n=4
        //   #
        //  ##
        // ###
        //####
        // Its base and height are both equal to n . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.
        // Write a program that prints a staircase of size n.

        public class Result5
        {
            public void staircase(int n)
            {
                int check1 = 0;
                int check2 = n;
                for (int i = 0;i<n;n--)
                {
                    check1 = n-1;
                    for (int j = 1; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                    while (check2>check1)
                    {
                        Console.Write("#");
                        check1++;
                    }
                    Console.WriteLine("");

                }
            }
        }
    }
}


