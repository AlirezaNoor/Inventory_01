using InventoryApplicationContract.Countries;
using Microsoft.AspNetCore.Mvc;

namespace HostService.Controllers.Countries
{
    public class Countries : Controller
    {
        public readonly IApplicationCountries _countries;

        public Countries(IApplicationCountries countries)
        {
            _countries = countries;
        }
        [HttpGet]
        public IActionResult Index()
        {  
            var model=  _countries.getcountries();

            return View(model);
        }
        [HttpGet]
        public IActionResult CereatCouuntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CereatCouuntry(CreateCountry command)
        {
            _countries.Createcounntris(command);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";

            return RedirectToAction("Index");
        }
    }
}
