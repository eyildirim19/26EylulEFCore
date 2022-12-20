namespace _5_EfCore_ExplictLoding
{
    using Entity;
    using Microsoft.EntityFrameworkCore;

    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext dbContext = new AppDbContext();
            // İlişkili kayıtları getirmenin bir diğer yöntemidir...
            // Explicit Loaiding
            var tedaricis = dbContext
                .Suppliers
                .ToList();

            foreach (var item in tedaricis)
            {
                // Collection => liste olarak döndürür...
                // Reference => tek bir obje döndürür
                // Lazy loading gibi. 
                dbContext.Entry(item).Collection(c => c.Products).Load(); // Product yüklenir
                int ProductCount = item.Products.Count;

                Console.WriteLine($"{item.CompanyName} Ürün Adet {ProductCount}");
            }

            Product p = dbContext.Products.Find(1);
            dbContext.Entry(p).Reference(c => c.Supplier).Load();
            Supplier s = p.Supplier;
        }
    }
}