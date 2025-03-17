using Products.Domain.Base;
using Products.Domain.Products.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace Products.Domain.Products.Models;
public class ProductEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int? BrandId { get; set; }
    public int? CategoryId { get; set; }
    public string StockQuantity { get; set; }
    public string SKU { get; set; }
    public string ImageURL { get; set; }
    public string Warranty { get; set; }
    public int Rating { get; set; }

    // روابط
    public ProductBrand ProductBrand { get; set; } // رابطه با برند
    public ProductCategory Category { get; set; } // رابطه با دسته‌بندی

    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.StockQuantity).IsRequired();
            builder.Property(p => p.SKU).IsRequired().HasMaxLength(100);
            builder.Property(p => p.ImageURL).IsRequired().HasMaxLength(300);
            builder.Property(p => p.Warranty).HasMaxLength(200);
            builder.Property(p => p.Rating).HasDefaultValue(0);

            // تنظیم رابطه با دسته‌بندی
            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .IsRequired(false);

            // تنظیم رابطه با برند
            builder.HasOne(p => p.ProductBrand)
                   .WithMany(b => b.Products)
                   .HasForeignKey(p => p.BrandId)
                   .IsRequired(false);
        }
        private List<ProductEntity> SeedProducts()
        {
            var products = new List<ProductEntity>();
            string directoryPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            string productSeedPath = Path.Combine(directoryPath, @"SeedData/ProductSeed.json");
            using (StreamReader r = new StreamReader(productSeedPath))
            {
                string json = r.ReadToEnd();
                products = JsonSerializer.Deserialize<List<ProductEntity>>(json);
            }

            return products ?? new();
        }
    }
}
