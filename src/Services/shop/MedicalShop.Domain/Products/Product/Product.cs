using MedicalShop.Domain.Base;
using MedicalShop.Domain.Products.Brand;
using MedicalShop.Domain.Products.Category;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MedicalShop.Domain.Products.Product
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public int BrandID { get; set; }
        public string StockQuantity { get; set; }//تعداد موجودی محصول
        public string SKU { get; set; }//شماره محصول برای مدیریت موجودی.
        public string ImageURL { get; set; }//لینک به تصویر محصول
        public string Warranty { get; set; }//مدت زمان گارانتی و شرایط آن
        public int Rating { get; set; }//میانگین امتیاز محصول از طرف کاربران.
        public int CategoryID { get; set; }
        public Product_Category Category { get; set; } // Fixed class name
        public Product_Brand Brand { get; set; } // Renamed for clarity


        public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
                builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
                builder.Property(p => p.StockQuantity).IsRequired();
                builder.Property(p => p.SKU).IsRequired().HasMaxLength(100);
                builder.Property(p => p.ImageURL).IsRequired().HasMaxLength(300);
                builder.Property(p => p.Warranty).HasMaxLength(200);
                builder.Property(p => p.Rating).HasDefaultValue(0);

                // Relationships
                builder.HasOne(p => p.Category)
                       .WithMany(c => c.Products)
                       .HasForeignKey(p => p.CategoryID);

                builder.HasOne(p => p.Brand)
                       .WithMany(b => b.Products)
                       .HasForeignKey(p => p.BrandID);
            }
        }
    }
}
