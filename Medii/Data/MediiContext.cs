using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Medii.Models;

namespace Medii.Data
{
    public class MediiContext : DbContext
    {
        public MediiContext (DbContextOptions<MediiContext> options)
            : base(options)
        {
        }

        public DbSet<Medii.Models.Location> Location { get; set; } = default!;

        public DbSet<Medii.Models.Menu>? Menu { get; set; }

        public DbSet<Medii.Models.Reservation>? Reservation { get; set; }
    }
}
