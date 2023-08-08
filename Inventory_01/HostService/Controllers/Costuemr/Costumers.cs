using InventoryApplicationContract.Cities;
using InventoryApplicationContract.Costumer;
using InventoryApplicationContract.Countries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HostService.Controllers.Costuemr
{
    public class Costumers : Controller
    {
        private readonly ICostumerAppliation _costumer;
        private readonly IApplicationCountries _countries;
        private readonly ICitiesApplaiction _cities;

        public Costumers(ICostumerAppliation costumer, IApplicationCountries countries, ICitiesApplaiction cities)
        {
            _costumer = costumer;
            _countries = countries;
            _cities = cities;
        }

        public IActionResult Index()
        {
   
      
            return View(_costumer.getall());
        }

        public IActionResult CreateCostumers()
        {
            CreateCostumer createCostumer = new();
            createCostumer.countrylist = new SelectList(_countries.getcountries(), "Id", "CountryName");
            createCostumer.cityeslist = new SelectList(_cities.getall(), "id", "Name");
            return View(createCostumer);
        }

        [HttpPost]
        public IActionResult CreateCostumers(CreateCostumer command)
        {
            CreateCostumer createCostumer = new();
            _costumer.create(command);
            TempData["successMassege"] = "عملیات با موفقیت انجام شد";

            return RedirectToAction("Index");
        }
    }
}
