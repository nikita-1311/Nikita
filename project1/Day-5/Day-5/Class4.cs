using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    //example 2
    class Class4
    {
        public static void Main()
        {
            Person Person = new Person();
            Person.Greet();

            Student Student = new Student();
            Student.SetAge(21);
            Student.Greet();
            Student.ShowAge();
            Student.Study();

            Teacher Teacher = new Teacher();
            Teacher.SetAge(30);
            Teacher.Greet();
            Teacher.ShowAge();
            Teacher.Explain();
        }
        class Person
        {
           public int age;

           public void Greet()
           {
               Console.WriteLine("Hello!");
           }

            public void SetAge(int n)
            {
               age = n;
            }
        }
        class Student:Person
        {
           public void Study()
           {
             Console.WriteLine("I'm studying");
           }

           public void ShowAge()
           {
             Console.WriteLine("My age is {0} years old", age);
           }
        }
        class Teacher:Person
        {
           public void Explain()
           {
             Console.WriteLine("I'm explaining");
           }
           public void ShowAge()
           {
             Console.WriteLine("My age is {0} years old", age);
           }
        }
    }
}
