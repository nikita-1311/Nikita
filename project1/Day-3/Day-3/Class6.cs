using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class6
    {
        public static void Main7()
        {
            //Int.TryParse
            Console.WriteLine("Enter a value: ");
            string n = Console.ReadLine();
            int num;
            bool flag = int.TryParse(n, out num);
            if(flag==true)
            {
                Console.WriteLine("User has entered correct numeric value");
            }
            else
            {
                Console.WriteLine("User has entered incorrect numeric value");
            }
        }
    }
}
