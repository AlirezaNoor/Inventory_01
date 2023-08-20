using System.Reflection.Metadata.Ecma335;
using Framework;
using Inventory.Domin.Product;
using Inventory.Domin.Stores;

namespace Inventory.Domin.Cardex
{
    public  class Cardexes:GolbalGeneric
    {
        public long storeref { get; set; }
        public long  propductsref { get; set; }
        public DateTime transactiondate { get; set; }
        public long vorodkhoroj { get; set; }
        public long Quantity { get; set; }
        public ProductsAgg products { get; set; }
        public StoreAgg store { get; set; }
        public Cardexes(long storeref, long propductsref, DateTime transactiondate, long vorodkhoroj, long quantity)
        {
            this.storeref = storeref;
            this.propductsref = propductsref;
            this.transactiondate = transactiondate;
            this.vorodkhoroj = vorodkhoroj;
            Quantity = quantity;
        }
    }
}
