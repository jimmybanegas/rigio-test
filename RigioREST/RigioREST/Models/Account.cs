using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RigioREST.Models
{
    public class Account : EntityBase
    {
        public string name { get; set; }

        public string email { get; set; }

    }
}
