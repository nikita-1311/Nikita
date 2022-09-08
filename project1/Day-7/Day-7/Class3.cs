using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    //struct using function
    struct EmployeeN
    {
        public int employeeId;
        public string employeeName;
        public int employeesal;
        public void GetData()
        {
            Console.WriteLine("Please enter employee Name: ");
            employeeName = Console.ReadLine();
            Console.WriteLine("Please enter employee ID: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Empolyee salary: ");
            employeesal = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Employee Details are :");
            Console.WriteLine("EmployeeID : {0} \nEmployee Name: {1} \nEmployee Salary: {2}", employeeId, employeeName,employeesal);
        }
    };
    class Class3
    {
        public static void Main()
        {

            EmployeeN e = new EmployeeN();
            e.GetData();
            e.Print();
        }
    }
}
