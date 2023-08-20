using Framework;
using Inventory.Domin.FiscalYaers;
using Inventory.Domin.InventoryVoucherItem;
using Inventory.Domin.Stores;
using Inventory.Domin.Suplier;

namespace Inventory.Domin.InventoryVoucher
{
    /// <summary>
    /// 
    /// </summary>
    public class InventoryVoucher_Shopping : GolbalGeneric
    {
        public long storeref { get; set; }
        public long nummber { get; set; }
        public long SupplierRef { get; set; }
        public DateTime Dates { get; set; }
        public int VoucherType { get; set; }
        public string Description { get; private set; }
        public long Fisicalyearref { get; set; }
        public FiscalYaer Fiscalyearref { get; set; }
        public List<InventoryVoucheritemShopping> InventoryVoucheritem { get; set; }
        public StoreAgg Store { get; set; }
        public Supplier Supplier { get; set; }

        public InventoryVoucher_Shopping(long storeref, long nummber, long supplierRef, DateTime dates, int voucherType, string description, long fisicalyearref)
        {
            this.storeref = storeref;
            this.nummber = nummber;
            SupplierRef = supplierRef;
            Dates = dates;
            VoucherType = voucherType;
            Description = description;
            Fisicalyearref = fisicalyearref;
        }

        public void Edited(long storeref, long nummber, long supplierRef, DateTime dates, int voucherType, string description, long fisicalyearref)
        {
            this.storeref = storeref;
            this.nummber = nummber;
            SupplierRef = supplierRef;
            Dates = dates;
            VoucherType = voucherType;
            Description = description;
            Fisicalyearref = fisicalyearref;
        }

    }

}
