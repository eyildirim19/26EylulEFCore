using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EfCoreFirst
{
    // DbContext sınıfları c# valıkları ile veritabanı varlıklarını eşleştirir.  proje içerisinde kullanıdığımız entity sınıfları bu sınıf içerisinde belirtilir....

    // Veritabanı varlık DbSet tipinde belirtilir... bu dbset veritabanı tabloları ile uygulama classlarını eşleştirir. 

    // DbContext sınıfı veritabanı bağlantımızı üstlenen sınıftır. 

    // DbContext=> sınıfı entityframework.core kütüphanesi iile gelmektedir...sınıfımıza bu namespace eklenmelidir..
    public class AppDbContext : DbContext
    {
        // override ile OnConfiguring metodu çağrılır..
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // veritabanı yolu belirlenir.
            optionsBuilder.UseSqlServer(@"Server=.\MSSQL2019;Database=Northwind;uid=sa;pwd=123;TrustServerCertificate=true");
        }

        public DbSet<Region> Region { get; set; }
        public DbSet<Shipper> Shippers { get; set; }


        // DbSet adı belirtmediğimiz sürece tablo ile eşleştirilir. yani tablo adı alı dbset adı aynı olmalıdır. 
    }

    //PKID
}