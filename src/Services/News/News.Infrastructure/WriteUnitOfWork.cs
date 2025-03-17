using Products.Domain.Menu;
using Products.Domain.News.Article;
using Products.Domain.Products.Repositories;
using Products.Domain.UnitOfWork.Product;
using Products.Infrastructure.News;
using Products.Infrastructure.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure;

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
