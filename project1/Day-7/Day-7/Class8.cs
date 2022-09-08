using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class Class8
    {
        //ArrayList
        public static void Main()
        {
            ArrayList al = new ArrayList();
            string str = "Hello";
            int x = 10;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Remove(x);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
