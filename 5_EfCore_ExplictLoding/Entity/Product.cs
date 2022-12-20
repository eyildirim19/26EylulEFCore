namespace _5_EfCore_ExplictLoding.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}