
namespace CarsSparePartsShop.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.Comments = new HashSet<Comment>();
        }

        public string FullName { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
