using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products.Brand
{
    public interface  IProduct_BrandReadRepository
    {
        Task<List<Product_Brand>> GetAllAsync();
        Task<Product_Brand> GetAsync();
    }
}
