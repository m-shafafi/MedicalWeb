﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Domain.Base;
using System.Text.Json;

namespace Products.Domain.Products.Models
{
    public class ProductCategory : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Permalink { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
        public string BannerUrl { get; set; }
        public string IconUrl { get; set; }
        public string ThumbnailUrl { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
        public ProductCategory ParentCategory { get; set; }

        public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
        {
            public void Configure(EntityTypeBuilder<ProductCategory> builder)
            {
                builder.HasKey(b => b.Id);
                builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
                builder.Property(p => p.Permalink).IsRequired().HasMaxLength(200);
                builder.Property(p => p.BannerUrl).IsRequired().HasMaxLength(50)
                    .HasDefaultValue("https://via.placeholder.com/500x100.png");
                builder.Property(p => p.IconUrl).IsRequired().HasMaxLength(50)
                    .HasDefaultValue("https://via.placeholder.com/85.png");
                builder.Property(p => p.ThumbnailUrl).IsRequired().HasMaxLength(50).HasDefaultValue("https://via.placeholder.com/150x150.png");
                builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.ModificationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);

                builder.HasData(SeedCategories());
            }

            private List<ProductCategory> SeedCategories()
            {
                var categories = new List<ProductCategory>();
                string directoryPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                string categorySeedPath = Path.Combine(directoryPath, @"SeedData/CategorySeed.json");
                using (StreamReader r = new StreamReader(categorySeedPath))
                {
                    string json = r.ReadToEnd();
                    categories = JsonSerializer.Deserialize<List<ProductCategory>>(json);
                }

                return categories ?? new();
            }
        }
    }
}
