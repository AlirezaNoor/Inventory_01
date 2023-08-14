using Inventory.Domin.AddProductsToStore;
using Inventory.Domin.Product;
using Inventory.Domin.Stores;
using InventoryApplicationContract.Addedproductstostore;

namespace InventoryApplication.AddproductToStore
{
    public class AddProductToStoreApp: IAddProductToStoreApp
    {
        private readonly IAddProductToStoreReposetory _reposetory;
        private readonly IStoreReposetory _store;
        private readonly IProductReposetory _product;

        public AddProductToStoreApp(IAddProductToStoreReposetory reposetory, IStoreReposetory store, IProductReposetory product)
        {
            _reposetory = reposetory;
            _store = store;
            _product = product;
        }

        public void Create(CreateAddPtoS e)
        {
            AddProductTostore addProductTostore = new(e.ProductRef, e.StoreRef);
            _reposetory.Insert(addProductTostore);
            _reposetory.Save();
        }

        public EditedAddPtoS etdtials(long id)
        {
            var x = _reposetory.GetById(id);
            return new EditedAddPtoS()
            {
                Id =x.Id,
                ProductRef = x.productRef

            };
        }

        public void edited(EditedAddPtoS e)
        {
            var x = _reposetory.GetById(e.Id);
            x.Ediited(e.ProductRef,e.StoreRef);
            _reposetory.Save();

        }

        public List<AddPtoSViewmodel> getall()
        {

            return _reposetory.GetAll().Select(x => new AddPtoSViewmodel()
            {
                Id = x.Id,
                ProductRef = _product.GetById(x.productRef).ProductName,
                StoreRef = _store.GetById(x.storeRef).StoreName

            }).ToList();
        }
    }
}
