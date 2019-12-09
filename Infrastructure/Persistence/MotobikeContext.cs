using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class MotobikeContext : DbContext
    {
        public MotobikeContext(DbContextOptions<MotobikeContext> options) : base(options)
        {
        }

        public DbSet<Motobike> Motobikes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MotobikeContext).Assembly);
        }
    }
}