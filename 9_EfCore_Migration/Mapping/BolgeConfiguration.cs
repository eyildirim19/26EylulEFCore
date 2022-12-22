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
    public class BolgeConfiguration : IEntityTypeConfiguration<Bolge>
    {
        public void Configure(EntityTypeBuilder<Bolge> builder)
        {
            // Migration'a dahil etme....
            builder.ToTable("Bolge", c => c.ExcludeFromMigrations(true));
        }
    }
}
