using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RigioREST.Models
{
    public abstract class EntityBase
    {
        public int id { get; set; }
        
        public DateTime createdAt { get; set; }

        public DateTime lastModifiedAt { get; set; }
    }
}
