using System;
using System.Collections.Generic;

#nullable disable

namespace FatherGolf.Models
{
    public partial class GolfScoreCard
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? PlayerId { get; set; }
        public int? Hole1 { get; set; }
        public int? Hole2 { get; set; }
        public int? Hole3 { get; set; }
        public int? Hole4 { get; set; }
        public int? Hole5 { get; set; }
        public int? Hole6 { get; set; }
        public int? Hole7 { get; set; }
        public int? Hole8 { get; set; }
        public int? Hole9 { get; set; }
        public int? Hole10 { get; set; }
        public int? Hole11 { get; set; }
        public int? Hole12 { get; set; }
        public int? Hole13 { get; set; }
        public int? Hole14 { get; set; }
        public int? Hole15 { get; set; }
        public int? Hole16 { get; set; }
        public int? Hole17 { get; set; }
        public int? Hole18 { get; set; }
        public int? Total { get; set; }
        public string Date { get; set; }
        public bool? Deleted { get; set; }
        public int? RoundLength { get; set; }
    }
}
