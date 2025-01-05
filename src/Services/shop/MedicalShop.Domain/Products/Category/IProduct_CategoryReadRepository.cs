using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.Products.Models;

namespace MedicalShop.Domain.Products.Category
{
    public interface  IProduct_BrandReadRepository
    {
        Task<List<Product_Category>> GetAllAsync();
        Task<Product_Category> GetAsync();
    }
}
