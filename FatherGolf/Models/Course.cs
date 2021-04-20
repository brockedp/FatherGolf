using System;
using System.Collections.Generic;

#nullable disable

namespace FatherGolf.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Par { get; set; }
        public int FrontNinePar { get; set; }
        public int BackNinePar { get; set; }
        public int Slope { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double? CourseRating { get; set; }
        public bool? Deleted { get; set; }
    }
}
