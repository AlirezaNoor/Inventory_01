using System.Collections;
using Framework.GnericReposetory;
using Inventory.Domin.Product;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class ProductReposetory: GenericReposetores<ProductsAgg,long>,IProductReposetory
    {
        private readonly MyContext context;

        public ProductReposetory(MyContext context):base(context)
        {
            this.context = context;
        }

        public IList forinventory(long storeref)
        {
            var test = context.AddProductTostores.Include(z => z.produccts).Where(x => x.productRef == x.produccts.Id);
            var result = test.Include(x=>x.produccts).Where(x => x.storeRef == storeref).Select(x=>new {pid=x.productRef ,name=x.produccts.ProductName});

            return result.ToList();
        }
    }
}
