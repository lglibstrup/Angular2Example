using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.Models.Entities
{
    public class Network
    {
        public int NetworkId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
