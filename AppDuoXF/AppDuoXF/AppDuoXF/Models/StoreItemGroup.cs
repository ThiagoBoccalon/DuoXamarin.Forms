using System;
using System.Collections.Generic;
using System.Text;

namespace AppDuoXF.Models
{
    public class StoreItemGroup : List<StoreItem>
    {
        public string Name { get; private set; }

        public StoreItemGroup(string name, List<StoreItem> storeItems)
        {
            Name = name;
            AddRange(storeItems);
        }
    }
}
