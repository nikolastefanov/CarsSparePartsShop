
namespace CarsSparePartsShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderPart
    {
        public string OrderId { get; set; }

        public Order Order { get; set; }

        public int PartId { get; set; }

        public Part Part { get; set; }

    }
}
