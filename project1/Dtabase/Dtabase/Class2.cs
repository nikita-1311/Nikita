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
            Console.WriteLine("=====");
            foreach (var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("=====");
            foreach (var item in groupResult1)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
