using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.Models.Model
{
    public class ItemModel
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public int BlockId { get; set; }

        public int BlockMetaData { get; set; }

        public double NumberStored { get; set; }

        public int NetworkId { get; set; }
    }
}
