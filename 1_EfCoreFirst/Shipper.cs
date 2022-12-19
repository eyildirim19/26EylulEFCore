using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_EfCoreFirst
{

    // ID veya SınıfAdiID pk sayılır...
    // Entity içerisinde Id veya SinifAdiId alanı varsayılan olarak pk kabul edilir..
    // DbSet ismide tablo ismi olarak kabul edilir...
    public class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
