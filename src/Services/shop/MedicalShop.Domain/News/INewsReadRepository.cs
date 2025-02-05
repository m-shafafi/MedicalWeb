using MedicalShop.Domain.News.Models;

namespace MedicalShop.Domain.News.Article
{
    public interface INewsReadRepository
    {
        #region
        Task<List<News_Article>> GetNewsArticleAllAsync();
        Task<News_Article> GetNewsArticleAsync();
        #endregion
        #region
        Task<List<News_Author>> GetNewsAuthorAllAsync();
        Task<News_Author> GetNewsAuthorAsync();
        #endregion
        #region
        Task<List<News_Category>> GetNewsCategoryAllAsync();
        Task<News_Category> GetNewsCategoryAsync();
        #endregion
        #region
        Task<List<News_Comment>> GetNewsCommentAllAsync();
        Task<News_Comment> GetNewsCommentAsync();
        #endregion
    }
}
