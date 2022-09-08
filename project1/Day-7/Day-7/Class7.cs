using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class IndexerClass
    {
        private string[] name = new string[3];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
    }
    class Class7
    {
        public static void Main8()
        {
            IndexerClass c = new IndexerClass();
            c[0] = "Hello!";
            c[1] = "I am Nikita";
            c[2] = "Nice to meet you";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(c[i]);
            }
        }

    }
}
