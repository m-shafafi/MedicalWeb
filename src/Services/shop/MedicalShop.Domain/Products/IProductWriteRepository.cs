using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.Products.Models;
using Microsoft.EntityFrameworkCore;
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
        Task<Product_Category> AddProductCategoriesAsync(Product_Category product_Category);
        Task<Product_Category> UpdateProductCategoriesAsync(Product_Category product_Category);
        Task DeleteProductCategoriesAsync(Product_Category product_Category);
        #endregion
        #region 
        Task<ProductEntity> AddProductAsync(ProductEntity productEntity);
        Task<ProductEntity> UpdateProductAsync(ProductEntity productEntity);
        Task DeleteProductAsync(ProductEntity productEntity);

        #endregion
        #region 
        Task<Product_Brand> AddBrandAsync(Product_Brand product_Brand);
        Task<Product_Brand> UpdateBrandAsync(Product_Brand product_Brand);
        Task DeleteBrandAsync(Product_Brand product_Brand);
        #endregion

    }
}
