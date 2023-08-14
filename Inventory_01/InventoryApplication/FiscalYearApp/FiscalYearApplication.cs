using Inventory.Domin.FiscalYaers;
using InventoryApplicationContract.FiscalyearApp_Contract;

namespace InventoryApplication.FiscalYearApp
{
    public class FiscalYearApplication: IFiscalYearApplication
    {
        private readonly IFiscalyearReposetory _reposetory;

        public FiscalYearApplication(IFiscalyearReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public void create(CreateFiscalYear e)
        {
            FiscalYaer fiscalYaer=new FiscalYaer(e.name,e.desccription,e.SDateTime,e.SDateTime);
            _reposetory.Save();
        }

        public EditedFiscalyear getdtails(long id)
        {
            var x = _reposetory.GetById(id);

            return new EditedFiscalyear()
            {
                Id = x.Id,
                name = x.name,
                desccription = x.desccription,
                EDateTime = x.eDateTime,
                SDateTime = x.eDateTime,
            };
        }

        public void saveeditchages(EditedFiscalyear e)
        {
            var x = _reposetory.GetById(e.Id);
            x.ediited(e.name, e.desccription,e.SDateTime,e.EDateTime);
            _reposetory.Save();
        }

        public List<FiscalYearViewModel> getall()
        {
            return _reposetory.GetAll().Select(x => new FiscalYearViewModel()
            {
                Id = x.Id,
                name = x.name,
                desccription = x.desccription,
                
            }).ToList();
        }
    }
}
