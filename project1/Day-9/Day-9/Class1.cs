using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Day_9
{
    class Emp
    {
        public string name = "Nikita";
        public int Id = 10;
    }
    class Class1
    {
        public static void Main2()
        {
            Emp emp = new Emp();
            FileStream fs = new FileStream("employee.json",FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Name of Employee: "+emp.name);
            sw.WriteLine("Id of Employee: " + emp.Id);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileStream fsr = new FileStream("employee.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsr);
            Console.WriteLine("=======Content of File========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (emp!= null)
            {
                Console.WriteLine(emp.name);
                emp.name = sr.ReadLine();
                Console.WriteLine(emp.Id);
                emp.Id = Convert.ToInt32(Console.ReadLine());
                break;
            }
            sr.Close();
            fsr.Close();
        }
    }
}
