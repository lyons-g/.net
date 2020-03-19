using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment6
{
    public partial class Vehicle
    {
        [Key]
        public int? StudentId { get; set; }
        public string VehicleModel { get; set; }
        public string Registration { get; set; }
        public string Owner { get; set; }
        public int? Apartment { get; set; }
    }
}
