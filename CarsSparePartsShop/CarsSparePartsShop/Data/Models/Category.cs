
namespace CarsSparePartsShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Category
    {
        public Category()
        {
            this.Parts = new HashSet<Part>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
