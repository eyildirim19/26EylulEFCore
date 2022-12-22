using _9_EfCore_Migration.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EfCore_Migration.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\MSSQL2019;Database=KodFirst; uid=sa;pwd=123; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UrunConfiguration());
            modelBuilder.ApplyConfiguration(new BolgeConfiguration());
        }

        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Bolge> Bolge { get; set; } // manuel oluşturduk....migration ile değil
        public DbSet<Il> Il { get; set; }
    }


    // Ödev : Northwind veritabanını code first ile oluşturunuz...migration kullanınız...projeni'zi github'a atınız....
}