using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Brand;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    internal class BrandMapping:IEntityTypeConfiguration<BrandAgg>
    {
        public void Configure(EntityTypeBuilder<BrandAgg> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Products).WithOne(x => x.Brand).HasForeignKey(x => x.brand);
        }
    }
}
