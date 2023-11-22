using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgramingExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person.
            // To do this, first create a Person class that has a Name property of type string and override the ToString() method.

            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            // 2 Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following
            // classes:

            //Persons
            //Student
            //Teacher
            //The Student and Teacher classes inherit from the Person class.

            //The Student class will include a public Study() method that will write I'm studying on the screen.

            //The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

            //The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

            //Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.
                  //Create a new Person and make him say hello
                 //Create a new Student, set an age, say hello, and display her age on the screen.
                //Create a new Teacher, set an age, say hello and start the explanation.
            Persons persons1 = new Persons();
            persons1.Greet();
            Students students1 = new Students();
            students1.Greet();
            students1.SetAge(18);
            students1.ShowAge();
            students1.Study();
            Teacher teacher1 = new Teacher();
            teacher1.Greet();
            teacher1.Explain();

            // 3 Create a C# program to manage a photo book using object-oriented programming.
            //To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return
            //the number of photo book pages.
            //The default constructor will create an album with 16 pages.There will be an additional constructor, with which we can specify the number of pages we want
            //in the album.
            // There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

           // Finally create a PhotoBookTest class to perform the following actions:
               //Create a default photo book and show the number of pages
               //Create a photo book with 24 pages and show the number of pages
               //Create a large photo book and show the number of pages
               PhotoBookTest test= new PhotoBookTest();
            test.Test();

            // 4 Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. There will be two people of the
            // Student type and one person of the Teacher type.
            //To do this, create a Person class that has a Name property of type string, a constructor that receives the name as a parameter
            //and overrides the ToString() method
            //Then create two more classes that inherit from the Person class, they will be called Student and Teacher.The Student class has a Study method that
            //writes by console that the student is studying.The Teacher class will have an Explain method that writes to the console that the teacher is explaining.
            //Remember to also create two constructors on the child classes that call the parent constructor of the Person class.
            //End the program by reading the people(the teacher and the students) and execute the Explain and Study methods.
            Teachers teacher = new Teachers("Akif");
            teacher.Explain();
            Student student1 = new Student("Rauf");
            student1.Study();
            Student student2 = new Student("Lala");
            student1.Study();


        }
    }

        public class Person
        {

        public string Name { get; set; }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
        }
    public class Persons
    {
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {  
            Age = age;
        }
    }
    public class Students : Persons
    {
        public void Study()
        {
            Console.WriteLine("I m Studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My Age is {Age} years old");
        }
    }
    public class Teacher : Persons
    {
        public void Explain()
        {
            Console.WriteLine("I m Explaining");
        }
    }
    public class PhotoBook
    {
        private int numPages;
        public int GetNumPages()
        {
        return numPages;
        }
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int k)
        {
            numPages = k;
        }
    }
    public class BigPhotoBook
    {
        public int numPages;
        public BigPhotoBook() 
        {
            numPages = 64;
        }
    }
    public class PhotoBookTest
    {
        public void Test()
        { 
        PhotoBook book = new PhotoBook();
            Console.WriteLine(book.GetNumPages());
            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine(book2.GetNumPages());
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.numPages);
        }
    }

    public class Persons1 
    {
        public string Name { get; set; }
        public Persons1(string name) 
        {
        Name = name;
            
        }
        public override string ToString()
        {
             return "Hello! My name is " + Name;
        }
        ~Persons1()
        {
            Name = string.Empty;
        }
    }
    public class Student : Persons1
    {
        public Student(string name) : base(name)
        {
        }
        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }
    public class Teachers : Persons1
    {
        public Teachers(string name) : base(name)
        {
        }
        public void Explain()
        {
            Console.WriteLine("The theacher is explaining");
        }
    }
}
    

