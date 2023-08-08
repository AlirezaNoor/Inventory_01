using Microsoft.Extensions.Logging;

namespace InventoryApplicationContract.Countries
{
    public interface IApplicationCountries
    {
        void Createcounntris(CreateCountry entity);
        EditedCountries getdtailsforedited(long id);
        void editedrecord(EditedCountries entity);
        List<CountryViewmodel> getcountries();
    }
}
