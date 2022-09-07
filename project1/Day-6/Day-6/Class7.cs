using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    //string vs stringbuilder
    class Class7
    {
        public static void Main()
        {
            string s = "Nikita";
            Console.WriteLine(s);
            StringBuilder s1 = new StringBuilder("Nikita");
            s1.Append(" is a Good girl");
            Console.WriteLine(s1);
            s1.Clear();
            s1.Append("Hi I a new value");
            Console.WriteLine(s1);
        }
    }
}
