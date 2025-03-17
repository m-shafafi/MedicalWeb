using Products.Domain.Menu;
using Products.Domain.Products.Repositories;
using Products.Domain.UnitOfWork.Product;

namespace Products.Infrastructure;

public class ReadUnitOfWork : IReadUnitOfWork
{

    private readonly ApplicationDbContext _context;
    public ReadUnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }
    private ProductReadRepository _productReadRepository;
    public IProductReadRepository ProductReadRepository
    {
        get
        {
            return _productReadRepository ??= new ProductReadRepository(_context);
        }
    }

}
