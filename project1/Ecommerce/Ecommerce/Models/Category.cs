﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Ecommerce.Models
{
    public partial class Category
    {
        public int Cid { get; set; }
        public string CategoryName { get; set; }
        public int? IsActive { get; set; }
    }
}
