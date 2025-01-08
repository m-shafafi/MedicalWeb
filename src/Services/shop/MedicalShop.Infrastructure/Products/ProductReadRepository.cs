using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Menu
{
    public interface IProductReadRepository
    {
        Task<List<Product_Category>> FetchAllProduct_CategoryAsync();
        Task<Product_Category> FetchProduct_CategoryAsync();
        Task<List<ProductEntity>> FetchAllProductAsync();
        Task<ProductEntity> FetchProducAsync();
        Task<List<Product_Brand>> FetchAllProduct_BrandAsync();
        Task<Product_Brand> FetchProduct_BrandAsync();

    }
}
