﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.Base;

namespace MedicalShop.Domain.Products
{
    public class Prpduct_Category:BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public int ParentCategoryID { get; set; }//در صورتی که دسته‌بندی به عنوان زیرمجموعه‌ی دسته دیگری باشد، این فیلد مشخص می‌کند که والد آن چیست.
        public class ProductCategoryConfiguration : IEntityTypeConfiguration<Prpduct_Category>
        {
            public void Configure(EntityTypeBuilder<Prpduct_Category> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.Description).IsRequired();
                builder.Property(p => p.ParentCategoryID).IsRequired();
            }
        }
    }
}
