using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace Aviation.WebAPI.Data
{
    public class AviationContext : DbContext
    {
        public AviationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>().HasData(
                    new Airport
                    {
                        Id = 1,
                        Name = "SPU",
                        Address = "Split"
                    },
                    new Airport
                    {
                        Id = 2,
                        Name = "ZGPleso",
                        Address = "Zagreb"
                    },
                    new Airport
                    {
                        Id = 3,
                        Name = "ZAD",
                        Address = "Zadar"
                    }
                );
        }

        public DbSet<Airport> Airports { get; set; }
    }
}
