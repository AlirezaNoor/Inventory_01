namespace InventoryApplicationContract.InventoryVochuer
{
    public class CreateInventoryVoucher
    {
        public long storeref { get; set; }
        public long nummber { get; set; }
        public long SupplierRef { get; set; }
        public DateTime Dates { get; set; }
        public int VoucherType { get; set; }
        public string Description { get;  set; }
    }

 
}
