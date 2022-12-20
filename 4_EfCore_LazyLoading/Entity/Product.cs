using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EfCore_LazyLoading.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategroyId { get; set; }
        public int SupplierId { get; set; }

        // Lazy loading yönteminde navigation property virual olarak işaretlenir
        public virtual Supplier Supplier { get; set; }
    }
}