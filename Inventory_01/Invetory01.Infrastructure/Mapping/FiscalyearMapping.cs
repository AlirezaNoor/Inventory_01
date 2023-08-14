using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.FiscalYaers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Invetory01.Infrastructure.Mapping
{
    public class FiscalyearMapping:IEntityTypeConfiguration<FiscalYaer>
    {
        public void Configure(EntityTypeBuilder<FiscalYaer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Fiscalyear");

        }
    }
}
