using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace API.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
