using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Cities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class CityMapping:IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("City");
            builder.HasOne(x => x.Countreis).WithMany(x => x.Cities).HasForeignKey(x => x.Countryref);
        }
    }
}
