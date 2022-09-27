using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Models
{
    public partial class Student
    {
        public int SId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int? TId { get; set; }
    }
}
