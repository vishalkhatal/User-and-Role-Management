using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestIdentity.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}