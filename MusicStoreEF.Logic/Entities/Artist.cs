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
    [Table("Artists")]
    [Index(nameof(Name), IsUnique = true)]
    public class Artist : EntityObject
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        // Navigation properties
        public List<Album> Albums { get; set; }
    }
}
