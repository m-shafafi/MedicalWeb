using Products.Domain.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Menu
{
    public class Menu_Category : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public class CategoryMenuConfiguration : IEntityTypeConfiguration<Menu_Category>
        {
            public void Configure(EntityTypeBuilder<Menu_Category> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.CreatedDate).IsRequired();
                builder.Property(p => p.UpdatedDate).IsRequired();
            }
        }
    }
}
