using ConnectWithDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConnectWithDB
{
    class Class2
    {
        public static void Data(List<Emp> data)
        {
            Console.WriteLine("Emp_ID | Emp_Name | Emp_Salary");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + "   " + item.Ename + "   " + item.Salary + "   ");
            }
        }
        public static void Main()
        {
            TestDBContext db1 = new TestDBContext();
            var data = db1.Emps;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please select action to be performed: \n 1.Read \n 2.Update \n 3.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Data(data.ToList());
                        break;
                    case 2:
                        Console.WriteLine("Please select any id to update the data");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var UpdateData = db1.Emps.Where(x => x.Id == id).FirstOrDefault();
                        Console.WriteLine("Please enter Name that you want to update");
                        var input = Console.ReadLine();
                        UpdateData.Ename = input;

                        Console.WriteLine("Please enter Salary that you want to update");
                        var input2 = Convert.ToInt32(Console.ReadLine());
                        UpdateData.Salary = input2;
                        break;
                    case 3:
                        Console.WriteLine("Please select any id to delete the data");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        var deleteItem = db1.Emps.Where(x => x.Id == id2).FirstOrDefault();
                        db1.Emps.Remove(deleteItem);
                        db1.SaveChanges();
                        Console.WriteLine("database record is deleted succesully");
                        Data(data.ToList());
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice");
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
