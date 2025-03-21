﻿using Products.Domain.Base;
using Products.Domain.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.News.Models
{
    public class News_Article : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Tags { get; set; }
        public string ImageURL { get; set; }
        public long ViewsCount { get; set; }
        public News_Author news_Author { get; set; } // Navigation property
        public News_Category news_Category { get; set; } // Navigation property
        public ICollection<News_Comment> news_Comments  { get; set; } // Navigation property

        public class NewsArticleNewsConfiguration : IEntityTypeConfiguration<News_Article>
        {
            public void Configure(EntityTypeBuilder<News_Article> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Summary).HasMaxLength(500);
                builder.Property(p => p.Content).IsRequired();
                builder.Property(p => p.PublishedDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
                builder.Property(p => p.Tags).HasMaxLength(200);
                builder.Property(p => p.ImageURL).HasMaxLength(300);
                builder.Property(p => p.ViewsCount).HasDefaultValue(0);

                // Relationships
                builder.HasOne(p => p.news_Author)
                       .WithMany(a => a.news_Articles)
                       .HasForeignKey(p => p.AuthorID);

                builder.HasOne(p => p.news_Category)
                       .WithMany(c => c.news_Articles)
                       .HasForeignKey(p => p.CategoryID);
            }
        }
    }
}
