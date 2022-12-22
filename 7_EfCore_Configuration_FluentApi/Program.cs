using _7_EfCore_Configuration_FluentApi.Model;

namespace _7_EfCore_Configuration_FluentApi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext dbContext = new AppDbContext();
            var list = dbContext.Kategoris.ToList();


            Console.WriteLine("Hello, World!");
        }
    }
}