using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class SampelA
    {
        public virtual void show()
        {
            Console.WriteLine("Hi I am from base");
        }
        public void print()
        {
            Console.WriteLine("Hi I am print from base");
        }
    }
    class SampelB : SampelA
    {
        public override void show()
        {
            Console.WriteLine("Hi I am from Derived");
        }
        public void print()
        {
            Console.WriteLine("Hi I am print from derived");
        }
    }
    class Class8
    {
        public static void Main()
        {
            SampelA a = new SampelB();
            a.show();//example of overriding
            a.print();
        }
    }
}
