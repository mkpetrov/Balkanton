using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("PhysicalProduct")]
    public class PhysicalProduct : Product
    {
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
