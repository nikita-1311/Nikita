using System;
using System.Collections.Generic;

#nullable disable

namespace Dtabase.Models
{
    public partial class Student
    {
        public int StdId { get; set; }
        public string Sname { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int CourseId { get; set; }
    }
}
