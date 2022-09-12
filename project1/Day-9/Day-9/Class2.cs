using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_9
{
    //json file
    class Class2
    {
        class student
        {
            public student()
            {
                Roll_No= 1;
                StudentName = "Nikita";
            }
            public int Roll_No { get; set; }
            public string StudentName { get; set; }

            public void WriteInFile()
            {

            }
        }
        public static void Main3()
        {
            //c# code to json format
            student student = new student();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(student);
            Console.WriteLine(json);
            var studentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<student>(json);
            //json to file
            System.IO.FileStream fs = new FileStream("student.json", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(student.StudentName);
            sw.WriteLine(student.Roll_No);
            sw.Flush();
            sw.Close();
            fs.Close();

            //Reading from a file
            FileStream fsR = new FileStream("student.Json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsR);
            Console.WriteLine("======Content from file========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (student!= null)
            {
                Console.WriteLine(student.StudentName);
                student.StudentName = sr.ReadLine();
                Console.WriteLine(student.Roll_No);
                student.Roll_No = Convert.ToInt32(sr.ReadLine());
                break;
            }
            sr.Close();
            fsR.Close();
        }
    }
}
