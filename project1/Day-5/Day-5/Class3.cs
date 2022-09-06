using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    //example
    class Class3
    {
        public static void Main4(string[] args)
        {
            int n = 3;
            Person[] persons = new Person[n];
            Console.WriteLine("Enter Name of a person: ");
            for (int i = 0; i < n; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
    public class Person
    {
       public string Name { get; set; }

       public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello! I am " + Name;
        }

        ~Person()
        {
            Name = string.Empty;
        }
    }
}