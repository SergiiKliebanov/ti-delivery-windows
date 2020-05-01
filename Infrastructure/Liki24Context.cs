using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class Liki24Context : DbContext
    {
        public Liki24Context(DbContextOptions<Liki24Context> options) : base(options) { }

        public DbSet<DeliveryWindow> DeliveryWindows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DeliveryWindow>().OwnsOne(w => w.ValidityPeriod);
        }
    }
}
