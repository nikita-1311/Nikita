using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Class4
    {
        public static void Main5()
        {
            //Boxing
            int i = 1;
            object o;
            o = i;
            Console.WriteLine(o);

            //UnBoxing
            i = (int)o;
            Console.WriteLine(i);

            //null
            Nullable<int> c = null;
            int? d = null;
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
