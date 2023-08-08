using InventoryApplicationContract.Countries;
using Inventory.Domin.Country;

namespace InventoryApplication.CountryApplication
{
    public class CountryApplication: IApplicationCountries
    {
        private readonly ICountriesReposetory _reposetory;

        public CountryApplication(ICountriesReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public void Createcounntris(CreateCountry entity)
        {
            var c = new Countreis(entity.CountryName, entity.RegionRegion, entity.Description);
            _reposetory.Insert(c);
            _reposetory.Save();
        }

        public EditedCountries getdtailsforedited(long id)
        {
            var x = _reposetory.GetById(id);
            return new EditedCountries()
            {
            CountryName    = x.CountryName,
            Description = x.Description,
            Id = x.Id,
            RegionRegion =x.RegionRegion
            };
        }

        public void editedrecord(EditedCountries entity)
        {
            var x = _reposetory.GetById(entity.Id);
            x.Edted(entity.CountryName, entity.RegionRegion, entity.Description);
            _reposetory.Save();

        }

        public List<CountryViewmodel> getcountries()
        {
            return _reposetory.GetAll().Select(x => new CountryViewmodel()
            {
                CountryName = x.CountryName,
                RegionRegion = x.RegionRegion,
                Id = x.Id,

            }).ToList();
        }
    }
}
