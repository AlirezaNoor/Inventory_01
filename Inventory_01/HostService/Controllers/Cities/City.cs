using InventoryApplicationContract.Cities;
using InventoryApplicationContract.Countries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Controllers.Cities
{
    public class City : Controller
    {
        private readonly ICitiesApplaiction _applaiction;
        private readonly IApplicationCountries _countries;

        public City(ICitiesApplaiction applaiction, IApplicationCountries countries)
        {
            _applaiction = applaiction;
            _countries = countries;

        }

        public IActionResult Index()
        {

            return View(_applaiction.getall());
        }

        public IActionResult CreateCity()
        {
            var model = new CreateCity();
            model.cotries = new SelectList(_countries.getcountries(), "Id", "CountryName");

            return View(model);
        }
        [HttpPost]
        public IActionResult CreateCity(CreateCity entity)
        {
            _applaiction.create(entity);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";
            return RedirectToAction("Index");

        }

    }
}
