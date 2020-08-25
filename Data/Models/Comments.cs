using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Comments
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Comment { get; set; }

        [Required]
        public DateTime AddDate { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
