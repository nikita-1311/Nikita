using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class SampleCopyConstructor
    {
        private string name;

        public SampleCopyConstructor(string name)
        {
            this.name = name;
        }
        public SampleCopyConstructor(SampleCopyConstructor s)//copy constructor 
        {
            name = s.name;
        }
        public void print()
        {
            Console.WriteLine(name);
        }
    }
        class Class1
        {
        public static void Main2()
        {
            SampleCopyConstructor s1 = new SampleCopyConstructor("Nikita");
            s1.print();
        }
        }
}
