using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    //inheritence
    class Dummy
    {
        int a=2;
        public void Print()
        {
            Console.WriteLine("Value of a is :" + a);
        }
    }
    class Derived : Dummy
    {
        int b=1;
        public void Show()
        {
            Console.WriteLine("Value of b is " + b);
        }
    }
    class Class8
    {
        public static void Main9()
        {
            Derived d = new Derived();
            d.Show();
            d.Print();
        }
    }
}
