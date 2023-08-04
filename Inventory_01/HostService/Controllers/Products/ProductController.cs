using HostService.Models;
using InventoryApplication.Unit;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.UnitCantrat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IronBarCode;


namespace HostService.Controllers.Products
{
    public class ProductController : Controller
    {
        private readonly IProdutsApplation _produts;
        private readonly ISubCategoryApplication _subCategory;
        private readonly ICategoresApplictaion _categoresApplictaion;
        private readonly IUnitAplication _aplication;
        private readonly IBrandApplication _brandaplication;
        private readonly IWebHostEnvironment _environment;

        public ProductController(IProdutsApplation produts, IUnitAplication aplication, ICategoresApplictaion categoresApplictaion, ISubCategoryApplication subCategory, IBrandApplication brandaplication, IWebHostEnvironment environment)
        {
            _produts = produts;
            _aplication = aplication;
            _categoresApplictaion = categoresApplictaion;
            _subCategory = subCategory;
            _brandaplication = brandaplication;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var test = _produts.getAll();
            return View(test);
        }
        [HttpGet]
        public IActionResult addproduct()
        {
            var objects = new productModels();
            objects.Category_view_model = new SelectList(_categoresApplictaion.showAll(), "Id", "CategoryName");
            objects.subCategory_view_model = new SelectList(_subCategory.showAll(), "Id", "Name");
            objects.Unit_list = new SelectList(_aplication.getAllUnit(), "id", "name");
            objects.brnd_view_model = new SelectList(_brandaplication.showAll(), "Id", "name");
            return View(objects);
        }
        [HttpPost]
        public IActionResult addproduct(productModels command)
        {
            _produts.create(command.CreatePorducts);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";

            return RedirectToAction("Index");
        }

        public IActionResult Dtails(long id)
        {
            var productdtails = _produts.getdtails(id);
            GeneratedBarcode barcode = IronBarCode.BarcodeWriter.CreateBarcode(productdtails.sku, BarcodeWriterEncoding.Code128);
            barcode.ResizeTo(400, 120);
            barcode.ChangeBarCodeColor(Color.BlueViolet);
            barcode.SetMargins(10);
            string path = Path.Combine(_environment.WebRootPath, "GeneratedBarcode");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = Path.Combine(_environment.WebRootPath, "GeneratedBarcode/barcode.png");
            barcode.SaveAsPng(filePath);
            string fileName = Path.GetFileName(filePath);
            string imageUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}" + "/GeneratedBarcode/" + fileName;
            ViewBag.QrCodeUri = imageUrl;

            return View(productdtails);
        }
    }

}
