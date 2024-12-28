using MedicalShop.Domain.Base;
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

        public string ParentCategoryID { get; set; }//شناسه دسته‌بندی والد (در صورت وجود). این فیلد برای ایجاد زیرمجموعه‌ها (Subcategories) استفاده می‌شود.
        public string Slug { get; set; }   //آدرس یکتا برای دسته‌بندی که در URL استفاده می‌شود (مثلاً "medical-news" برای دسته‌بندی اخبار پزشکی).
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
