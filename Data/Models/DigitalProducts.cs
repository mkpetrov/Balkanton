using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    [Table("DigitalProducts")]
    public class DigitalProducts : Product
    {
        public bool IsSong { get; set; }

        public int? AlbumId { get; set; }

        [ForeignKey(nameof(AlbumId))]
        public DigitalProducts Album { get; set; }

        ICollection<DigitalProducts> AlbumSongs { get; set; } = new HashSet<DigitalProducts>();
    }
}
