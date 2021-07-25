
namespace CarsSparePartsShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            this.OrderParts = new HashSet<OrderPart>();

        }
        public string Id { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderPlaced { get; set; }

        public bool IsActived { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<OrderPart> OrderParts { get; set; }
    }
}
