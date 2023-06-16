using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.SubCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class SubCategoryMapping : IEntityTypeConfiguration<SubCategories>
    {
        public void Configure(EntityTypeBuilder<SubCategories> builder)
        {
            builder.ToTable("SubCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CubCategorycode).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.SubCategories).HasForeignKey(x => x.CategoryRef);
        }
    }
}
