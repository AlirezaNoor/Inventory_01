using Framework;

namespace Inventory.Domin.InventoryVoucher
{
    /// <summary>
    /// 
    /// </summary>
    public class InventoryVoucherAgg:GolbalGeneric
    {
        public long storeref { get; set; }
        public long? storeref_transfer { get; set; }
        public long Tarafmoghabel { get; set; }
        public DateTime Dates { get; set; }
        public int noesanad { get; set; }
        public int vorod_khoroj { get; set; }

        public InventoryVoucherAgg(long storeref, long? storerefTransfer, long tarafmoghabel, DateTime dates, int noesanad, int vorodKhoroj)
        {
            this.storeref = storeref;
            storeref_transfer = storerefTransfer;
            Tarafmoghabel = tarafmoghabel;
            Dates = dates;
            this.noesanad = noesanad;
            vorod_khoroj = vorodKhoroj;
        }
        public void Edited(long storeref, long? storerefTransfer, long tarafmoghabel, DateTime dates, int noesanad, int vorodKhoroj)
        {
            this.storeref = storeref;
            storeref_transfer = storerefTransfer;
            Tarafmoghabel = tarafmoghabel;
            Dates = dates;
            this.noesanad = noesanad;
            vorod_khoroj = vorodKhoroj;
        }
    }
}
