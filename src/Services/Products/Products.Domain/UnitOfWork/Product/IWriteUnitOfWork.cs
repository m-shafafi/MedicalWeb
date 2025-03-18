using Products.Domain.Products.Repositories;

namespace Products.Domain.UnitOfWork.Product
{
    public interface IWriteUnitOfWork
    {
        IProductWriteRepository ProductWriteRepository { get; }
    }
}
