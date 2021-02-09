using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgdeBookingSystem.Models
{
    public class Utstyr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public bool Booked { get; set; }

    }
}
