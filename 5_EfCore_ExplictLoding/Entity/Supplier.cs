namespace _5_EfCore_ExplictLoding.Entity
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public List<Product> Products { get; set; }
    }
}