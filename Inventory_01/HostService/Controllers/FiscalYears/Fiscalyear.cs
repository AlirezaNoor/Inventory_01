using InventoryApplicationContract.FiscalyearApp_Contract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HostService.Controllers.FiscalYears
{
    public class Fiscalyear : Controller
    {
        private readonly IFiscalYearApplication _application;

        public Fiscalyear(IFiscalYearApplication application)
        {
            _application = application;
        }

        public IActionResult Index()
        {
            return View(_application.getall());
        }
        public IActionResult CreateFiscalyear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFiscalyear(CreateFiscalYear command)
        {
            _application.create(command);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";

            return RedirectToAction("Index");
        }
    }


}
