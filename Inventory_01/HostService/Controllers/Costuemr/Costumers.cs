using InventoryApplicationContract.Cities;
using InventoryApplicationContract.Costumer;
using InventoryApplicationContract.Countries;
using Microsoft.AspNetCore.Mvc;

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
    }
}
