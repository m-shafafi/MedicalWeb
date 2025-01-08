using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.News.Models;

namespace MedicalShop.Domain.News.Article
{
    public interface INewsWriteRepository
    {
        #region
        Task<News_Article> AddNews_ArticleAsync(News_Article news_Article);
        Task<News_Article> UpdateNews_ArticleAsync(News_Article news_Article);
        Task DeleteNews_ArticleAsync(News_Article news_Article);
        #endregion
        #region
        Task<News_Author> AddNews_AuthorAsync(News_Author news_Author);
        Task<News_Author> UpdateNews_ArticleAsync(News_Author news_Author);
        Task DeleteNews_AuthorAsync(News_Author news_Author);
        #endregion
           #region
        Task<News_Category> AddNews_CategoryAsync(News_Category news_Category);
        Task<News_Category> UpdateNews_CategoryAsync(News_Category news_Category);
        Task DeleteNews_CategoryAsync(News_Category news_Category);
        #endregion
           #region
        Task<News_Comment> AddNews_CommentAsync(News_Comment news_Comment);
        Task<News_Comment> UpdateNews_CommentAsync(News_Comment news_Comment);
        Task DeleteNews_CommentAsync(News_Comment news_Comment);
        #endregion
    }
}
