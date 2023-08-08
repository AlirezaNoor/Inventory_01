using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.Cities
{
    public interface ICitiesApplaiction
    {
        void create(CreateCity entity);
        EdtiedCities getdtails(long id);
        void saveedite(EdtiedCities entity);
        List<citiesviewmodels> getall();
    }
}
