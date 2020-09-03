using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Password { get; set; }

        public byte[] AvatarImage { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();

        public ICollection<Comments> Comments { get; set; } = new HashSet<Comments>();

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
