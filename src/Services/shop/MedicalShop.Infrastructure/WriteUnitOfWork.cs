using MedicalShop.Domain;
using MedicalShop.Domain.Menu;
using MedicalShop.Domain.News.Article;
using MedicalShop.Domain.Products;
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
        private readonly ApplicationDbContext _context;
        public WriteUnitOfWork(ApplicationDbContext cpntext)
        {
              _context=cpntext  
        }
        public IProductWriteRepository ProductWriteRepository{
            get
            {
                return _ProductWriteRepository ??=new ProductWriteRepository(_context);
            }
        }

        public INewsWriteRepository NewsWriteRepository => throw new NotImplementedException();

        public IMenuWriteRepository MenuWriteRepository => throw new NotImplementedException();
    }
}
