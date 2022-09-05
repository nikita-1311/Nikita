using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Class5
    {
        public static void Main()
        {
            //palindrome
            string rev="";
            Console.WriteLine("Please enter a value: ");
            string nm = Console.ReadLine();
            for (int i = nm.Length - 1; i >= 0; i--) // Reverse the string 
            {
                rev += nm[i].ToString();
            }
            if (rev == nm) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("The given string is Palindrome \n Entered String Was {0} and reverse string is {1}", nm, rev);
            }
            else
            {
                Console.WriteLine("The given string is not Palindrome \n Entered String Was {0} and reverse string is {1}", nm, rev);
            }
        }
    }
}
