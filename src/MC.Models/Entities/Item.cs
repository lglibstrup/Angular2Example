using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.Models.Entities
{
    public class Item
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public int BlockId { get; set; }

        public int BlockMetaData { get; set; }

        public double NumberStored { get; set; }

        public int NetworkId { get; set; }
    }
}
