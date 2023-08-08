namespace InventoryApplicationContract.SubCategoryContract
{
    public interface ISubCategoryApplication
    {
        void createsubcategory(CreateSubCategory comamd);
        EditedSubCategory EditeSubCategoryGetdtails(long id);
        
        void EditedSubCategryRecords ( EditedSubCategory comand);

        List<SubCategoryViewModel> showAll();

        void deleteSubcategory(long id);

        SubCategoryViewModel selected(long id);
    }
}
