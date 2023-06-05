using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.CategoryAgg;
using Invetory01.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Db_Context
{
    public  class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Categores> categores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
        }
    }
}
