using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.Products;
using MedicalShop.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Infrastructure.Products
{
    public class ProductWriteRepository: IProductWriteRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductWriteRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region 
      public async Task<ProductEntity> AddProductCategoriesAsync(ProductEntity product)
        {
            var result=await _dbContext.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<ProductEntity> UpdateProductCategoriesAsync(ProductEntity product)
        {
            var result =  _dbContext.Update(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteProductCategoriesAsync(ProductEntity product)
        {
             _dbContext.products.Remove(product);
            await _dbContext.SaveChangesAsync();
                    }
        #endregion
        #region 
       public async Task<Product_Category> AddProductAsync(Product_Category product_Category)
        {
            var result = await _dbContext.AddAsync(product_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
      public async  Task<Product_Category> UpdateProductAsync(Product_Category product_Category)
        {
            var result = _dbContext.Update(product_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteProductAsync(Product_Category product_category)
        {
            _dbContext.category.Remove(product_category);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region 
       public async Task<Product_Brand> AddBrandAsync(Product_Brand product_Brand)
        {
            var result = _dbContext.Update(product_Brand);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Product_Brand> UpdateBrandAsync(Product_Brand product_Brand)
        {
            var result = _dbContext.Update(product_Brand);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteBrandAsync(Product_Brand product_Brand)
        {
            _dbContext.brands.Remove(product_Brand);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
