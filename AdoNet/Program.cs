
using System.Data.SqlClient;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ado.Net (Activex Data Object)");
            // SqlConnection => veritabanı ile uygulama arasında bağlantı oluşturmak için kullanılır...
            // connectionstring => veritabanı yolunu ifade eder...
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Server=.\MSSQL2019; Database=Northwind; uid=sa;pwd=123";
            cnn.Open(); // bağlantı açılır.....

            // SqlCommand => sql ifadeleri yazmak için kullanılır
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select  * from Shippers";
            cmd.Connection = cnn;
            // execute edilir..
            //SqlDataReader => kayıtları okumak için kullanılır. sırası ile kayıtlar okunur ve satıra erişilir..
            // satırı okudu ise true döner. ve okunan satıra readr nesnesinden erişilir..eğer okunacak satır yoksa false döner...
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
            }
            cnn.Close(); // bağlantıyı kapat...
        }
    }
}