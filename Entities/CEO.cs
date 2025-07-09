using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Entities
{
    public class CEO : Employee, IAccessable
    {
        public required string Username { get; set; }
        public double Password { get; set; }
        public string? Email { get; set; }
    }
}