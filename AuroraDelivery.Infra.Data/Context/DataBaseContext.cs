using AuroraDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuroraDelivery.Infra.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
