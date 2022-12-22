using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EfCore_Migration.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public int? UstKatId { get; set; }
    }
}