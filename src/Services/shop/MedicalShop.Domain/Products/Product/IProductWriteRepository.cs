using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.Products.Models;

namespace MedicalShop.Domain.Products.Product
{
    public interface IProductWriteRepository
    {
        Task<ProductEntity> AddAsync(ProductEntity product);
        Task<ProductEntity> UpdateAsync(ProductEntity product);
        Task DeleteAsync(ProductEntity product);
    }
}
