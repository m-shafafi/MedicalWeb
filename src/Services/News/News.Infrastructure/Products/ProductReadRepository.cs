using Products.Domain.Products.Models;
using Products.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Products.Domain.Products.Repositories;

namespace Products.Domain.Menu
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductReadRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ProductCategory>> FetchAllProductCategoryAsync()
        {
            return await _dbContext.category.Include(p => p.Products).ToListAsync();
        }
        public async Task<ProductCategory> FetchProductCategoryAsync(int id)
        {
            return await _dbContext.category.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<List<ProductBrand>> FetchAllProductBrandAsync()
        {
            return await _dbContext.brands.Include(p => p.Name).ToListAsync();
        }
        public async Task<ProductBrand> FetchProductBrandAsync(int id)
        {
            return await _dbContext.brands.FirstOrDefaultAsync(p => p.Id == id);

        }
        public async Task<List<ProductEntity>> FetchAllProductEntityAsync()
        {
            return await _dbContext.products.Include(p => p.ProductBrand).ToListAsync();
        }
        public async Task<ProductEntity> FetchProductEntityAsync(int id)
        {
            return await _dbContext.products.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Tuple<List<ProductEntity>, int>> GetByFilterPagedAsync(ProductFilterPage request)
        {
            var filteredProducts = _dbContext.products.AsQueryable();
            if (request.Id != 0)
            {
                filteredProducts = filteredProducts.Where(p => p.Id == request.Id);
            }

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                request.SearchTerm = request.SearchTerm.Trim().ToLower();
                filteredProducts = filteredProducts.Where(p => p.Name.ToLower().Contains(request.SearchTerm)
                                                               || p.Description.ToLower().Contains(request.SearchTerm));

            }

            if (request.MinPrice != null)
            {
                filteredProducts = filteredProducts.Where(p => p.Price >= request.MinPrice);
            }

            if (request.MaxPrice != null)
            {
                filteredProducts = filteredProducts.Where(p => p.Price <= request.MaxPrice);
            }


            if (request.CategoryId != 0)
            {
                filteredProducts = filteredProducts.Where(p => p.CategoryID == request.CategoryId);
            }

            int countOfFilteredProducts = filteredProducts.Count();
            filteredProducts = filteredProducts.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);

            return
                Tuple.Create(await filteredProducts.ToListAsync(), countOfFilteredProducts);



        }

        public async Task<ProductEntity> GetAsyncNoTracking(int id)
        {
            return await _dbContext.products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
