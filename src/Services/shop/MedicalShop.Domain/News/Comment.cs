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
    public class Comment:BaseEntity
    {
        public string NewsArticleID { get; set; }

        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public class CommentNewsConfiguration : IEntityTypeConfiguration<Comment>
        {
            public void Configure(EntityTypeBuilder<Comment> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.NewsArticleID).IsRequired();
                builder.Property(p => p.UserID).IsRequired();
                builder.Property(p => p.Content).IsRequired();
                builder.Property(p => p.PostedDate).IsRequired();
            }
        }
    }
}
