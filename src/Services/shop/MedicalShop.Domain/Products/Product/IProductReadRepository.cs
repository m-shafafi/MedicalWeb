﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products.Product
{
    public interface IProductReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetAsync();
    }
}