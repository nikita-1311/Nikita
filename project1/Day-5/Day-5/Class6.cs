using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    //methodoverloading
    class MethodOverloading
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Mul(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }
    class Class6
    {
        public static void Main()
        {
            MethodOverloading obj = new MethodOverloading();
            obj.Sum(1, 2);
            obj.Sum(1, 2, 3);
            obj.Sum(1.57, 2.35);
            obj.Mul(3,4);
        }
    }
}
