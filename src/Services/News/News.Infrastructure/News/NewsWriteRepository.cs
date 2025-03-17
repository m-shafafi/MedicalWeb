using Products.Domain.Menu;
using Products.Domain.Menu.Models;
using Products.Domain.News.Article;
using Products.Domain.News.Models;
using Products.Domain.Products;
using Products.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.News
{
    public class NewsWriteRepository : INewsWriteRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public NewsWriteRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region
        public async Task<News_Article> AddNews_ArticleAsync(News_Article news_Article)
        {
            var result = await _dbContext.AddAsync(news_Article);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<News_Article> UpdateNews_ArticleAsync(News_Article news_Article)
        {
            var result = _dbContext.Update(news_Article);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteNews_ArticleAsync(News_Article news_Article)
        {
            _dbContext.newsArticles.Remove(news_Article);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region
        public async Task<News_Author> AddNews_AuthorAsync(News_Author news_Author)
        {
            var result = await _dbContext.AddAsync(news_Author);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<News_Author> UpdateNews_ArticleAsync(News_Author news_Author)
        {
            var result = _dbContext.Update(news_Author);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteNews_AuthorAsync(News_Author news_Author)
        {
            _dbContext.authors.Remove(news_Author);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region
        public async Task<News_Category> AddNews_CategoryAsync(News_Category news_Category)
        {
            var result = await _dbContext.AddAsync(news_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<News_Category> UpdateNews_CategoryAsync(News_Category news_Category)
        {
            var result = _dbContext.Update(news_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteNews_CategoryAsync(News_Category news_Category)
        {
            _dbContext.newsCategories.Remove(news_Category);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region
        public async Task<News_Comment> AddNews_CommentAsync(News_Comment news_Comment)
        {
            var result = await _dbContext.AddAsync(news_Comment);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<News_Comment> UpdateNews_CommentAsync(News_Comment news_Comment)
        {
            var result = _dbContext.Update(news_Comment);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteNews_CommentAsync(News_Comment news_Comment)
        {
            _dbContext.comments.Remove(news_Comment);
            await _dbContext.SaveChangesAsync();
        }
        #endregion

    }
    }
