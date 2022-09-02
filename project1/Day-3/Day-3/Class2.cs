using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class2
    {
        public static void Main()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter Number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int res;
            Console.WriteLine("Please Enter Your Choice:");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    res = n1 + n2;
                    Console.WriteLine("Addition is= " + res);
                    break;
                case 2:
                    res = n1 - n2;
                    Console.WriteLine("Subtraction is= " + res);
                    break;
                case 3:
                    res = n1 * n2;
                    Console.WriteLine("Multiplication is= " + res);
                    break;
                case 4:
                    res = n1 / n2;
                    Console.WriteLine("Division is= " + res);
                    break;
                default:
                    Console.WriteLine("please enter valid input");
                    break;
            }
        }
    }
}
