using Products.Domain.Products.Repositories;

namespace Products.Domain.UnitOfWork.Product
{
    public interface IReadUnitOfWork
    {
        IProductReadRepository ProductReadRepository { get; }
    }
}
