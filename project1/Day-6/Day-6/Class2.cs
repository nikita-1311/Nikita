using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    class Class2
    {
        public static void Main()
        {
            string s = "Nikita";
            char[] s1 = { 'N', 'i', 'k', 'i', 't', 'a' };
            char[] s4 = { 'N', 'i', 'k' };
            string s2 = new string(s1);
            string s5 = new string(s4);
            Console.WriteLine(s == s2);
            Console.WriteLine(s.Equals(s2));


            string s3 = s5;
            Console.WriteLine(s3 == s5);
            Console.WriteLine(s3.Equals(s5));
        }
    }
}
