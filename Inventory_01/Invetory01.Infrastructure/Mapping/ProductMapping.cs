using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class ProductMapping:IEntityTypeConfiguration<ProductsAgg>
    {
        public void Configure(EntityTypeBuilder<ProductsAgg> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.categoriesref);
            builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.brand);

        }
    }
}
