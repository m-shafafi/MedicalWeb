using Products.Domain.Products.Repositories;
using Products.Domain.UnitOfWork.Product;
using Products.Infrastructure.Products;

namespace Products.Infrastructure;

public class WriteUnitOfWork : IWriteUnitOfWork
{
    private IProductWriteRepository _ProductWriteRepository;
    private readonly ApplicationDbContext _context;
    public WriteUnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }
    public IProductWriteRepository ProductWriteRepository
    {
        get
        {
            return _ProductWriteRepository ??= new ProductWriteRepository(_context);
        }
    }
}
