using MC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.Models.Model
{
    public class NetworkModel
    {
        public int NetworkId { get; set; }

        public string Name { get; set; }

        public List<ItemModel> Items { get; set; }
    }
}
