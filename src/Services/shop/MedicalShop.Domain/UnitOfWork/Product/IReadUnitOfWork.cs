using MedicalShop.Contracts.Repositories;
using MedicalShop.Domain.Menu;
using MedicalShop.Domain.News.Article;

namespace MedicalShop.Domain.UnitOfWork.Product
{
    public interface IReadUnitOfWork
    {
        IProductReadRepository ProductReadRepository { get; }
        INewsReadRepository NewsReadRepository { get; }
        IMenuReadRepository MenuReadRepository { get; }
    }
}
