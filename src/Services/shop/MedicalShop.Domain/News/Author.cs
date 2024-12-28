using MedicalShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.News
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }

        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }
    }
}
