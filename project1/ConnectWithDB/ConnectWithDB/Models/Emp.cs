using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectWithDB.Models
{
    public partial class Emp
    {

        public int Id { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }
        public object Did { get; internal set; }
    }
}
