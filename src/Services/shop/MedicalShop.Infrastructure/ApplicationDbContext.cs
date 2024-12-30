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
        public DbSet<Product> Products { get; set; }
        public DbSet<Domain.Products.Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Domain.News.NewsArticle> NewsArticles { get; set; }
        public DbSet<Domain.News.Category> NewsCategories { get; set; }
        public DbSet<Domain.News.Comment> Comments { get; set; }
        public DbSet<Domain.News.Author> Authors { get; set; }
        public DbSet<Domain.Menu.MainMenu> MainMenus { get; set; }
        public DbSet<Domain.Menu.MainMenu> CategoryMenus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Product.ProductConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.Products.Category.ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.Products.Brand.ProductBrandConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.News.Author.AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.News.Category.CategoryNewsConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.News.Comment.CommentNewsConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.News.NewsArticle.NewsArticleNewsConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.Menu.MainMenu.MainMenuConfiguration());
            modelBuilder.ApplyConfiguration(new Domain.Menu.Category.CategoryMenuConfiguration());
        }
    }
}
