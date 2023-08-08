using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Costumer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class CostumerMapping:IEntityTypeConfiguration<Costmers>
    {
        public void Configure(EntityTypeBuilder<Costmers> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Costumer");
            builder.HasOne(x => x.Countreis).WithMany(x => x.Costmers).HasForeignKey(x => x.Countryref);

        }
    }
}
