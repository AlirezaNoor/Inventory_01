﻿using System.Security.Cryptography.X509Certificates;
using Framework;
using Inventory.Domin.AddProductsToStore;
using Inventory.Domin.Cardex;
using Inventory.Domin.InventoryVoucher;

namespace Inventory.Domin.Stores
{
    public class StoreAgg:GolbalGeneric
    {
        public long  StoreCode { get; private set; }
        public string StoreName { get; private set; }
        public List<AddProductTostore> AddProductTostores { get; set; }
        public List<InventoryVoucher_Shopping> inventory { get; set; }
        public List<Cardexes> Cardexes { get; set; }

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
