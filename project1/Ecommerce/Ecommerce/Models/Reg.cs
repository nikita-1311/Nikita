﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.Models
{
    public partial class Reg
    {
        public int Rid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int? IsActive { get; set; }
    }
}
