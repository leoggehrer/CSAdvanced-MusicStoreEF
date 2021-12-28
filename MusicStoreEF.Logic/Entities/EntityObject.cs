using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEF.Logic.Entities
{
    public abstract class EntityObject
    {
        [Key]
        public int Id { get; set; }
    }
}
