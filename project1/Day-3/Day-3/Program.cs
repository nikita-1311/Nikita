using System;

namespace Day_3
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int no = Convert.ToInt32(Console.ReadLine());
            if(no%2==0)
            {
                Console.WriteLine("Number is even " + no);
            }
            else
            {
                Console.WriteLine("Number is odd " + no);
            }
        }
    }
}
