using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Entities.Base;
using Project1.Enums;

namespace Project1.Entities
{
    public class Passenger : Thing
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public Gender Gender { get; set; }
        public double PhoneNumber { get; set; }
        public string? Email { get; set; }
        // public double NationalCode { get; set; }
    }
}