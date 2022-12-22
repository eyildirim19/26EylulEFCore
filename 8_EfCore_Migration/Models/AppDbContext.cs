using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EfCore_Migration.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\MSSQL2019; Database=26EylulKodFörst; uid=sa;pwd=123; TrustServerCertificate=true");
        }

        public DbSet<Kategori> Kategoris { get; set; }
    }
}