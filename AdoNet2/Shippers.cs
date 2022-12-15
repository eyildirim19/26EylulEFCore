using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet2
{

    // SOLID PRENSİPLERİ
    // Single Responsibility Prencible (tek sorumluluk prensibi ) => varlıklara (sınıf, metot) tek sorumluluk yüklemektir. Shippers sınıfnın verileri tutma ve verileri getirme sorumluluğu vardır. Bu Solid'in S'sine aykırıdır. verileri Shippers sınıfında, veri getirmeyide ShippersOperation sınıfında tanımlayalım...

    public class Shippers
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
