namespace _4_EfCore_LazyLoading
{
    using Entity;
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext dbContext = new AppDbContext();
            //id'si 1 olan product'i alalım...
            // => Find => geriye tek obje dönen uzantı bir metottur. pk'ya göre arama yapar...
            Product p = dbContext.Products.Find(1);

            // Product'in suppliername'ni bulalım..
            Supplier s = dbContext.Suppliers.Find(p.SupplierId);
            // yukarıdaki işlemi efcore bize lazy loading veya eager loding yöntemiyle sunar....

            // lazy loading aktif edildiğinde veritabanına supplier için sorgu burada atılacaktır...
            Supplier s1 = p.Supplier;

            // İlişkili kayıtları yükleme            
            // Lazy Loading => ilişkili kayıtları yüklemek için kullanılır. Eager loading'in alternatifi olarak kullanılır...
            // Lazy Loading => Projeye  Microsoft.EntityFrameworkCore.Proxies kütüphanesi eklenir....

            // henüz ilişkili kayıtlar yüklenmedi....
            var productList = dbContext.Products.ToList();
            // Not : veri sayısı büyüdükçe eager loading lazy loading'e göre daha performanslıdır....
            foreach (var item in productList)
            {
                // item.Supplier denildiğinde tekrar veritabanı sunucuna sorgu atılır ve ilişki kayıt getirilir...
                Console.WriteLine($"{item.ProductName} -{item.Supplier.CompanyName}");
            }
        }
    }
}