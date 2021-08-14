using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Identity
{
    public partial class IdentityContext<TUser> : IdentityDbContext<TUser> 
        where TUser : ApplicationUser
    {
        public IdentityContext(DbContextOptions<IdentityContext<TUser>> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().Ignore(c => c.ConcurrencyStamp)
                                           .Ignore(c => c.NormalizedEmail)
                                           .Ignore(c => c.SecurityStamp)
                                           .Ignore(c => c.Email)
                                           .Ignore(c => c.TwoFactorEnabled)
                                           .Ignore(c => c.PhoneNumber)
                                           .Ignore(c => c.EmailConfirmed)
                                           .Ignore(c => c.PhoneNumberConfirmed);
            builder.Entity<ApplicationUser>().ToTable("User");

        }
    }
}
