using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.News.Article;
using MedicalShop.Domain.Products;
using MedicalShop.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Infrastructure.Products
{
    public class NewsWriteRepository: INewsWriteRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public NewsWriteRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region 
      public async Task<Product_Category> AddProductCategoriesAsync(Product_Category product_Category)
        {
            var result=await _dbContext.AddAsync(product_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Product_Category> UpdateProductCategoriesAsync(Product_Category product_Category)
        {
            var result =  _dbContext.Update(product_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteProductCategoriesAsync(Product_Category product_Category)
        {
             _dbContext.category.Remove(product_Category);
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
      public async  Task<ProductEntity> UpdateProductAsync(ProductEntity productEntity)
        {
            var result = _dbContext.Update(productEntity);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteProductAsync(ProductEntity productEntity)
        {
            _dbContext.products.Remove(productEntity);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region 
       public async Task<Product_Brand> AddBrandAsync(Product_Brand product_Brand)
        {
            var result = await _dbContext.AddAsync(product_Brand);
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
