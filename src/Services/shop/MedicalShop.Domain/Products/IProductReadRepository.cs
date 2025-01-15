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
        #region
        Task<List<Product_Category>> FetchAllProductCategoryAsync();
        Task<Product_Category> FetchProductCategoryAsync(int id);
        #endregion
        #region
        Task<List<Product_Brand>> FetchAllProductBrandAsync();
        Task<Product_Brand> FetchProductBrandAsync(int id);
        #endregion
        #region
        Task<List<ProductEntity>> FetchAllProductEntityAsync();
        Task<ProductEntity> FetchProductEntityAsync(int id);
        #endregion
    }
}
