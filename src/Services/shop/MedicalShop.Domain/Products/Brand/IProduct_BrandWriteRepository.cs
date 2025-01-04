using MedicalShop.Domain.Products.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products.Brand
{
    public interface IProduct_BrandWriteRepository
    {
        Task<Product_Brand> AddAsync(Product_Brand Product_Category);
        Task<Product_Brand> UpdateAsync(Product_Brand Product_Category);
        Task DeleteAsync(Product_Brand Product_Category);
    }
}
