using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class10
    {
        public static void Main11()
        {
            //odd and even using array
            int[] a = new int[5];
            int i;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Please enter the value for array[" + i + "]= ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine("Even numbers are: " + a[i]);
                }
            }
            for (i = 0; i < a.Length; i++)
            { 
                if(a[i]%2==1)
                {
                    Console.WriteLine("Odd numbers are: " + a[i]);
                    
                }

            }  
        }
    }
}
