using MedicalShop.Domain.Menu;
using MedicalShop.Domain.News.Article;
using MedicalShop.Domain.Products;
using MedicalShop.Domain.UnitOfWork.Product;
using MedicalShop.Infrastructure.Menu;
using MedicalShop.Infrastructure.News;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Infrastructure
{
    public class ReadUnitOfWork : IReadUnitOfWork
    {
        private IProductReadRepository _productReadRepository;
        private IMenuReadRepository _menuReadRepository;
        private INewsReadRepository _newsReadRepository;
        private readonly ApplicationDbContext _context;
        public ReadUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IProductReadRepository ProductReadRepository
        {
            get
            {
                return _productReadRepository ??= new ProductReadRepository(_context);
            }
        }
        public INewsReadRepository NewsReadRepository
        {
            get
            {
                return _newsReadRepository ??= new NewsReadRepository(_context);
            }
        }
       public IMenuReadRepository MenuReadRepository {
            get {
                return _menuReadRepository ??= new MenuReadRepository(_context);
                    }
        }
    }
}
