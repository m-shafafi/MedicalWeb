using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class AddProductEvent:IntegrationBaseEvent
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? BrandID { get; set; }
        public int? CategoryID { get; set; }
        public string StockQuantity { get; set; }
        public string SKU { get; set; }
        public string ImageURL { get; set; }
        public string Warranty { get; set; }
        public int Rating { get; set; }
    }
}
