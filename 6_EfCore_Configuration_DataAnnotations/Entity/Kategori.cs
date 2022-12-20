using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EfCore_Configuration_DataAnnotations.Entity
{

    // EFCore default olarak isimlendirmede dbset adı ile tablo adını eşleştirir...

    // Konfigurasyon ile ef'Nind default ayarları devre bırakılabilir;
    // 1)DataAnnotation yöntemi // attributeler ile configuration yapılır
    // 2)Fluent Api yöntemi
    [Table("Categories")] // veritabanında tablo ismi Categoriesdir...
    public class Kategori
    {
        //  Column ile alanlar eşleştirilir...
        [Key] // PK belirlemek için kullanılır
        [Column(name: "CategoryId")]
        public int KatID { get; set; }

        [Column(name: "CategoryName")]
        public string? Adi { get; set; }

        [Column(name: "Description")]
        public string? Aciklama { get; set; }

        // NotMapped => eşleştirmek istemediğimiz alanları belirtiriz.
        [NotMapped]
        public bool Durum { get; set; }
    }
}