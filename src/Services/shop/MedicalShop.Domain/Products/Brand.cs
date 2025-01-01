using MedicalShop.Domain.Base;
using MedicalShop.Domain.News;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products
{
    public class Product_Brand : BaseEntity
    {
        public string Name { get; set; }
        public string LogoURL { get; set; }
        public string Description { get; set; }

        public class ProductBrandConfiguration : IEntityTypeConfiguration<Product_Brand>
        {
            public void Configure(EntityTypeBuilder<Product_Brand> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.LogoURL).IsRequired();
                builder.Property(p => p.Description).IsRequired();
            }
        }
    }
}
