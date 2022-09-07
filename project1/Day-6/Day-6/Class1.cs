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
    }
    class Student : Person
    {
        public Student(string Name) : base(Name)
        {
            name = Name;
        }
        public void study()
        {
            Console.WriteLine("Student is studying: ");
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
            Console.WriteLine("Teacher is explaining");
        }
    }
    class Class1
    {
        public static void main()
        {
            int n = 3;
            Person[] persons = new Person[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
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
