using Microsoft.EntityFrameworkCore;
using Products.Domain.Products.Models;


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
