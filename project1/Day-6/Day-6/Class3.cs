using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    //is vs as
        class Demo1
        {
        
        }
        class Demo2
        {

        }
        class Class3
        {
            public static void Main4()
            {
                Demo1 demo1 = new Demo1();
                Demo2 demo2 = new Demo2();
                if (demo1 is Demo2)
                {
                    Console.WriteLine("Hi");
                }
                if (1 is 2)
                {
                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("not equal");
                }
            }
        }
    }
