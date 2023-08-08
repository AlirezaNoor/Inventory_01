using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domin.Cities;
using Inventory.Domin.Country;
using InventoryApplicationContract.Cities;

namespace InventoryApplication.Cities
{
    public class CtiesAppliccation:ICitiesApplaiction
    {
        private readonly ICitiesReposetory _reposetory;
        private readonly ICountriesReposetory _countries;
        public CtiesAppliccation(ICitiesReposetory reposetory, ICountriesReposetory countries)
        {
            _reposetory = reposetory;
            _countries = countries;
        }

        public void create(CreateCity entity)
        {

            var c = new City(entity.Name, entity.Countryref, entity.Description);
            _reposetory.Insert(c);
            _reposetory.Save();
        }

        public EdtiedCities getdtails(long id)
        {
            var x = _reposetory.GetById(id);
            return new EdtiedCities()
            {
                Countryref = x.Countryref,
                Description = x.Description,
                Name = x.Name,
                id = x.Id
            };
        }

        public void saveedite(EdtiedCities entity)
        {
            var x = _reposetory.GetById(entity.id);

            x.EditedCity(entity.Name, entity.Countryref, entity.Description);
            _reposetory.Save();

        }

        public List<citiesviewmodels> getall()
        {

            return _reposetory.GetAll().Select(x => new citiesviewmodels()
            {
                Name = x.Name,
                Countryname = getcountriesnames(x.Countryref),
                id = x.Id

            }).ToList();
        }



        public string getcountriesnames(long id)
        {
         return _countries.GetById(id).CountryName;
        }
    }
}
