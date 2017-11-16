using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bucket.DAL
{
    public class BucketContext: DbContext
    {
        public BucketContext() : base("DefaultConnection")
        {
        }
    }
}