using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    class EmployeeN
    {
        //Menu driven program to fill employee details using list
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
        public int EmployeeSalary { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter your EmployeeID");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your EmployeeName");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Please enter your EmployeeGender");
            EmployeeGender = Console.ReadLine();
            Console.WriteLine("Please enter your Salary");
            EmployeeSalary = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Class4
    {
        public static void PrintData(List<EmployeeN> empList)
        {
            foreach (var item in empList)
            {
                Console.WriteLine("Employee ID" + "|" + item.EmployeeID);
                Console.WriteLine("Employee Name" + "|" + item.EmployeeName);
                Console.WriteLine("Employee Gender" + "|" + item.EmployeeGender);
                Console.WriteLine("Employee Salary" + "|" + item.EmployeeSalary);
            }
        }
        public static EmployeeN FindObject(List<EmployeeN> empList, int ID)
        {
            foreach (var item in empList)
            {
                if (item.EmployeeID == ID)
                {
                    return item;
                }
            }
            return new EmployeeN();
        }
        public static void Main()
        {
            bool flag = true;
            List<EmployeeN> employeeList = new List<EmployeeN>();
            while (flag)
            {
                Console.WriteLine("Please enter the choice you want to do \n 1.ADD \n 2.Update \n 3.Delete \n 4.List \n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeN e = new EmployeeN();
                        e.GetData();
                        employeeList.Add(e);
                        Console.WriteLine("Your record is successully Inserted.");
                        break;
                    case 2:
                        PrintData(employeeList);
                        Console.WriteLine("Please enter the employee ID");
                        int EmployeeID = Convert.ToInt32(Console.ReadLine());
                        EmployeeN e1 = new EmployeeN();
                        e1.GetData();
                        var employeeData = FindObject(employeeList, EmployeeID);
                        employeeList.Remove(employeeData);
                        employeeList.Add(e1);
                        Console.WriteLine("Your record is successully Updated.");
                        break;
                    case 3:
                        PrintData(employeeList);
                        Console.WriteLine("Please enter the employee ID");
                        int DEmployeeID = Convert.ToInt32(Console.ReadLine());
                        var DemployeeData = FindObject(employeeList, DEmployeeID);
                        employeeList.Remove(DemployeeData);
                        Console.WriteLine("Your record is successully Deleted.");
                        break;
                    case 4:
                        PrintData(employeeList);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter correct Input");
                        break;
                }
                if (!flag)
                {
                    break;
                }
            }


        }

    }
}
