using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Inventory.Domin.Product;
using Inventory.Domin.Stores;

namespace Inventory.Domin.AddProductsToStore
{
    public class AddProductTostore : GolbalGeneric
    {
        public long productRef { get; private set; }
        public long storeRef { get; private set; }
        public ProductsAgg produccts { get; set; }
        public StoreAgg Store { get; set; }

        public AddProductTostore(long productRef, long storeRef)
        {
            this.productRef = productRef;
            this.storeRef = storeRef;
        }
        public void Ediited(long productRef, long storeRef)
        {
            this.productRef = productRef;
            this.storeRef = storeRef;
        }
    }
}
