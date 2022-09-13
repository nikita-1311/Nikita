using System;

namespace Day_10
{
    //Multicast Delegate
    class Program
    {
        public delegate void Rectangle(double l, double b);
        public void area(double l, double b)
        {
            Console.WriteLine("Area od a rectangle is: " + l * b);
        }
        public void perimeter(double l, double b)
        {
            Console.WriteLine("Perimeter of a rectangle is: " + 2 * (l + b));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Rectangle r = new Rectangle(p.area);
            //calling second method
            r = r + p.perimeter;
            //invoke function
            r.Invoke(10, 20);
        }


    }
}
