using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Base
{
    public abstract class BaseEntity<TKey>
    {
        public TKey ID { get; set; }
        public DateTime CreationDateTime { get; set; } = DateTime.UtcNow;
        public DateTime MOdificationDateTime { get; set; } = DateTime.UtcNow;
    }
    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}
