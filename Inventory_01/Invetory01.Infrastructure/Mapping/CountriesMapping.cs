using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Country;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class CountriesMapping:IEntityTypeConfiguration<Countreis>
    {
        public void Configure(EntityTypeBuilder<Countreis> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Counnty");
        }
    }
}
