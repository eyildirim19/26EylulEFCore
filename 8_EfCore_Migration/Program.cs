namespace _8_EfCore_Migration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // önceki örneklerimizde var olan bir veritabanına kodu uyarlamaya çalıştık.

            // kodu veritabanıan migration yöntemi ile yansıtır..

            // Migration kodda yapılan değişikliğin veritabanına yansıtılmasıdır...

            // EntityFrameworkCore ve EntityFramework.SqlServer kütüphanelerine ek olarak EntityFrameworkCore.Tools kütüphanesinide package manager'den indrimemiz gerekir...

            // Tools menüsünden Package Manager Console Pencresi açılır. Package Manager console pencresi nuget package manager console pencersinin kod halidir. Orada yapıaln herşey burada kod ile yapılabilir...
            
            // add-migration ile migration dosyası oluşturulur...

            // update-database ile güncel migration dosyasındaki ifadeler veritabanına yansıtılır. (eğer veritabanı yoksa veritabanı oluşturulur)

            //projedeki dbcontext sınımız referans alınarak migration dosyası oluşturulur...

            Console.WriteLine("Hello, World!");
        }
    }
}