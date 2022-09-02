using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class4
    {
        public static void Main5()
        {
            //swapping using function and call by value
            int a = 1,b = 2;
            Console.WriteLine("Before Swapping, Numbers are: " + a + b);
            Swap(a, b);
            Console.WriteLine("After Swapping Inside Main, Numbers are: " + a + b);
        }
        public static void Swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping, Numbers are: " + a + b);
        }
    }
}
