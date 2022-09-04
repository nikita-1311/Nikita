using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class11
    {
        //sum of array elements 
        public static void Main()
        {
            int sum=0;
            int[] a = new int[10];
            Console.WriteLine("Please enter the value for array= ");
            for (int i = 0; i < a.Length; i++)
            { 
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum of array elements=" + sum);
        }
    }
}
