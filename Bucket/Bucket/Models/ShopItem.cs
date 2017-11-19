using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bucket.Models
{
    public class ShopItem: DbItem
    {
        public string Name { get; set; }
        public ItemType ItemType { get; set; }
        public ItemState ItemState { get; set; }
    }

    public enum ItemType
    {
        Food,
        Drink,
        Other
    }

    public enum ItemState
    {
        New,
        Bought,
        Removed
    }

    
}