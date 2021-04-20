using System;
using System.Collections.Generic;

#nullable disable

namespace FatherGolf.Models
{
    public partial class Golfer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Handicap { get; set; }
        public string Totalrounds { get; set; }
        public bool? Deleted { get; set; }
    }
}
