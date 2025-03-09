using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalShop.Domain.Base;

namespace MedicalShop.Domain.Products.Models
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        //در صورتی که دسته‌بندی به عنوان زیرمجموعه‌ی دسته دیگری باشد، این فیلد مشخص می‌کند که والد آن چیست.
        public int? ParentCategoryID { get; set; } // دسته‌بندی والد
        public ProductCategory ParentCategory { get; set; } // ناوبری به والد
        public ICollection<ProductCategory> SubCategories { get; set; } = new List<ProductCategory>(); // ناوبری به زیردسته‌ها

        public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>(); // لیست محصولات در این دسته‌بندی



        public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
        {
            public void Configure(EntityTypeBuilder<ProductCategory> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
                builder.Property(p => p.ParentCategoryID).IsRequired(false);
                builder.HasOne(c => c.ParentCategory) // تعریف ارتباط با دسته‌بندی والد
                       .WithMany(c => c.SubCategories) // هر دسته می‌تواند زیردسته‌هایی داشته باشد
                       .HasForeignKey(c => c.ParentCategoryID) // کلید خارجی برای والد
                       .OnDelete(DeleteBehavior.Restrict); // جلوگیری از حذف والد به صورت خودکار


            }
        }
    }
}
