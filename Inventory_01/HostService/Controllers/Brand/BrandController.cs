using InventoryApplicationContract.BrandApplicationContract;
using Microsoft.AspNetCore.Mvc;

namespace HostService.Controllers.Brand
{
    public class BrandController : Controller
    {
        private readonly IBrandApplication _application;
        private readonly IHostEnvironment _env;
        public BrandController(IBrandApplication application, IHostEnvironment env)
        {
            _application = application;
            _env = env;
        }

        public IActionResult Index()
        {
            var test=_application.showAll();
            return View(test);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBrand command)
        {
            _application.createsubcategory(command);
            var uniqueFileName = Path.GetFileName(command.imgge.FileName);
           var tasvir= Path.GetFileNameWithoutExtension(command.name)

                   + Path.GetExtension(command.imgge.FileName);
            var dir = Path.Combine(_env.ContentRootPath, @"wwwroot\Img\Brand");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var filePath = Path.Combine(dir, tasvir);
             command.imgge.CopyToAsync(new FileStream(filePath, FileMode.Create));

             TempData["successMassege"] = "عملیات با موفقیت انجام شد";
             return RedirectToAction("Index");
        }

        public IActionResult Edited(long id)
        {
         var edited=   _application.EditeSubCategoryGetdtails(id);
            return View(edited);
        }
        [HttpPost]
        public IActionResult Edited(EditedBrand commaBrand)
        {
            _application.EditedSubCategryRecords(commaBrand);
            var uniqueFileName = Path.GetFileName(commaBrand.imgge.FileName);
            var tasvir = Path.GetFileNameWithoutExtension(commaBrand.name)

                         + Path.GetExtension(commaBrand.imgge.FileName);
            var dir = Path.Combine(_env.ContentRootPath, @"wwwroot\Img\Brand");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var filePath = Path.Combine(dir, tasvir);
            commaBrand.imgge.CopyToAsync(new FileStream(filePath, FileMode.Create));
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";

            return RedirectToAction("Index");
        }
    }
}
