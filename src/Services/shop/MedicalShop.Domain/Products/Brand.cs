using MedicalShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products
{
    public class Brands:BaseEntity
    {
            public string Name { get; set; }

        public string LogoURL { get; set; }
        public string Description { get; set; }
    }
}
