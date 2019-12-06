using Microsoft.EntityFrameworkCore;
using RazorSample.Models;

namespace RazorSample.Data
{
    public class MotobikeContext : DbContext
    {
        public MotobikeContext(DbContextOptions<MotobikeContext> options) : base(options)
        {
        }

        public DbSet<Motobike> Motobikes{ get; set; }
    }
}