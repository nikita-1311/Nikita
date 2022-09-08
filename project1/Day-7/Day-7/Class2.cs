using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    //struct datatype
    struct Employee
    {
        public int employeeId;
        public string employeeName;
        public int employeesal;
    };
    class Class2
    {
        public static void Main3()
        {
            Employee e;
            Console.WriteLine("Please enter employee Name: ");
            e.employeeName = Console.ReadLine();
            Console.WriteLine("Please enter employee ID: ");
            e.employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Empolyee salary: ");
            e.employeesal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Details are :");
            Console.WriteLine("EmployeeID : {0} \nEmployee Name: {1} \nEmployee Salary: {2}", e.employeeId, e.employeeName,e.employeesal);
        }
    }
}
