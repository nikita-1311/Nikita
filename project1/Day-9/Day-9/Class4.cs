using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    class Class4
    {
        //delegates
        public delegate void addNum(int a, int b);
        public void sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Main()
        {
            Class4 c = new Class4();
            addNum ad = new addNum(c.sum);
            ad(100, 100);
            addNum subt = new addNum(c.sub);
            subt(100, 100);
        }
    }
}
