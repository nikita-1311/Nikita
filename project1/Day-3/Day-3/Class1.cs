using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class1
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter number1: ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num2 && num1>num3)
            {
                Console.WriteLine("Number 1 is Max ");
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Number 2 is Max ");
            }
            else
            {
                Console.WriteLine("Number 3 is Max ");
            }
        }
    }
}
