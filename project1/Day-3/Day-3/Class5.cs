using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class5
    {
        public static void Main()
        {
            //swapping using function and call by reference
            int a = 1, b = 2;
            Console.WriteLine("Before Swapping, Numbers are: a=" + a+  "b=" + b);
            Swap(ref a, ref b);
            Console.WriteLine("After Swapping Inside Main, Numbers are: a=" + a+  "b=" + b);
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping, Numbers are a=" + a + "b=" + b);
        }
    }
}
