using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Inventory.Domin.Product;

namespace Inventory.Domin.Brand
{
    public class BrandAgg:GolbalGeneric
    {
        public String name { get; private set; }
        public string desicription { get; private set; }
        public List<ProductsAgg> Products { get; private set; }


        public BrandAgg(string name, string desicription)
        {
            this.name = name;
            this.desicription = desicription;
        }

        public void Edited(string name, string desicription)
        {
            this.name = name;
            this.desicription = desicription;
        }

}
}
