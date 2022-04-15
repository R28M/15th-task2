using System;
using System.Collections.Generic;

namespace ConsoleTask1.Models
{
    public partial class Productdetail
    {
        public int Pcode { get; set; }
        public string? Pname { get; set; }
        public decimal? Price { get; set; }
        public string? Pdesc { get; set; }
        public string? Category { get; set; }
        public int? Stockinhand { get; set; }
    }
}
