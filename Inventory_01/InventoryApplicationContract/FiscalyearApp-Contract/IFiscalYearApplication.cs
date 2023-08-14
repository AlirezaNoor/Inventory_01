namespace InventoryApplicationContract.FiscalyearApp_Contract
{
    public interface IFiscalYearApplication
    {
        void create(CreateFiscalYear e);
        EditedFiscalyear getdtails(long id);
        void saveeditchages(EditedFiscalyear e);
        List<FiscalYearViewModel> getall();
    }
}
