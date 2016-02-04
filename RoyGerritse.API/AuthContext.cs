using RoyGerritse.API.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace RoyGerritse.API
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {
     
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }

}