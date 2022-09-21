using System;
using System.Collections.Generic;

#nullable disable

namespace Dtabase.Models
{
    public partial class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public int? CourseId { get; set; }
    }
}
