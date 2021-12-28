using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEF.Logic.Entities
{
    [Table("Albums")]
    [Index(nameof(ArtistId), IsUnique = false)]
    public class Album : EntityObject
    {
        public int ArtistId { get; set; }
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        // Navigation properties
        public Artist Artist { get; set; }
    }
}
