using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EfCore_Configuration_DataAnnotations.Entity
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\MSSQL2019; Database=Northwind;uid=sa;pwd=123;TrustServerCertificate=true");
        }

        public DbSet<Kategori> Kategoriler { get; set; }

        // aksini belirtmezsek tablo ismi olarak dbset adı referans alınır...
    }
}
