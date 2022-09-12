using System;
using System.IO;

namespace Day_9
{
    class Program
    {
        static void Main1(string[] args)
        {
            //File Handling
            System.IO.FileStream fs = new FileStream("sample.txt",FileMode.Append,FileAccess.Write);//write operation
            StreamWriter sw = new StreamWriter(fs);
            string str = "Hello This is Nikita!";
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();

            //read operation
            FileStream fsr = new FileStream("sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsr);
            Console.WriteLine("=======Content of File========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (str != null)
            {
                Console.WriteLine(str);
                sr.ReadLine();
            }

        }
    }
}
