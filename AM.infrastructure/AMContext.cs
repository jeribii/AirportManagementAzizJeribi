using AM.Application.Core.Domain;
using Microsoft.EntityFrameworkCore;
namespace AM.infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder); base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Flight> flights { get; set; }
        public DbSet<Passenger> passengers { get; set; }
        public DbSet<Plane> planes { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Traveller> travellers { get; set; }


    }
}
