using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EgdeBookingSystem.Models;

namespace EgdeBookingSystem.Data
{
    public class EgdeBookingSystemContext : DbContext
    {
        public EgdeBookingSystemContext (DbContextOptions<EgdeBookingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EgdeBookingSystem.Models.Equipment> Equipment { get; set; }
    }
}
