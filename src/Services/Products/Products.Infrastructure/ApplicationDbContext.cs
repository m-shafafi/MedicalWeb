using Products.Domain.Menu;
using Products.Domain.Menu.Models;
using Products.Domain.News.Models;
using Products.Domain.Products.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Products.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<ProductEntity> products { get; set; }
    public DbSet<ProductCategory> category { get; set; }
    public DbSet<ProductBrand> brands { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntity.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategory.ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductBrand.ProductBrandConfiguration());
    }
}
