namespace AdoNet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Suppliers için yapılsın...(Ödev)


            // ORM (Object Relational mapping)

            Console.WriteLine("Hello, World!");

            ShippersOperation shippersOperation = new ShippersOperation();
            List<Shippers> shipList = shippersOperation.ShipList();

            Shippers shp = new Shippers();

            Console.WriteLine("Şirket Adı Giriniz");
            shp.CompanyName = Console.ReadLine();

            Console.WriteLine("Telefon ????");
            shp.Phone = Console.ReadLine();

            int result = shippersOperation.Add(shp);

            if (result > 0)
                Console.WriteLine("İşlem Başarılı");
            else
                Console.WriteLine("İşlem Başarısız");



            foreach (var item in shipList)
            {

                // item.CompanyName, item.Phone
            }

        }
    }
}