using System.ComponentModel;
using System;
using System.Data.Common;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace ProgramingExercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a SchoolPerson class that has SchoolName, Name, Surname, Age and DateOfBirth, CurrentClass properties.
            // Also this class will have a general Greet method, which will show us "Hello {Name Surname}"
            // Create a class "Student" and another class "Teacher", both descendants of "SchoolPerson" class. "SchoolPerson" will have a method calles "GoToClasses" and
            // when calling this method it will show us "Inside Base GoToClasses method"
            //The class "Student" will also have a public method "GoToClasses", which will write on screen "I’m {name surname}, I am student and I'm going to class."

            //The class "Teacher" will have a public method "Explain", which will show on screen "Explanation begin on subject {subject}". Also, it will have a private
            //attribute "subject", a string which indicates his/her speciality.Also "Teacher" will have a public method "GoToClasses", which will write on
            //screen "I’m {name surname}, I am a teacher."

            //The class SchoolPerson must have a functionality to set of their age(eg, 20 years old). Note: Age cannot be less than 6 and more than 50.
            //If we try to assign invalid number exception should be thrown.

            //The student will have a public method "ShowAge" which will write on the screen "My age is: 20 years old" (or the corresponding number).
            //You must create another test class called "StudentAndTeacherTest" that will contain "Main" and:
            //Create a SchoolPerson and make it say hello
            //Create a student, set his age to 21, tell him to Greet, display his age and make him to go classes
            //Create a teacher, set age to 30 years old, ask him to say hello, then go to classes and then explain.

            SchoolPerson person = new SchoolPerson();
            person.Greet("Elgiz","Aliyev");
            Student student = new Student();
            student.Greet("Azer","Aliyev");
            student.ShowAge(26);
            Teacher teacher = new Teacher();
            teacher.Greet("Aygun","Huseynova");
            teacher.ShowAge(30);
            teacher.Explain("Geography");
        }
        public class SchoolPerson
        {
            public string SchoolName { get; set; }
            public string Name { get; set; }
            public string SurnameName { get; set; }
            public int Age { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string CurrentClass { get; set; }
            public virtual void Greet(string name, string surname)
            {
                Name = name;
                SurnameName = surname;
                Console.WriteLine($"HELLO {Name} {SurnameName}");
            }
            
            public void GoToClasses()
            { }
        }
        public class Student : SchoolPerson
        {
            public override void Greet(string name, string surname)
            {
                Console.WriteLine($"I’m {name} {surname}, I am student and I'm going to class.");
            }
            public void ShowAge(int age)
            {
                if (age < 6 && age > 50)
                {
                    Console.WriteLine("Pleae input age more than 6 less than 50");
                }
                Console.WriteLine($"My age is: {age} years old");
            }
        }
        public class Teacher : SchoolPerson
        {
            public void ShowAge(int age)
            {
                if (age < 6 && age > 50)
                {
                    Console.WriteLine("Pleae input age more than 6 less than 50");
                }
                Console.WriteLine($"My age is: {age} years old");
            }
            private string Subject { get; set; }
            public void Explain(string subject)
            {
                Console.WriteLine($"Explanation begin on subject {subject}");
            }
            public override void Greet(string name, string surname)
            {
                Console.WriteLine($"I’m {name} {surname}, I am teacher ");
            }
        }
       
    }
}
