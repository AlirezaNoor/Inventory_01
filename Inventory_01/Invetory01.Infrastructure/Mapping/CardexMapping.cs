using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Cardex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class CardexMapping:IEntityTypeConfiguration<Cardexes>
    {
        public void Configure(EntityTypeBuilder<Cardexes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.products).WithMany(x=>x.Cardexes).HasForeignKey(x=>x.propductsref);
            builder.HasOne(x => x.store).WithMany(x => x.Cardexes).HasForeignKey(x => x.storeref);
        }
    }
}
