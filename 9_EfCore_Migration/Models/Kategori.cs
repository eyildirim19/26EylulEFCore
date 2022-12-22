using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EfCore_Migration.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Urun> Urun { get; set; }
    }
}
