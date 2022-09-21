using Dtabase.Models;
using System;
using System.Linq;

namespace Dtabase
{
    class Program
    {
        static void Main(string[] args)
        {
            StdContext db = new StdContext();
            var data = db.Students.Join(
                db.Courses, x => x.CourseId, y => y.CourseId,
                (x, y) => new { x, y }).Join(db.Subjects, z => z.y.CourseId, s => s.CourseId, (z, s) =>
                          new { id = z.x.StdId,
                              Sname = z.x.Sname,
                              Gender = z.x.Gender,
                              CourseName = z.y.CourseName,
                              SubName = s.SubName});
            Console.WriteLine("StdId | SName | Gender | CourseId  | SubjectName");
            foreach (var item in data)
            {
                Console.WriteLine(item.id + "      " + item.Sname + "      " + item.Gender + "       " + item.CourseName + "      " + item.SubName);
            }
        }
    }
}
