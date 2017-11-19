using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bucket.Models
{
    public class ShopList: DbItem
    {
        public string ListName { get; set; }
        public virtual ICollection<ShopItem> Items { get; set; }
        public virtual User Owner { get; set; }
        public virtual Group Group { get; set; }
    }
}