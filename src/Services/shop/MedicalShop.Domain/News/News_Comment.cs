using MedicalShop.Domain.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News
{
    public class News_Comment : BaseEntity
    {
        public string NewsArticleID { get; set; }

        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public News_Article Article { get; set; } // Navigation property

        public class CommentNewsConfiguration : IEntityTypeConfiguration<News_Comment>
        {
            public void Configure(EntityTypeBuilder<News_Comment> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.NewsArticleID).IsRequired();
                builder.Property(p => p.UserID).IsRequired();
                builder.Property(p => p.Content).IsRequired().HasMaxLength(1000);
                builder.Property(p => p.PostedDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            }
        }
    }
}
