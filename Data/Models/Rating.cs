using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public double ProductRating { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }
        
        public Client Client { get; set; }
    }
}
