namespace InventoryApplicationContract.ProductContartct
{
    public interface IProdutsApplation
    {
        List<productlistview> getAll();
        void create(createPorducts entity);
        Productsedited getdtilsoforedites(long id);
        void SaveEditedchaanges(Productsedited entity);
        productlistview getdtails(long id);
        List<productlistview> selectdtaiils();
         
    }
}
