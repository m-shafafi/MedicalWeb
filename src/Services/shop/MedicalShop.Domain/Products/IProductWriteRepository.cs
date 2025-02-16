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
        Task<ProductCategory> AddProductCategoriesAsync(ProductCategory ProductCategory);
        Task<ProductCategory> UpdateProductCategoriesAsync(ProductCategory ProductCategory);
        Task DeleteProductCategoriesAsync(ProductCategory ProductCategory);
        #endregion
        #region 
        Task<ProductEntity> AddProductAsync(ProductEntity productEntity);
        Task<ProductEntity> UpdateProductAsync(ProductEntity productEntity);
        Task DeleteProductAsync(ProductEntity productEntity);

        #endregion
        #region 
        Task<ProductBrand> AddBrandAsync(ProductBrand ProductBrand);
        Task<ProductBrand> UpdateBrandAsync(ProductBrand ProductBrand);
        Task DeleteBrandAsync(ProductBrand ProductBrand);
        #endregion

    }
}
