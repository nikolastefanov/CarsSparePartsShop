

namespace CarsSparePartsShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Part
    {
        public Part()
        {
            this.OrderParts = new HashSet<OrderPart>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Manufacturer { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public int Available { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<OrderPart> OrderParts { get; set; }

    }
}
