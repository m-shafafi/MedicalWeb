using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.News.Models;

namespace MedicalShop.Domain.News.Article
{
    public interface INews_Author_CategoryReadRepository
    {
        Task<List<News_Article>> GetAllAsync();
        Task<News_Article> GetAsync();
    }
}
