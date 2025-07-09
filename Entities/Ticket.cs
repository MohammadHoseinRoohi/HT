using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Entities.Base;
using Project1.Enums;

namespace Project1.Entities
{
    public class Ticket : Thing
    {
        public double Price { get; set; }
        public double SeatNumber { get; set; }
        public DateTime DateOfDeparture { get; set; }
        public DateTime? DateOfReturn { get; set; }
        public Routes Origin { get; set; }
        public Routes Destination { get; set; }
        public DateOnly DT { get; set; }
        // DT : Departure time
        public DateOnly TTAAD { get; set; }
        // TTAAD : Time to arrive at destination
    }
}