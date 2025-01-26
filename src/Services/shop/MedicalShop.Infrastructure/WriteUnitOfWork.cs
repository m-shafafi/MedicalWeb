using MedicalShop.Domain.Menu;
using MedicalShop.Domain.News.Article;
using MedicalShop.Domain.Products;
using MedicalShop.Domain.UnitOfWork.Product;
using MedicalShop.Infrastructure.News;
using MedicalShop.Infrastructure.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Infrastructure
{
    public class WriteUnitOfWork : IWriteUnitOfWork
    {
        private IProductWriteRepository _ProductWriteRepository;
        private IMenuWriteRepository _MenuWriteRepository;
        private INewsWriteRepository _NewsWriteRepository;
        private readonly ApplicationDbContext _context;
        public WriteUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IProductWriteRepository ProductWriteRepository{
            get
            {
                return _ProductWriteRepository ??=new ProductWriteRepository(_context);
            }
        }

        public INewsWriteRepository NewsWriteRepository
        {
            get
            {
                return _NewsWriteRepository ??= new NewsWriteRepository(_context);
            }
        }

        public IMenuWriteRepository MenuWriteRepository
        {
            get
            {

                return _MenuWriteRepository ??= new MenuWriteRepository(_context);
            }
        }
    }
}
