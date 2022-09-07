using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    //string
    class Class6
    {
        static int mchar=256;
            static void calculate(string str,int[] cal)
        {
            for (int i = 0; i < str.Length; i++)
                cal[str[i]]++;
        }
        public static void Main7()
        {
            
            string str = "aabbcccddddeee";
            int[] cal=new int[mchar];
            calculate(str, cal);
            for (int i = 0; i < mchar; i++)
            
                    if (cal[i]>1)
                    {
                    Console.WriteLine("character= " + (char)i);
                    Console.WriteLine("occurence " + cal[i] + " times");
                    }
        }
    }
}
