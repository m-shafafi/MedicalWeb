using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.News.Models;
using MedicalShop.Domain.Products.Models;
using MedicalShop.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Menu
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductReadRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product_Category>> FetchAllProductCategoryAsync()
        {
            return await _dbContext.category.Include(p => p.Products).ToListAsync();
        }
        public async Task<Product_Category> FetchProductCategoryAsync(int id)
        {
            return await _dbContext.category.FirstOrDefaultAsync(p => p.ID == id);
        }
        public async Task<List<Product_Brand>> FetchAllProductBrandAsync()
        {
            return await _dbContext.brands.Include(p => p.Name).ToListAsync();
        }
        public async Task<Product_Brand> FetchProductBrandAsync(int id)
        {
            return await _dbContext.brands.FirstOrDefaultAsync(p => p.ID == id);

        }
        public async Task<List<ProductEntity>> FetchAllProductEntityAsync()
        {
            return await _dbContext.products.Include(p => p.Category).ToListAsync();
        }
        public async Task<ProductEntity> FetchProductEntityAsync(int id)
        {
            return await _dbContext.products.FirstOrDefaultAsync(p => p.ID == id);
        }
       

    }
}
