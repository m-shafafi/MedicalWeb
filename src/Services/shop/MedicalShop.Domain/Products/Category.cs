using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products
{
    public class Category
    {
        public ulong ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string ParentCategoryID { get; set; }//در صورتی که دسته‌بندی به عنوان زیرمجموعه‌ی دسته دیگری باشد، این فیلد مشخص می‌کند که والد آن چیست.

    }
}
