using Microsoft.EntityFrameworkCore;
using parcial1.Shared.Entities;

namespace parcial1.API.Data
{
    
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
            }
            public DbSet<Ticket> Ticket { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();
            }
        }
    }


