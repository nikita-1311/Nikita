using ConnectWithDB.Models;
using System;

namespace ConnectWithDB
{
    class Program
    {
        static void Main1(string[] args)
        {
            TestDBContext db = new TestDBContext();
            //var data = db.Tests;
            //Console.WriteLine("Id | Text");
            //foreach(var item in data)
            //{
            //   Console.WriteLine(item.Id + "   " + item.Text);
            // }

            Test obj = new Test();
            obj.Text = "Shruti";

            db.Tests.Add(obj);
            db.SaveChanges();
            Console.WriteLine("Record is added");
        }
    }
}
