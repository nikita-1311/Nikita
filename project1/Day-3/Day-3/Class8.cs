using System;

namespace Day_3
{
    class Class8
    {
        public static void Main9()
        {
            //result vs out
            int a = 1, b = 4;
            Console.WriteLine(Sum(ref a, ref b));
            int result;
            SumOut(a, b, out result);
            Console.WriteLine(result);
        }
        //out parameter before leaving from the method the out parameter must be
        //assigned with some value


        public static int Sum(ref int a, ref int b)
        {
            return (a + b);
        }
        public static void SumOut(int a, int b, out int c)
        {

            c = a + b;
        }
    }
}
