using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bucket.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }


        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}