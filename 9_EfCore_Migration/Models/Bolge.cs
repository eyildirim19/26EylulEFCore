using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EfCore_Migration.Models
{
    // Bolge sınıfı vt'deki Bolge tablosuna göre uyarlıyoruz...
    public class Bolge
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
}