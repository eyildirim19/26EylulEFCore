using _9_EfCore_Migration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EfCore_Migration.Mapping
{
    public class UrunConfiguration : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(c => c.UId);
            builder.Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false); // vt tarafında alan null olur. eğer alan nullable değilse null değerli data uygulama patlar..

            builder.Property(c => c.Price)
                .HasPrecision(5, 2)
                .HasDefaultValue(1); // default değer

            // navigtaion property olduğu için relation yapacak ama ben benim belirttiğim alan üzerinden relation yapmasını istiyorum....

            builder.HasOne(c => c.Kategori) // urun sınının kategori propertisi
                .WithMany(c => c.Urun)
                .HasForeignKey(c=> c.KatID); // kategori sınıfın urun propertisi
        }
    }
}