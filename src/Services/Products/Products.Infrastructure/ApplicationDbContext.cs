using Microsoft.EntityFrameworkCore;
using Products.Domain.Products.Models;


namespace Products.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<ProductCategory> Categories { get; set; }
    public DbSet<ProductBrand> Brands { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntity.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategory.ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductBrand.ProductBrandConfiguration());
    }
}
