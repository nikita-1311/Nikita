using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dtabase
{
    class Class2
    {
        public static void Main()
        {
            IList<Student> studentList = new List<Student>() {

                new Student(){StudentID=1,StudentName="Nikita",StudentAge=20},
                  new Student(){StudentID=2,StudentName="Sejal",StudentAge=20},
                    new Student(){StudentID=3,StudentName="Prachi",StudentAge=21},
                     new Student(){StudentID=4,StudentName="Divya",StudentAge=19},
                      new Student(){StudentID=5,StudentName="Sakshi",StudentAge=20}
            };
            var groupResult = from s in studentList group s by s.StudentAge;
            var groupResult1 = studentList.GroupBy(x => x.StudentAge);
            Console.WriteLine("==Group By==");
            foreach (var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("=====");
            foreach (var item in groupResult1)
            {
                Console.WriteLine(item.Key);
            }
            //contains
            Console.WriteLine("========Contains========");
            var sam = studentList.Select(x => x.StudentName.Contains("Nikita"));
            foreach (var item in sam)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================");
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(1);
            Console.WriteLine(result);
            Console.WriteLine("-==============Aggregate==========");
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four" };
            var commasepatedstring = strList.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(commasepatedstring);
            Console.WriteLine("========Average=========");
            var average = intList.Average();
            Console.WriteLine(average);
            Console.WriteLine("========Count=========");
            var count = intList.Count();
            Console.WriteLine(count);
            Console.WriteLine("========Sum=========");
            var sum = intList.Sum();
            Console.WriteLine(sum);
            Console.WriteLine("========Max=========");
            var max = intList.Max();
            Console.WriteLine(max);
            Console.WriteLine("========DefaultIfEmpty=========");
            var dif = intList.DefaultIfEmpty(10);
            Console.WriteLine("Count: {0}", intList.Count());
            
        }
    }
}
