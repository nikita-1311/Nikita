using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class7
    {
        public static void Main9()
        {
            //var vs dynamic
            var i = 1;//compile time 
            Type type = i.GetType();
            Console.WriteLine(i);
            Console.WriteLine(type);

            dynamic j = 1;//run time
            Type typed = j.GetType();
            Console.WriteLine(j);
            Console.WriteLine(typed);
            j = "Nikita";
            typed = j.GetType();
            Console.WriteLine(j);
            Console.WriteLine(typed);
        }
    }
}
