using HostService.Models;
using Inventory.Domin.InventoryVoucher;
using InventoryApplicationContract.Addedproductstostore;
using InventoryApplicationContract.Cardex;
using InventoryApplicationContract.InventoryVochuer;
using InventoryApplicationContract.InventoryVoucherItem;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.Supplier;
using InventoryApplicationContract.UnitCantrat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HostService.Controllers.PurchuseVoucher
{
    public class Purchuse : Controller
    {
        private readonly IInventoryVoucherApp _inventoryVoucher;
        private readonly IInventoryVoucherItemApp _inventoryVoucherItem;
        private readonly IAddProductToStoreApp _addProductToStoreApp;
        private readonly IProdutsApplation _produts;
        private readonly IUnitAplication _unit;
        private readonly ISupplierApplicaation _supplier;
        private readonly ICardexApp _cardex;

        public Purchuse(IInventoryVoucherApp inventoryVoucher, IInventoryVoucherItemApp inventoryVoucherItem, IAddProductToStoreApp addProductToStoreApp, IProdutsApplation produts, IUnitAplication unit, ISupplierApplicaation supplier, ICardexApp cardex)
        {
            _inventoryVoucher = inventoryVoucher;
            _inventoryVoucherItem = inventoryVoucherItem;
            _addProductToStoreApp = addProductToStoreApp;
            _produts = produts;
            _unit = unit;
            _supplier = supplier;
            _cardex = cardex;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            InventoryVoucherItem voucher = new();
            var products = _produts.getAll();
            voucher.products = new SelectList(_addProductToStoreApp.getallininventory(), "ProductReff", "ProductRef");
            voucher.store = new SelectList(_addProductToStoreApp.getallininventory(), "StoreReff", "StoreRef");
            voucher.unit = new SelectList(_unit.getAllUnit(), "id", "name");
            voucher.supplier = new SelectList(_supplier.getall(), "Id", "SupplierName");
            return View(voucher);
        }
        [HttpPost]
        public IActionResult Create([FromBody] IList<InventoryVoucherItem> test)
        {
            List<InventoryVoucherItem> my = new();
            my = test.ToList();
            var arr = my.ToArray();


            var inventory = arr[0];
            if (inventory.nummber == 0 || inventory.Dates == null || inventory.SupplierRef == null || inventory.storeref == null)
            {
                throw new Exception();
            }

            var number = inventory.nummber;
            var store = inventory.storeref;
            var supplier = inventory.SupplierRef;
            var date = inventory.Dates;
            var descriptioion = "dddd";
            var type = inventory.VoucherType;
            CreateInventoryVoucher vocher = new CreateInventoryVoucher();
            vocher.nummber = number;
            vocher.storeref = store;
            vocher.Dates = DateTime.Today;
            vocher.Description = descriptioion;
            vocher.VoucherType = type;
            vocher.SupplierRef = supplier;
            vocher.fisicalyearref = 1;
            _inventoryVoucher.createVoucher(vocher);
            var myvocher = _inventoryVoucher.getList().MaxBy(x => x.Id);
            if (myvocher == null)
            {
                throw new Exception();
            }

            List<createInventoryVoucherItem> voucherItem = new();
            var result = my.Select(x => new createInventoryVoucherItem()
            {
                productsref = x.ProductsRef,
                Description = x.Description,
                Inventoryoucherref = _inventoryVoucher.getList()[0].Id,
                Quntity = x.Quantity,
                unitref = x.UnitRef
            }).ToList();

            _inventoryVoucherItem.createVoucher(result);
            CreateCardex c = new();
          var cardex=  my.Select(x => new CreateCardex()
            {
                transactiondate = DateTime.Today,
                Quantity = x.Quantity,
                propductsref = x.ProductsRef,
                storeref = x.storeref,
                vorodkhoroj = x.VoucherType
        }).ToList();
            _cardex.createCardex(cardex);
            return RedirectToAction("Index");
        }
     }
}
