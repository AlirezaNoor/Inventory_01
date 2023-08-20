using Inventory.Domin.InventoryVoucher;
using Inventory.Domin.Stores;
using Inventory.Domin.Supliers;
using InventoryApplicationContract.InventoryVochuer;

namespace InventoryApplication.inventoryVoucher
{
    public class inventoryvoucherApp : IInventoryVoucherApp
    {
        private readonly IInventoryVocherReposetory _reposetory;
        private readonly IStoreReposetory _storeReposetory;
        private readonly ISupplierReposetory _supplierReposetory;

        public inventoryvoucherApp(IInventoryVocherReposetory reposetory, IStoreReposetory storeReposetory, ISupplierReposetory supplierReposetory)
        {
            _reposetory = reposetory;
            this._storeReposetory = storeReposetory;
            _supplierReposetory = supplierReposetory;
        }

        public void createVoucher(CreateInventoryVoucher e)
        {
            var inventoryvoucher = new InventoryVoucher_Shopping(e.storeref, e.nummber, e.SupplierRef, e.Dates,
                e.VoucherType, e.Description,e.fisicalyearref);
            _reposetory.Insert(inventoryvoucher);
            _reposetory.Save();
        }

        public EditedInventoryvoucher voucher(long id)
        {

            var x = _reposetory.GetById(id);
            return new EditedInventoryvoucher()
            {
                Id = x.Id,
                Description = x.Description,
                Dates = x.Dates,
                SupplierRef = x.SupplierRef,
                VoucherType = x.VoucherType,
                nummber =x.nummber,
                storeref = x.storeref,
            };
        }

        public void EdtiedRecoordes(EditedInventoryvoucher e)
        {
            var inventoryvoucher = _reposetory.GetById(e.Id);
            inventoryvoucher.Edited(e.storeref, e.nummber, e.SupplierRef, e.Dates,
                e.VoucherType, e.Description, e.fisicalyearref);

            _reposetory.Save();
        }

        public List<ViewInventoryVoucher> getList()
        {
            return _reposetory.GetAll().Select(x => new ViewInventoryVoucher()
            {
                storeref = _storeReposetory.GetById(x.storeref).StoreName,
                Dates = x.Dates,
                Id = x.Id,
                SupplierRef = _supplierReposetory.GetById(x.SupplierRef).SupplierName,
                nummber = x.nummber,
            }).ToList();
        }
    }
}
