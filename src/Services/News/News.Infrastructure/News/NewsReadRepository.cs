using Products.Domain.Menu;
using Products.Domain.Menu.Models;
using Products.Domain.News.Article;
using Products.Domain.News.Models;
using Products.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.News
{
    public class NewsReadRepository:INewsReadRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public NewsReadRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region
        public async Task<List<News_Article>> GetNewsArticleAllAsync()
        {
            var news_Article=new List<News_Article>();
            return news_Article.ToList();


        }
        public async Task<News_Article> GetNewsArticleAsync() {
            var news_Article =new News_Article();
            return news_Article;
        }
        #endregion
        #region
        public async Task<List<News_Author>> GetNewsAuthorAllAsync() {
            var news_Author = new List<News_Author>();
            return news_Author.ToList();
        }
        public async Task<News_Author> GetNewsAuthorAsync(){
            var news_Author = new News_Author();
            return news_Author;
        }
        #endregion
        #region
        public async Task<List<News_Category>> GetNewsCategoryAllAsync() {
            var news_Category = new List<News_Category>();
            return news_Category.ToList();
        }
        public async Task<News_Category> GetNewsCategoryAsync() {
            var news_Category = new News_Category();
            return news_Category;
        }
        #endregion
        #region
        public async Task<List<News_Comment>> GetNewsCommentAllAsync() {
            var news_Comments = new List<News_Comment>();
            return news_Comments.ToList();
        }
        public async Task<News_Comment> GetNewsCommentAsync() {
            var news_Comment = new News_Comment();
            return news_Comment;
        }
        #endregion
    }
}
