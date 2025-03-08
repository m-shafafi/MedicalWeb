using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.News.Models;
using MedicalShop.Domain.Products.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace MedicalShop.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<ProductEntity> products { get; set; }
    public DbSet<ProductCategory> category { get; set; }
    public DbSet<ProductBrand> brands { get; set; }
    public DbSet<News_Article> newsArticles { get; set; }
    public DbSet<News_Category> newsCategories { get; set; }
    public DbSet<News_Comment> comments { get; set; }
    public DbSet<News_Author> authors { get; set; }
    public DbSet<Menu_MainMenu> mainMenus { get; set; }
    public DbSet<Menu_Category> categoryMenus { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntity.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategory.ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductBrand.ProductBrandConfiguration());
        modelBuilder.ApplyConfiguration(new News_Author.AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new News_Category.CategoryNewsConfiguration());
        modelBuilder.ApplyConfiguration(new News_Comment.CommentNewsConfiguration());
        modelBuilder.ApplyConfiguration(new News_Article.NewsArticleNewsConfiguration());
        modelBuilder.ApplyConfiguration(new Menu_MainMenu.MainMenuConfiguration());
        modelBuilder.ApplyConfiguration(new Menu_Category.CategoryMenuConfiguration());
    }
}
