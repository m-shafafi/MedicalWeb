using MedicalShop.Domain.Base;
using MedicalShop.Domain.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News
{
    public class NewsArticle : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }//خلاصه‌ای از محتوای خبر
        public string Content { get; set; }   //محتوای کامل خبر
        public int AuthorID { get; set; }  //نویسنده خبر 
        public int CategoryID { get; set; }   //دسته‌بندی خبر (اخبار، معرفی محصول، تخفیف‌ها و غیره)
        public DateTime PublishedDate { get; set; }   //تاریخ انتشار خبر
        public string Tags { get; set; }   //برچسب‌های مرتبط با خبر (آرایه‌ای از کلمات کلیدی)
        public string ImageURL { get; set; }   // لینک به تصویر یا تصاویر مرتبط با خبر.
        public long ViewsCount { get; set; }
        public string Comments { get; set; }   //لیستی از نظرات کاربران
        public string ShareableLink { get; set; }  //لینک اختصاصی برای اشتراک‌گذاری خبر

        public class NewsArticleNewsConfiguration : IEntityTypeConfiguration<NewsArticle>
        {
            public void Configure(EntityTypeBuilder<NewsArticle> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Summary).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Content).IsRequired().HasMaxLength(200);
                builder.Property(p => p.AuthorID).IsRequired().HasMaxLength(200);
                builder.Property(p => p.CategoryID).IsRequired().HasMaxLength(200);
                builder.Property(p => p.PublishedDate).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.Tags).IsRequired().HasMaxLength(200);
                builder.Property(p => p.ImageURL).IsRequired().HasDefaultValue(DateTime.UtcNow);
            }
        }
    }
}
