using MedicalShop.Domain.Base;
using MedicalShop.Domain.Menu;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }

        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        public class ProductConfiguration : IEntityTypeConfiguration<Author>
        {
            public void Configure(EntityTypeBuilder<Author> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.Bio).IsRequired();
                builder.Property(p => p.ProfilePictureURL).IsRequired();
            }
        }
    }
}
