using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerApi.Models
{
    public partial class Customertbl
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal? CustomerAmount { get; set; }
    }
}
