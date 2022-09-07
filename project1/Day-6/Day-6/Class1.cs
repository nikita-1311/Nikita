using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class  Person
    {
        public string name { get; set; }
        public Person(string Name)
        {
            name = Name;
        }
        public override string ToString()
        {
            return "My name is " + name;
        }
        ~Person()
        {
            name = string.Empty;
        }
    }
    class Student : Person
    {
        public Student(string Name) : base(Name)
        {
            name = Name;
        }
        public void study()
        {
            Console.WriteLine("Student is studying! ");
        }
    }
    class Teacher:Person
    {
        public Teacher(string Name) : base(Name)
        {
            name = Name;
        }
        public void explain()
        {
            Console.WriteLine("Teacher is explaining!");
        }
    }
    class Class1
    {
        public static void Main2()
        {
            int n = 3;
            Person[] persons = new Person[n];
            Console.WriteLine("Enter the names: ");
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Name of the teacher: ");
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Name of the student: ");
                    persons[i] = new Student(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).explain();

                }
                else
                {
                    ((Student)persons[i]).study();
                }
            }
        }
    }
}
