using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.InventoryVoucherItem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class InventoryVoucherItemMapping:IEntityTypeConfiguration<InventoryVoucheritemShopping>
    {
        public void Configure(EntityTypeBuilder<InventoryVoucheritemShopping> builder)
        {
            builder.ToTable("inventoryVoucherItem");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.prdoucts).WithMany(x => x.InventoryVoucheritem).HasForeignKey(x => x.productsref);
            builder.HasOne(x => x.unit).WithMany(x => x.InventoryVoucheritem).HasForeignKey(x => x.unitref);
            builder.HasOne(x => x.InventoryVoucherShopping).WithMany(x => x.InventoryVoucheritem)
                .HasForeignKey(x => x.Inventoryoucherref);
        }
    }
}
