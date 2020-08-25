using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class ProductStoreQuantity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey(nameof(Store))]
        public int StoreId { get; set; }

        public Store Store { get; set; }

        public int Quantity { get; set; }
    }
}
