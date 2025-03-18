using Products.Domain.Products.Models;

namespace Products.Domain.Products.Repositories
{
    public interface IProductWriteRepository
    {
        #region 
        Task<ProductCategory> AddProductCategoriesAsync(ProductCategory ProductCategory);
        Task<ProductCategory> UpdateProductCategoriesAsync(ProductCategory ProductCategory);
        Task DeleteProductCategoriesAsync(ProductCategory ProductCategory);
        #endregion
        #region 
        Task<ProductEntity> AddProductAsync(ProductEntity productEntity);
        Task<ProductEntity> UpdateProductAsync(ProductEntity productEntity);
        Task DeleteProductAsync(ProductEntity productEntity);

        #endregion
        #region 
        Task<ProductBrand> AddBrandAsync(ProductBrand ProductBrand);
        Task<ProductBrand> UpdateBrandAsync(ProductBrand ProductBrand);
        Task DeleteBrandAsync(ProductBrand ProductBrand);
        #endregion

    }
}
