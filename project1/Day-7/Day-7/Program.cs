using System;

namespace Day_7
{
    //static keyword
    static class A
    {
        public static int a;
        public static void print()
        {
            Console.WriteLine(a);
        }
    }
    class B
    {
        static int a ;
        public int b ;
        static B()
        {
            a = 1;
            Console.WriteLine("Hello I am from static class");
        }
        public B()
        {
            b = 1;
            a = 2;
            Console.WriteLine("Hello I am from default constructor");
        }
        public void print()
        {
            Console.WriteLine("a= " + a + "b= " + b);
        }
        public void show()
        {
            Console.WriteLine("a= " + a);
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            B b = new B();
            b.print();
            b.show();
        }
    }
}
