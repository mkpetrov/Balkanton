using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [DataType("decimal(18, 3)")]
        public decimal MyProperty { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();

        public ICollection<Comments> Comments { get; set; } = new HashSet<Comments>();

        public ICollection<ProductStoreQuantity> Quantities { get; set; } = new HashSet<ProductStoreQuantity>();
    }
}
