using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_8
{
    class Class5
    {
        public static void Main()
        {
            Regex r = new Regex("^[0-9]{6}$");
            Regex r1 = new Regex("^[a-z]{6}$");
            Regex r2 = new Regex("^[A-Z]{5}$");
            if (r.IsMatch("123567"))
            {
                Console.WriteLine("Value Is correct");
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }
            if(r1.IsMatch("abcde"))
            {
                Console.WriteLine("Value is correct");
            }
            else
            {
                Console.WriteLine("Value is incorrect");
            }
            if (r2.IsMatch("ABCDE"))
            {
                Console.WriteLine("Value is correct");
            }
            else
            {
                Console.WriteLine("Value is incorrect");
            }
        }
    }
}
