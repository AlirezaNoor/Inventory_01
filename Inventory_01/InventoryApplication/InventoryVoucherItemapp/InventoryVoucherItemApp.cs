using Inventory.Domin.InventoryVoucher;
using Inventory.Domin.InventoryVoucherItem;
using Inventory.Domin.Product;
using Inventory.Domin.Units;
using InventoryApplicationContract.InventoryVoucherItem;

namespace InventoryApplication.InventoryVoucherItemapp
{
    public class InventoryVoucherItemApp : IInventoryVoucherItemApp
    {
        private readonly IInventoryVocherItemReposetory _inventoryVocherItem;
        private readonly IProductReposetory _productReposetory;
        private readonly IUnitReposetory _unitReposetory;
        private readonly IInventoryVocherReposetory _inventoryVocherReposetory;

        public InventoryVoucherItemApp(IInventoryVocherItemReposetory inventoryVocherItem, IProductReposetory productReposetory, IUnitReposetory unitReposetory, IInventoryVocherReposetory inventoryVocherReposetory)
        {
            _inventoryVocherItem = inventoryVocherItem;
            _productReposetory = productReposetory;
            _unitReposetory = unitReposetory;
            _inventoryVocherReposetory = inventoryVocherReposetory;
        }

        public void createVoucher(List<createInventoryVoucherItem> e)
        {
            List<InventoryVoucheritemShopping> myList = new();
            foreach (var x in e)
            {
                myList.Add(new InventoryVoucheritemShopping(x.productsref, x.unitref, x.Quntity, x.Inventoryoucherref, x.Description));
            }
            _inventoryVocherItem.CreateInventoryvoucherRange(myList);
        }

        public EditedInventoryVoucherItem voucher(long id)
        {
            throw new NotImplementedException();
        }

        public void EdtiedRecoordes(EditedInventoryVoucherItem e)
        {
            throw new NotImplementedException();
        }

        public List<ViewInventoryVoucherItem> getList()
        {
            return _inventoryVocherItem.GetAll().Select(x => new ViewInventoryVoucherItem()
            {
                unitref = _unitReposetory.GetById(x.unitref).Name,
                Inventoryouchernummber = _inventoryVocherReposetory.GetById(x.Inventoryoucherref).nummber,
                Quntity = x.Quntity,
                productsref = _productReposetory.GetById(x.productsref).ProductName
            }).ToList();
        }
    }
}
