using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bucket.Models
{
    public class Group: DbItem
    {
        public string Name { get; set; }
        public DateTime Regdate { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public User Owner { get; set; }
    }
}