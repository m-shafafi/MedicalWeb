using MedicalShop.Domain.Menu;
using MedicalShop.Domain.News.Article;
using MedicalShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain
{
    public interface IWriteUnitOfWork
    {
        IProductWriteRepository ProductWriteRepository { get; }
        INewsWriteRepository NewsWriteRepository { get; }
        IMenuWriteRepository MenuWriteRepository { get; }
    }
}
