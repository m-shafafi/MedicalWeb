using MedicalShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News
{
    public class NewsArticle:BaseEntity
    {
        public string Title { get; set; }

        public string Summary { get; set; }//خلاصه‌ای از محتوای خبر
        public string Content { get; set; }   //محتوای کامل خبر
        public string AuthorID { get; set; }  //نویسنده خبر 
        public string CategoryID { get; set; }   //دسته‌بندی خبر (اخبار، معرفی محصول، تخفیف‌ها و غیره)
        public string PublishedDate { get; set; }   //تاریخ انتشار خبر
        public string Tags { get; set; }   //برچسب‌های مرتبط با خبر (آرایه‌ای از کلمات کلیدی)
        public string ImageURL { get; set; }   // لینک به تصویر یا تصاویر مرتبط با خبر.
        public string ViewsCount { get; set; }
        public string Comments { get; set; }   //لیستی از نظرات کاربران
        public string ShareableLink { get; set; }  //لینک اختصاصی برای اشتراک‌گذاری خبر
    }
}
