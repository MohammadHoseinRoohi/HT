using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Entities.Base;

namespace Project1.Entities
{
    public class Cooperative : Thing
    {
        public required string BrandName { get; set; }
        public required Employee Employee_1 { get; set; }
        public required Employee Employee_2 { get; set; }
        public required Employee? Employee_3 { get; set; }
        public required Driver Driver_1 { get; set; }
        public required Driver Driver_2 { get; set; }
        public required Driver Driver_3 { get; set; }
        public required Driver Driver_4 { get; set; }
        public required Driver Driver_5 { get; set; }
        public required Driver? Driver_6 { get; set; }
        public required Driver? Driver_7 { get; set; }
        public double PhoneNumber { get; set; }
    }
}