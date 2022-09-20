using ConnectWithDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectWithDB
{
    class Class1
    {
        //update, delete operations
        public static void printData(List<Test> data)
        {
            Console.WriteLine("ID | TEXT");
            //iteration on db data
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + "   " + item.Text);
            }
        }
        public static void Main2()
        {
            TestDBContext db = new TestDBContext();
            var data = db.Tests;
            printData(data.ToList());
            Console.WriteLine("Please select any id to update the data");
            int id = Convert.ToInt32(Console.ReadLine());

            var UpdateData = db.Tests.Where(x => x.Id == id).FirstOrDefault();
            Console.WriteLine("Please enter some text that you want to update");
            var input = Console.ReadLine();
            UpdateData.Text = input;

            db.Tests.Update(UpdateData);
            db.SaveChanges();
            Console.WriteLine("database record is updated succesully");
            printData(data.ToList());

            Console.WriteLine("Please select any id to delete the data");
            int id2 = Convert.ToInt32(Console.ReadLine());
            var deleteItem = db.Tests.Where(x => x.Id == id2).FirstOrDefault();
            db.Tests.Remove(deleteItem);
            db.SaveChanges();
            Console.WriteLine("database record is deleted succesully");
            printData(data.ToList());

        }
    }
}
