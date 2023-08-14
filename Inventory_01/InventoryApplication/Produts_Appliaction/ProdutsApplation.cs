using Inventory.Domin.Product;
using InventoryApplicationContract.BrandApplicationContract;
using InventoryApplicationContract.Categores;
using InventoryApplicationContract.ProductContartct;
using InventoryApplicationContract.SubCategoryContract;
using InventoryApplicationContract.UnitCantrat;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace InventoryApplication.Produts_Appliaction
{
    public class ProdutsApplation : IProdutsApplation
    {
        private readonly IProductReposetory _reposetory;
        private readonly IBrandApplication _brand;
        private readonly ICategoresApplictaion _categoresApplictaion;
        private readonly ISubCategoryApplication _subcategoresApplictaion;
        private readonly IUnitAplication _unit;
        public ProdutsApplation(IProductReposetory reposetory, IBrandApplication brand, ICategoresApplictaion categoresApplictaion, ISubCategoryApplication subcategoresApplictaion, IUnitAplication unit)
        {
            _reposetory = reposetory;
            _brand = brand;
            _categoresApplictaion = categoresApplictaion;
            _subcategoresApplictaion = subcategoresApplictaion;
            _unit = unit;
        }
        public List<productlistview> getAll()
        {
            return _reposetory.GetAll().Select(x => new productlistview()
            {
                baand = _brand.showAll().FirstOrDefault(z => z.Id == x.brand).name,
                name = x.ProductName,
                Id = x.Id,
                cateoryref = _categoresApplictaion.showAll().FirstOrDefault(z => z.Id == x.categoriesref).CategoryName,
                price = x.price,
                sku = x.Sku,
                unit = _unit.getAllUnit().FirstOrDefault(z => z.id == x.unitref).name,
                subcateoryref = _subcategoresApplictaion.showAll().FirstOrDefault(z => z.Id == x.subcategoriesref).Name,
                Tax = x.Tax,
                Discuont = x.Discuont,
                statuse = x.statuse,
                minmuimQty = x.minmuimQty






            }).ToList();

        }

        public void create(createPorducts entity)
        {
            var produts = new ProductsAgg(entity.ProductName, entity.categoriesref, entity.brand, entity.unitref,
                entity.Sku,
                entity.Qty, entity.minmuimQty, entity.Tax, entity.Discuont, entity.price, entity.statuse, entity.subcategoriesref);
            _reposetory.Insert(produts);
            _reposetory.Save();
        }

        public Productsedited getdtilsoforedites(long id)
        {
            var dtails = _reposetory.GetById(id);
            return new Productsedited()
            {
                unitref = dtails.unitref,
                Discuont = dtails.Discuont,
                Id = dtails.Id,
                ProductName = dtails.ProductName,
                Sku = dtails.Sku,
                Tax = dtails.Tax,
                price = dtails.price,
                Qty = dtails.Qty,
                brand = dtails.brand,
                categoriesref = dtails.categoriesref,
                minmuimQty = dtails.minmuimQty,
                statuse = dtails.statuse,
                subcategoriesref = dtails.subcategoriesref
            };
        }

        public void SaveEditedchaanges(Productsedited entity)
        {
            var dtails = _reposetory.GetById(entity.Id);
            dtails.Edited(entity.ProductName, entity.categoriesref, entity.brand, entity.unitref,
                entity.Sku,
                entity.Qty, entity.minmuimQty, entity.Tax, entity.Discuont, entity.price, entity.statuse, entity.subcategoriesref);
            _reposetory.Save();
        }

        public productlistview getdtails(long id)
        {
            var x = _reposetory.GetById(id);

            return new productlistview()
            {
                baand = _brand.showAll().FirstOrDefault(z => z.Id == x.brand).name,
                name = x.ProductName,
                Id = x.Id,
                cateoryref = _categoresApplictaion.showAll().FirstOrDefault(z => z.Id == x.categoriesref).CategoryName,
                price = x.price,
                sku = x.Sku,
                unit = _unit.getAllUnit().FirstOrDefault(z => z.id == x.unitref).name,
                subcateoryref = _subcategoresApplictaion.showAll().FirstOrDefault(z => z.Id == x.subcategoriesref).Name,
                Tax = x.Tax,
                Discuont = x.Discuont,
                statuse = x.statuse,
                minmuimQty = x.minmuimQty
            };
        }

        public List<productlistview> selectdtaiils()
        {
            return _reposetory.GetAll().Select(x => new productlistview()
            {
                name = x.ProductName,
                Id = x.Id,






            }).ToList();
        }
    }
}
