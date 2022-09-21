using ConnectWithDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectWithDB
{
    class Class3
    {
        public static void Main()
        {
            TestDBContext db = new TestDBContext();
            var data = db.Emps.Join(
             db.Dtbls,x=>x.Did,y=>y.Did,
              (x, y) => new { Id = x.Id, Ename = x.Ename, Salary = x.Salary, dname = y.dname });

            Console.WriteLine("ID | EmployeeName | EmployeeSalary | DepartmentName ");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " " + item.Ename + " " + item.Salary + " " + item.dname );
            }
        }
    }
}
