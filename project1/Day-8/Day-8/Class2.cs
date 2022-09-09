using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    //base class
    class Sample
    {
        public Sample(int a)
        {
            Console.WriteLine("Hi I am Sample and my value is " + a);
        }
    }
    class SampleB:Sample 
    {
        public SampleB(int a):base(a)
        {
            Console.WriteLine("Hi I am SampleB and my value is " + a);
        }
    }
    class SampleC:SampleB
    {
        public SampleC(int a):base(a)
        {
            Console.WriteLine("Hi I am SampleC and my value is " + a);
        }
    }
    class Class2
    {
        public static void Main3()
        {
            SampleC s = new SampleC(2);
        }
    }
}
