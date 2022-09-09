using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string Gender;
        public int Salary;
       public Employee(int Id,string Name,string Gender,int Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary =Salary ;
        }
        public int getId()
        {
            return Id;
        }
        public string getName()
        {
            return Name;
        }
        public string getGender()
        {
            return Gender;
        }
        public int getSalary()
        {
            return Salary;
        }
        public string tostring()
        {
            return Id + " " + Name + " " + Gender + " " + Salary;
        }
    }
    class Class3
    {
        public static void Main()
        {
            List<Employee> l = new List<Employee>();
            int choice;
           
                Console.WriteLine("Enter your choice: \nAdd ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter how many details you want to enter");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Employee Details: ");
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine("Enter employee ID: ");
                            int eid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter employee name: ");
                            string enm = Console.ReadLine();
                            Console.WriteLine("Enter employee gender: ");
                            string gen = Console.ReadLine();
                            Console.WriteLine("Enter employee salary: ");
                            int esal = Convert.ToInt32(Console.ReadLine());
                            l.Add(new Employee(eid, enm, gen, esal));
                        }
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            
            
        }
    }
}
