using Products.Domain.Menu;
using Products.Domain.News.Article;
using Products.Domain.Products.Repositories;

namespace Products.Domain.UnitOfWork.Product
{
    public interface IReadUnitOfWork
    {
        IProductReadRepository ProductReadRepository { get; }
        INewsReadRepository NewsReadRepository { get; }
        IMenuReadRepository MenuReadRepository { get; }
    }
}
