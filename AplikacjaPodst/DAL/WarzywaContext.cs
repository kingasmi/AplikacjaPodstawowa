using AplikacjaPodst.Models ;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplikacjaPodst.DAL
{
    public class WarzywaContext : DbContext
    {
        public DbSet<Warzywo> Warzywa { get; set; }

        public WarzywaContext(DbContextOptions<WarzywaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warzywo>().HasData(
                new Warzywo { WarzywoId = 1, Name = "pomidor", Price = 8.5m, Quantity = 30, Country = "Włochy" },
                new Warzywo { WarzywoId = 2, Name = "ziemniaki", Price = 2.3m, Quantity = 85, Country = "Polska" },
                new Warzywo { WarzywoId = 3, Name = "ogórek", Price = 6m, Quantity = 10, Country = "Dania" },
                new Warzywo { WarzywoId = 4, Name = "kalafior", Price = 5.99m, Quantity = 40, Country = "Holandia" },
                new Warzywo { WarzywoId = 5, Name = "cukinia", Price = 4.6m, Quantity = 16, Country = "Szwecja" }
                );
        }
    }
}
