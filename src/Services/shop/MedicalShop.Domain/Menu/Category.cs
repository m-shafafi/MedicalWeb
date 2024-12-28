using MedicalShop.Domain.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Menu
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public class ProductConfiguration : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.CreatedDate).IsRequired();
                builder.Property(p => p.UpdatedDate).IsRequired();
            }
        }
    }
}
