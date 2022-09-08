using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class Class8
    {
        //Non-generic Collection
        public static void Main9()
        {
            Console.WriteLine("-----ArrayList-----");
            ArrayList al = new ArrayList();
            string str = "Hello";
            int x = 10;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Remove(x);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----HashTable-----");
            Hashtable ht = new Hashtable();
            ht.Add("asp", "asp.net");
            ht.Add("cs", "cs.net");
            ht.Add("vb", "vb.net");
            ht.Remove("cs");   
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("-----SortedList-----");
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("asp", "asp.net");
            sl.Add("cs", "cs.net");
            sl.Add("vb", "vb.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }
            Console.WriteLine("-----Stack-----");
            Stack st = new Stack();
            st.Push("oracle");
            st.Push("asp.net");
            st.Push("cs.net");
            st.Push("vb.net");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----Queues-----");
            Queue q = new Queue();
            q.Enqueue("oracle");
            q.Enqueue("asp.net");
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
