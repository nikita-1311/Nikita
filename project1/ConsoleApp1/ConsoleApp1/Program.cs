using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Person
    {
        public string name;
        public string address;
        public int age;
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    public class PersonImplementation : Person
    {
        public double Average(List<Person> person)
        {
           double avg=person.Average();
        }
        public int Max(List<Person> person)
        {
            return person.Max();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonImplementation s = new PersonImplementation();
            List<Person> p = new List<Person>();
            p.Add(new Person { Name = "Nikita", Address = "A2101", Age = 50 });
            s.Average();
            s.Max();
        }
    }
}
