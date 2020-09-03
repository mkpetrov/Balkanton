using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }

        [Required]
        public string StatusName { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
