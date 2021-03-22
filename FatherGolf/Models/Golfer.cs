using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FatherGolf.Models
{
    public partial class Golfer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? Handicap { get; set; }
        public string Totalrounds { get; set; }
    }
}
