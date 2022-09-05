using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class7
    {
        class Employee
        {
            //employee details using class
            int EmpID,EmpSalary;
            string EmpName;
            public void GetData()
            {
                Console.WriteLine("Please enter the employee id: ");
                EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter employee name");
                EmpName = Console.ReadLine();
                Console.WriteLine("Please enter your salary: ");
                EmpSalary = Convert.ToInt32(Console.ReadLine());
            }
            public void PrintData()
            {
                Console.WriteLine("Employee Details are:");
                Console.WriteLine("Employee Id : " + EmpID);
                Console.WriteLine("Employee Name : " + EmpName);
                Console.WriteLine("Employee Salary:" + EmpSalary);
            }
        }
        class Class4
        {
            public static void Main()
            {
                //<class Name> objectname =new //();
                Employee emp = new Employee();
                emp.GetData();
                emp.PrintData();
            }
        }
    }
}
