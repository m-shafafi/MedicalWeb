using MedicalShop.Domain.Base;
using MedicalShop.Domain.Menu;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News.Models
{
    public class News_Author : BaseEntity
    {
        public string Name { get; set; }

        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }
        public ICollection<News_Article> news_Articles { get; set; } // Navigation property

        public class AuthorConfiguration : IEntityTypeConfiguration<News_Author>
        {
            public void Configure(EntityTypeBuilder<News_Author> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Bio).HasMaxLength(500);
                builder.Property(p => p.ProfilePictureURL).HasMaxLength(300);
            }
        }
    }
}
