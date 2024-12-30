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
    public class Category:BaseEntity
    {
        public string Name { get; set; }//نام دسته‌بندی (مثلاً "اخبار صنعت پزشکی" یا "معرفی محصولات جدید").
        public string Description { get; set; }

        public int ParentCategoryID { get; set; }//شناسه دسته‌بندی والد (در صورت وجود). این فیلد برای ایجاد زیرمجموعه‌ها (Subcategories) استفاده می‌شود.
        public string Slug { get; set; }   //آدرس یکتا برای دسته‌بندی که در URL استفاده می‌شود (مثلاً "medical-news" برای دسته‌بندی اخبار پزشکی).
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public class CategoryNewsConfiguration : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.Description).IsRequired();
                builder.Property(p => p.ParentCategoryID).IsRequired();
                builder.Property(p => p.Slug).IsRequired();
                builder.Property(p => p.CreatedDate).IsRequired();
                builder.Property(p => p.UpdatedDate).IsRequired();
            }
        }
    }
}
