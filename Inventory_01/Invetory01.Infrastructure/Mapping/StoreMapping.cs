using Inventory.Domin.Stores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class StoreMapping:IEntityTypeConfiguration<StoreAgg>
    {
        public void Configure(EntityTypeBuilder<StoreAgg> builder)
        {
            builder.ToTable("store");
            builder.HasKey(x => x.Id);
        }
    }
}
