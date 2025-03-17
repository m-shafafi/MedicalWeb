using Products.Domain.Menu;
using Products.Domain.News.Article;
using Products.Domain.Products.Repositories;
using Products.Domain.UnitOfWork.Product;
using Products.Infrastructure.Menu;
using Products.Infrastructure.News;

namespace Products.Infrastructure;

public class ReadUnitOfWork : IReadUnitOfWork
{

    private readonly ApplicationDbContext _context;
    public ReadUnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }
    private ProductReadRepository _productReadRepository;
    private MenuReadRepository _menuReadRepository;
    private NewsReadRepository _newsReadRepository;
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
    public IMenuReadRepository MenuReadRepository
    {
        get
        {
            return _menuReadRepository ??= new MenuReadRepository(_context);
        }
    }
}
