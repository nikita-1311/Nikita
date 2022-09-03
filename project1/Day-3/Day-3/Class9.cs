using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class9
    {
        public static void Main()
        {
            //array
            int[] sampleaaray = new int[3];
            for (int i = 0; i < sampleaaray.Length; i++)
            {
                Console.WriteLine("Please enter the value for sampleaaray[" + i + "]= ");
                sampleaaray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sampleaaray.Length; i++)
            {
                Console.Write("the value of sampleaaray[" + i + "]= ");
                Console.WriteLine(sampleaaray[i]);
            }
            //loops
            Console.WriteLine("===============For Loop==========");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===============WHile Loop==========");
            //entry controlled loop
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("===============Do WHile Loop==========");

            //Exit controlled loop
            j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 3);
        }
    }
}
