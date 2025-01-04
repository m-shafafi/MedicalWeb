using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products.Category
{
    public interface IProduct_CategoryWriteRepository
    {
        Task<Product_Category> AddAsync(Product_Category Product_Category);
        Task<Product_Category> UpdateAsync(Product_Category Product_Category);
        Task DeleteAsync(Product_Category Product_Category);
    }
}
