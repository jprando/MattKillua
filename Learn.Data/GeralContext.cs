using System;
using Learn.Domain.Geral;
using Microsoft.EntityFrameworkCore;

namespace Learn.Data
{
    public class GeralContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=Matteus;" +
                "Trusted_Connection=True;");
        }
    }
}
