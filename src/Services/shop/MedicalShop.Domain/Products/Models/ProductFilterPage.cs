using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products.Models
{
    public class ProductFilterPage
    {
        public int Id { get; set; }
        public string SearchTerm { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int CategoryId { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }


    }
}
