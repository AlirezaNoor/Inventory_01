using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.InventoryVoucher;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class InventoryVoucherMapping:IEntityTypeConfiguration<InventoryVoucher_Shopping>
    {
        public void Configure(EntityTypeBuilder<InventoryVoucher_Shopping> builder)
        {
            builder.ToTable("InventoryVoucher");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Store).WithMany(x => x.inventory).HasForeignKey(x => x.storeref);
            builder.HasOne(x => x.Supplier).WithMany(x => x.inventory).HasForeignKey(x => x.SupplierRef);
        }
    }
}
