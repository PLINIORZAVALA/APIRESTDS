

using _5._0.DataAccesLayer.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace _5._0.DataAccesLayer.Connection
{
    public class DataBaseContext : DbContext
    {
        public class DataBaseContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().ToTable("users"); //  

                base.OnModelCreating(modelBuilder);
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-3BNM2QF;Database=dbcrud20231;User Id=PL;Password=12345678,TrustServerCertificate=True;");
            }
        }
    }
}
