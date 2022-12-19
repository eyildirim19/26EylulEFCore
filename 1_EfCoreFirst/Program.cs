using Microsoft.EntityFrameworkCore;

namespace _1_EfCoreFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EntityFramework.Core ile çalışmak için projemize Nuget Manage Package penceresinden Microsoft.EntityFramework.Core ve Microsft.EntityFramework.SqlServer kütüphanelerini indirmemiz gerekir. 
            AppDbContext dbContext = new AppDbContext();
            List<Region> result = dbContext.Region.ToList(); // veritabanında kayıt alınır result değişkenine aktarılır....

            foreach (Region region in result)
                Console.WriteLine($"{region.RegionID}-{region.RegionDescription}");

            Console.WriteLine("--------");

            List<Shipper> shippers = dbContext.Shippers.ToList();
            foreach (Shipper shipper in shippers)
                Console.WriteLine($"{shipper.ShipperId}-{shipper.CompanyName}-{shipper.Phone}");


            // FromSql=> Microsoft.EntityFrameworkCore namespace eklenmelidir..
            // FromSql ile sql queryleri yazabiliyoruz....
            List<Shipper> shipList = dbContext.Shippers.FromSql($"select * from Shippers where ShipperId in (1,2,3)").ToList();
            Shipper ship = dbContext.Shippers.FromSql($"select * from shippers where shipperId = {25}").FirstOrDefault();

            //List<Shipper> shipList = dbContext.Shippers.FromSqlRaw("select * from Shippers where ShipperId in (1,2,3)").ToList();
            //List<Shipper> shipList1 = dbContext.Shippers.FromSqlInterpolated($"select * from shippers where ShipperId in (1,2,3)").ToList();
        }
    }
}

// ado.net => connection,command vb. sınıflar ile veritabanı işlemleri yapılır. hızlıdır. 


// dapper => micro orm tool'udur.. yapı olarak ado.net'e benzer. zaten ado.net alt yapısını kullanılır...

// entiy framework core => ado.net alt yapısını kullanılır.