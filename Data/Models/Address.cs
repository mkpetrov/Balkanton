using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string Area { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string LivingArea { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
