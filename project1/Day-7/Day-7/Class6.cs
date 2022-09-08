using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class P
    {
        int a;
        public int A { get { return a; } set { a = value; } }
    }
    class Class6
    {
        public static void Main()
        {
            P a = new P();
            a.A = 2;
            Console.WriteLine(a.A);
        }
    }
}
