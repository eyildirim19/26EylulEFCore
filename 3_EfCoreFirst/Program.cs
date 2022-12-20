namespace _3_EfCoreEagerLoading
{
    using Entity;
    using Microsoft.EntityFrameworkCore;

    internal class Program
    {
        static void Main(string[] args)
        {
            // ilişkili kayıtları çekme
            //Eager Loading Yöntemi => ilişkili objeler için sql server'a sorgu gönderilir. iligli örnekte tek sefer'de product ve category sorguları atılacaktır...

            // Include => ilişkili kaydı çekmek için navigation property include ile sorguya dahil edilir...
            AppDbContext db = new AppDbContext();

            var productList = db.Products
                .Include(c => c.Category) // Categroy'i sorguya dahil et...
                //.Take(10)  // => take => sql'deki top ifadesidir..
                .ToList();

            foreach (var item in productList)
            {
                Console.WriteLine($"{item.ProductName} {item.CategoryId} {item.Category.CategoryName}");
            }
        }
    }
}