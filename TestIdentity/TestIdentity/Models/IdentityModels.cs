using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace TestIdentity.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public virtual Organization Organizations { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}