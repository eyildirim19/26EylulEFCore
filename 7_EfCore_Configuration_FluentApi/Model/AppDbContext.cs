using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCore_Configuration_FluentApi.Model
{
    using Configuration;
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Not : ileride connectionstring'i başka bir bölümden ayarlayacağız...
            optionsBuilder.UseSqlServer(@"Server=.\MSSQL2019; Database=Northwind; uid=sa;pwd=123; TrustServerCertificate=true");
        }
        // fluentapi yöntemi => bir diper konfigurasyon yöntemidir. OnModelCreating metosu içerisinde uygulanılır
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // yöntem1
            modelBuilder.Entity<Kategori>()
                .ToTable("Categories"); // vt'nında Categories tablosu ile eşleşir..

            modelBuilder.Entity<Kategori>()
                .HasKey(c => c.KatId);// KatID alanı entity tarafında pk'dir.

            modelBuilder.Entity<Kategori>()
                .Property(c => c.KatId)
                .HasColumnName("CategoryId");

            modelBuilder.Entity<Kategori>()
                .Property(c => c.KatAdi)
                .HasColumnName("CategoryName");

            // yöntem2
            // harici konfigurasyon dosyalarımızı burada çağırabiliriz....
            modelBuilder.ApplyConfiguration(new NakliyeConfiguration());


            //modelBuilder.ApplyConfiguration();
        }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Nakliye> Naklies { get; set; }
    }
}
