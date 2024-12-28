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
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Domain.Products.Category> category { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<Domain.News.NewsArticle> newsArticle { get; set; }
        public DbSet<Domain.News.Category> categoryNews { get; set; }
        public DbSet<Domain.News.Comment> comment { get; set; }
        public DbSet<Domain.News.Author> author { get; set; }
        public DbSet<Domain.Menu.MainMenu> mainMenu { get; set; }
        public DbSet<Domain.Menu.MainMenu> categoryMenu { get; set; }
    }
}
