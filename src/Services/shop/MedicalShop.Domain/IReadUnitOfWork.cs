using MedicalShop.Domain.Menu;
using MedicalShop.Domain.News.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain
{
    public interface IReadUnitOfWork
    {
        IProductReadRepository ProductReadRepository { get; }
        INewsReadRepository NewsReadRepository { get; }
        IMenuReadRepository MenuReadRepository { get; }
    }
}
