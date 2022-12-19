
//using _2_EfCoreFirst.Entity;

namespace _2_EfCoreFirst
{
    using Entity;
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext dbContext = new AppDbContext();
            var productResult = dbContext.Products.ToList();
            var product = productResult[0];

            // navigation property üzerinden ilişkili kaydın değerine erişilir...



            // şuan ilişkili kayıtları getirme yöntemleri ile ilgilenmiyoruz...
           // var categoryName = product.Category.CategoryName;
        }
    }
}