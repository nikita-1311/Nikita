using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class3
    {   
        public static void Main4()
        {
            //swapping of numbers without function
            int a, b, temp;
            Console.WriteLine("Enter number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping, Numbers are: "+ a  + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping, Numbers are: " + a  + b);
        }
    }
}
