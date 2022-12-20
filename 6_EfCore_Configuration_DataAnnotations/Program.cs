namespace _6_EfCore_Configuration_DataAnnotations
{
    using Entity;
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext dbContext = new AppDbContext();

            var list = dbContext.Kategoriler.ToList();

            foreach (var item in list)
                Console.WriteLine($"{item.KatID} {item.Adi} {item.Aciklama}");
        }
    }
}