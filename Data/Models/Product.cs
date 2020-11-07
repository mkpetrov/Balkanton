using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public abstract class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [DataType("decimal(18, 3)")]
        public decimal Price { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();

        public ICollection<Comments> Comments { get; set; } = new HashSet<Comments>();

        public ICollection<ProductStoreQuantity> Quantities { get; set; } = new HashSet<ProductStoreQuantity>();

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
