using Framework;
using Inventory.Domin.Cities;
using Inventory.Domin.Country;

namespace Inventory.Domin.Suplier
{
    public class Supplier:GolbalGeneric
    {
        public  string SupplierName { get; private set; }
        public string Email { get; private set; }
        public long counteryref { get; private set; }
        public long Cityref { get; private set; }
        public string phone { get; private set; }

        public string Addresss { get; private set; }
        public string Description { get; private set; }


        public Supplier(string supplierName, string email, long counteryref, long cityref, string phone, string addresss, string description)
        {
            SupplierName = supplierName;
            Email = email;
            this.counteryref = counteryref;
            Cityref = cityref;
            this.phone = phone;
            Addresss = addresss;
            Description = description;
        }

        public void EditedSupplierr(string supplierName, string email, long counteryref, long cityref, string phone, string addresss, string description)
        {
            SupplierName = supplierName;
            Email = email;
            this.counteryref = counteryref;
            Cityref = cityref;
            this.phone = phone;
            Addresss = addresss;
            Description = description;
        }
    }
}
