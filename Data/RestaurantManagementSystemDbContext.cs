
using Microsoft.EntityFrameworkCore;

namespace RestaurantManagementSystem.Data
{
    internal class RestaurantManagementSystemDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OnlineStoreEf;Trusted_Connection=True;");
        }
    }
}
