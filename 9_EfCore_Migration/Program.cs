using _9_EfCore_Migration.Models;
using Microsoft.EntityFrameworkCore;

namespace _9_EfCore_Migration
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            AppDbContext dbContext = new AppDbContext();
            //dbContext.Database.ExecuteSql($"exec spadi");
        }
    }
}