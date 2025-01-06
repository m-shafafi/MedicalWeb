using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products
{
    public interface IProductWriteRepository
    {
        #region 
        Task<ProductEntity> AddProductCategoriesAsync(ProductEntity Product_Category);
        Task<ProductEntity> UpdateProductCategoriesAsync(ProductEntity Product_Category);
        Task DeleteProductCategoriesAsync(ProductEntity Product_Category);
        #endregion
        #region 
        Task<ProductEntity> AddProductAsync(ProductEntity Product_Category);
        Task<ProductEntity> UpdateProductAsync(ProductEntity Product_Category);
        Task DeleteProductAsync(ProductEntity Product_Category);
        #endregion
        #region 
        Task<Product_Brand> AddBrandAsync(Product_Brand Product_Category);
        Task<Product_Brand> UpdateBrandAsync(Product_Brand Product_Category);
        Task DeleteBrandAsync(Product_Brand Product_Category);
        #endregion
    }
}
