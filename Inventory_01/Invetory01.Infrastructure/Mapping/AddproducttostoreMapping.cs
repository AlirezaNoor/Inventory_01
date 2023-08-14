using Inventory.Domin.AddProductsToStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class AddproducttostoreMapping:IEntityTypeConfiguration<AddProductTostore>
    {
        public void Configure(EntityTypeBuilder<AddProductTostore> builder)
        {
            builder.ToTable("AddProductsToStore");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Store).WithMany(x => x.AddProductTostores).HasForeignKey(x => x.storeRef);
            builder.HasOne(x => x.produccts).WithMany(x => x.AddProductTostores).HasForeignKey(x => x.productRef);
        }
    }
}
