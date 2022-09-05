using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    abstract class DummyS
    {
        public void show()
        {
            Console.WriteLine("Hi I am from abstract class");
        }
        abstract public void Absshow();

    }
    class DerviedDummy : DummyS
    {
        public override void Absshow()
        {
            Console.WriteLine("Hi I am from abstract class");
        }
        public void print()
        {
            Console.WriteLine("I am from derived");
        }
    }
    class Class10
    {
        public static void Main()
        {
            DerviedDummy s = new DerviedDummy();
            s.show();
            s.print();
        }
    }
}
