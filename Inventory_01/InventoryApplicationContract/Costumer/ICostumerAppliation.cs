namespace InventoryApplicationContract.Costumer
{
    public interface ICostumerAppliation
    {
        void create(CreateCostumer e);
        EditCostomer getdtials(long id);
        void saverecoredchange(EditCostomer  e);

        List<Costmerview> getall();
    }
}
