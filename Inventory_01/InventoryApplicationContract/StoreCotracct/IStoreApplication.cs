namespace InventoryApplicationContract.StoreCotracct
{
    public interface IStoreApplication
    {
        void Ceaate(CreateStore e);
        Editedstore getdtailforEditd(long id);
        void Edited(Editedstore e);
        List<StoreViewmodel> getstores();
    }
}
