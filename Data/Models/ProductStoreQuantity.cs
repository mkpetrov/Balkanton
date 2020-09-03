using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class ProductStoreQuantity
    {
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey(nameof(Store))]
        [Required]
        public int StoreId { get; set; }

        public Store Store { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
