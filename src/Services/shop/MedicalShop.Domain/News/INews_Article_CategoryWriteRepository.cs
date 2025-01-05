using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.News.Models;

namespace MedicalShop.Domain.News.Article
{
    public interface INews_Article_CategoryWriteRepository
    {
        Task<News_Article> AddAsync(News_Article Product_Category);
        Task<News_Article> UpdateAsync(News_Article Product_Category);
        Task DeleteAsync(News_Article Product_Category);
    }
}
