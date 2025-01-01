using MedicalShop.Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MedicalShop.Domain.Products
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string Price { get; set; }
        public int BrandID { get; set; }
        public string StockQuantity { get; set; }//تعداد موجودی محصول
        public string SKU { get; set; }//شماره محصول برای مدیریت موجودی.
        public string ImageURL { get; set; }//لینک به تصویر محصول
        public string Warranty { get; set; }//مدت زمان گارانتی و شرایط آن
        public int Rating { get; set; }//میانگین امتیاز محصول از طرف کاربران.
        public int CategoryID { get; set; }
        public Prpduct_Category Category { get; set; }


        public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Price).IsRequired().HasMaxLength(200);
                builder.Property(p => p.StockQuantity).IsRequired().HasMaxLength(200);
                builder.Property(p => p.SKU).IsRequired().HasMaxLength(200);
                builder.Property(p => p.ImageURL).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Warranty).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Rating).IsRequired();
            }
        }
    }
}
