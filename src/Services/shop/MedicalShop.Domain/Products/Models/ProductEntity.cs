using MedicalShop.Domain.Base;
using MedicalShop.Domain.Products.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int? BrandID { get; set; }
    public int? CategoryID { get; set; }
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
                   .HasForeignKey(p => p.CategoryID)
                   .IsRequired(false);

            // تنظیم رابطه با برند
            builder.HasOne(p => p.ProductBrand)
                   .WithMany(b => b.Products)
                   .HasForeignKey(p => p.BrandID)
                   .IsRequired(false);
        }
    }
}
