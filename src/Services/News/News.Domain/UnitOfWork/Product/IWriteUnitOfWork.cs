using Products.Domain.Menu;
using Products.Domain.News.Article;
using Products.Domain.Products.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.UnitOfWork.Product
{
    public interface IWriteUnitOfWork
    {
        IProductWriteRepository ProductWriteRepository { get; }
        INewsWriteRepository NewsWriteRepository { get; }
        IMenuWriteRepository MenuWriteRepository { get; }
    }
}
