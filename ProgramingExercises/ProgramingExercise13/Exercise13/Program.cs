using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Threading.Tasks;
using System;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate all files and directories count in a given directory(including files and folder in any subdirectory)
            var myDesktopPath = @"C:\Users\User\Desktop\turan";
            var directoryInfo = new DirectoryInfo(myDesktopPath);
            FileInfo[] files = directoryInfo.GetFiles();
            int counter = 0;
            foreach (FileInfo file in files) { counter++; }

            Console.WriteLine(counter);

            // Create a C# program that implements an IVehicle interface with two methods, one for Drive of type void
            // and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel.
            // Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements
            // the Drive and Refuel methods of the IVehicle.
            //The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0.The Refuel method
            //will increase the gasoline of the car and return true.To carry out the tests, create an object of type Car with 0 of
            //gasoline in the Main of the program and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.
            //Input
            //50
            //Output
            //Driving
            Console.WriteLine("Enter the amount of gasoline to refuel");
            int refuelAmount=int.Parse(Console.ReadLine());
            Car car = new Car(0);
            car.Refuel(30);
            car.Drive();
        }
        interface IVhecile
        {
            void Drive();
            bool Refuel(int amount);
            int gasoline { get; set; }
        }

        class Car : IVhecile
        {
            public Car(int InitialGasoline)
            {
                this.gasoline = gasoline;
            }

            public int gasoline { get; set; }

            public void Drive()
            {
                if (gasoline>0)
                {
                    Console.WriteLine("Car is driving");
                }
                else
                {
                    Console.WriteLine("No gasoline, cannot drive!");
                }

            }
            public bool Refuel(int amount)
            {
                if (amount > 0)
                {
                    gasoline += amount;
                    return true;
                }
                return false;
            }
        }
    }
}
