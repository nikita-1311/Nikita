using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 71;
            Console.WriteLine(a+b);
            //conditional statements
            //if-else
            if(a>7)
            {
                Console.WriteLine("a is greater than 7");
            }
            else
            {
                Console.WriteLine("7 is greater than a");
            }
            Console.WriteLine("please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Value entered by you is"+name);
        }
    }
}
