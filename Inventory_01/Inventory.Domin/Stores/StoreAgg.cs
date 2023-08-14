using System.Security.Cryptography.X509Certificates;
using Framework;
using Inventory.Domin.AddProductsToStore;

namespace Inventory.Domin.Stores
{
    public class StoreAgg:GolbalGeneric
    {
        public long  StoreCode { get; private set; }
        public string StoreName { get; private set; }
        public List<AddProductTostore> AddProductTostores { get; set; }
        public StoreAgg(long storeCode, string storeName)
        {
            StoreCode = storeCode;
            StoreName = storeName;
        }
        public void Edited(long storeCode, string storeName)
        {
            StoreCode = storeCode;
            StoreName = storeName;
        }
    }
}
