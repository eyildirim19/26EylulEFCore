using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EfCore_Migration.Models
{
    public class Urun
    {
        public int UId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? KatID { get; set; }
        public Kategori Kategori { get; set; }
    }
}
