using Inventory.Domin.CategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class CategoryMapping:IEntityTypeConfiguration<Categores>
    {
        public void Configure(EntityTypeBuilder<Categores> builder)
        {
            builder.ToTable("Categores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descirption).HasMaxLength(999).IsRequired();

        }
    }
}
