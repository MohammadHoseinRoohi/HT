using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Entities.Base;

namespace Project1.Entities
{
    public class Sale : Thing
    {
        public required Ticket Ticket { get; set; }
        public required Passenger Passenger { get; set; }
        public DateTime Date { get; set; }
    }
}