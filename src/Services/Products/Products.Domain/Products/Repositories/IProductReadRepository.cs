using Products.Domain.Dtos.Products;
using Products.Domain.Products.Models;

namespace Products.Domain.Products.Repositories
{
    public interface IProductReadRepository
    {
        #region
        Task<List<ProductCategory>> FetchAllProductCategoryAsync();
        Task<ProductCategory> FetchProductCategoryAsync(int id);
        #endregion
        #region
        Task<List<ProductBrand>> FetchAllProductBrandAsync();
        Task<ProductBrand> FetchProductBrandAsync(int id);
        #endregion
        #region
        Task<List<ProductEntity>> FetchAllProductEntityAsync();
        Task<ProductEntity> FetchProductEntityAsync(int id);
        // Task<ProductEntity> FetchProductAsync(int id);
        // Task<ProductEntity> FetchProductAsyncNoTracking(int id);
        Task<Tuple<List<ProductEntity>, int>> GetByFilterPagedAsync(ProductFilterPageReqDto request);
        Task<ProductEntity> GetAsyncNoTracking(int id);
        #endregion
    }
}
