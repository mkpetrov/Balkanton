using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey(nameof(DeliveryAddress))]
        public int AddressId { get; set; }

        public Address DeliveryAddress { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required]
        [ForeignKey(nameof(Status))]
        public int StatusId { get; set; }

        public OrderStatus Status { get; set; }
    }
}
