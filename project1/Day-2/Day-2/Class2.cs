using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Class2
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter Your Choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            //switch case
            switch(choice)
            {
                case 1:
                    Console.WriteLine("case 1 is executed");
                    break;
                case 2:
                    Console.WriteLine("case 2 is executed");
                    break;
                default:
                    Console.WriteLine("please enter a valid input");
                    break;
            }
        }
    }
}
