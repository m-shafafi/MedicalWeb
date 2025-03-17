using Products.Domain.Base;
using Products.Domain.News;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Products.Models
{
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; }
        public string LogoURL { get; set; }
        public string Description { get; set; }
        public ICollection<ProductEntity> Products { get; set; } // Navigation property

        public class ProductBrandConfiguration : IEntityTypeConfiguration<ProductBrand>
        {
            public void Configure(EntityTypeBuilder<ProductBrand> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
                builder.Property(p => p.LogoURL).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            }
        }
    }
}
