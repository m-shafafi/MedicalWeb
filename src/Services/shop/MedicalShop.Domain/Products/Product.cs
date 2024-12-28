using MedicalShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MedicalShop.Domain.Products
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string Price { get; set; }
        public string BrandID { get; set; }
        public string CategoryID { get; set; }
        public string StockQuantity { get; set; }//تعداد موجودی محصول
        public string SKU { get; set; }//شماره محصول برای مدیریت موجودی.
        public string ImageURL { get; set; }//لینک به تصویر محصول
        public string Weight { get; set; }// وزن محصول
        public string Dimensions { get; set; }//ابعاد محصول (طول، عرض، ارتفاع)
        public string Warranty { get; set; }//مدت زمان گارانتی و شرایط آن
        public string Rating { get; set; }//میانگین امتیاز محصول از طرف کاربران.

        public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder) { }

        }
    }
}
