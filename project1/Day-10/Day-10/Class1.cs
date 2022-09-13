using System;
using System.Collections.Generic;
using System.Text;

namespace Day_10
{
    class Class1
    {
        static int sum(int x,int y)
        {
            return (x + y);
        }
        static void print(int i)
        {
            Console.WriteLine(i);
        }
        static bool IsPositive(int val)
        {
            if (val > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static void Main2()
        {
            Func<int, int, int> add = sum;
            int result = add(10, 10);
            Console.WriteLine(result);
            Action<int> printVal = print;
            printVal(10);
            Predicate<int> predicate = IsPositive;
            Console.WriteLine(predicate(-2));
        }
    }
}
