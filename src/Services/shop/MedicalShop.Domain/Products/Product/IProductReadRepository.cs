using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.Products.Models;

namespace MedicalShop.Domain.Products.Product
{
    public interface IProductReadRepository
    {
        Task<List<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetAsync();
    }
}
