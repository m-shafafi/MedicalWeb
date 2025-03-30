using Products.Domain.Products.Models;
using Products.Domain.Products.Repositories;

namespace Products.Infrastructure.Products
{
    public class ProductWriteRepository : IProductWriteRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductWriteRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region 
        public async Task<ProductCategory> AddProductCategoriesAsync(ProductCategory ProductCategory)
        {
            var result = await _dbContext.AddAsync(ProductCategory);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<ProductCategory> UpdateProductCategoriesAsync(ProductCategory ProductCategory)
        {
            var result = _dbContext.Update(ProductCategory);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteProductCategoriesAsync(ProductCategory ProductCategory)
        {
            _dbContext.Categories.Remove(ProductCategory);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region 
        public async Task<ProductEntity> AddProductAsync(ProductEntity productEntity)
        {
            var result = await _dbContext.AddAsync(productEntity);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<ProductEntity> UpdateProductAsync(ProductEntity productEntity)
        {
            var result = _dbContext.Update(productEntity);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteProductAsync(ProductEntity productEntity)
        {
            _dbContext.Products.Remove(productEntity);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region 
        public async Task<ProductBrand> AddBrandAsync(ProductBrand ProductBrand)
        {
            var result = await _dbContext.AddAsync(ProductBrand);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<ProductBrand> UpdateBrandAsync(ProductBrand ProductBrand)
        {
            var result = _dbContext.Update(ProductBrand);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteBrandAsync(ProductBrand ProductBrand)
        {
            _dbContext.Brands.Remove(ProductBrand);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
