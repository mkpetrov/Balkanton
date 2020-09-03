using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Code { get; set; }

        [ForeignKey(nameof(Store))]
        [Required]
        public int StoreId { get; set; }

        public Store Store { get; set; }

        [Required]
        public string Position { get; set; }

        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }

        public Employee Manager { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
