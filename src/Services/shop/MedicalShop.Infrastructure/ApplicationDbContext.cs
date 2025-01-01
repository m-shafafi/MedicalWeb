using MedicalShop.Domain.News;
using MedicalShop.Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace MedicalShop.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
       // public DbSet<Prpduct_Category> category { get; set; }
        //public DbSet<Product_Brand> brands { get; set; }
       // public DbSet<NewsArticle> newsArticles { get; set; }
        //public DbSet<Domain.News.Category> newsCategories { get; set; }
        //public DbSet<Domain.News.Comment> comments { get; set; }
        //public DbSet<Domain.News.Author> authors { get; set; }
        //public DbSet<Domain.Menu.MainMenu> mainMenus { get; set; }
        //public DbSet<Domain.Menu.MainMenu> categoryMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Product.ProductConfiguration());
          //  modelBuilder.ApplyConfiguration(new Prpduct_Category.ProductCategoryConfiguration());
           // modelBuilder.ApplyConfiguration(new Product_Brand.ProductBrandConfiguration());
           // modelBuilder.ApplyConfiguration(new Author.AuthorConfiguration());
            //modelBuilder.ApplyConfiguration(new Domain.News.Category.CategoryNewsConfiguration());
            //modelBuilder.ApplyConfiguration(new Domain.News.Comment.CommentNewsConfiguration());
            //modelBuilder.ApplyConfiguration(new Domain.News.NewsArticle.NewsArticleNewsConfiguration());
            //modelBuilder.ApplyConfiguration(new Domain.Menu.MainMenu.MainMenuConfiguration());
            //modelBuilder.ApplyConfiguration(new Domain.Menu.Category.CategoryMenuConfiguration());
        }
    }
}
