using MedicalShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News
{
    public class Comment:BaseEntity
    {
        public string NewsArticleID { get; set; }

        public string UserID { get; set; }
        public string Content { get; set; }
        public string PostedDate { get; set; }
    }
}
