using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EfCore_Configuration_FluentApi.Configuration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    // IEntityTypeConfiguration => EntityFrameworkCore namespace'i eklenir..

    using Model; // Nakliye sınıfına erişmek için namespace eklenir...
    public class NakliyeConfiguration : IEntityTypeConfiguration<Nakliye>
    {
        public void Configure(EntityTypeBuilder<Nakliye> builder)
        {
            builder.HasKey(c => c.NakId); // pk alanı

            builder.Property(c => c.NakId)
                .HasColumnName("ShipperId");

            builder.Property(c => c.NakName)
                .HasColumnName("CompanyName");

            builder.ToTable("Shippers"); // Shippers tablosu ile eşleş...
        }
    }
}
