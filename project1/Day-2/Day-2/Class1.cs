using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Class1
    {
        public static void Main2()
        {
            //voting
            Console.WriteLine("age:");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age<=60)
            {
                Console.WriteLine("person is elligible to vote" + age);
            }
            else if(age > 60)
            {
                Console.WriteLine("person is a senior citizen and elligible to vote" + age);
            }
            else
            {
                Console.WriteLine("person is not elligible to vote" + age);
            }
        }
    }
}
