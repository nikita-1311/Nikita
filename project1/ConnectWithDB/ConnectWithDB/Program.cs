using ConnectWithDB.Models;
using System;

namespace ConnectWithDB
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDBContext db = new TestDBContext();
            var data = db.Tests;
            Console.WriteLine("Id | Text");
            foreach(var item in data)
            {
                Console.WriteLine(item.Id + "   " + item.Text);
            }
        }
    }
}
