using Framework.GnericReposetory;
using Inventory.Domin.Product;
using Invetory01.Infrastructure.Db_Context;

namespace Invetory01.Infrastructure.Reposetory
{
    public class ProductReposetory: GenericReposetores<ProductsAgg,long>
    {
        private readonly MyContext context;

        public ProductReposetory(MyContext context):base(context)
        {
            this.context = context;
        }
    }
}
