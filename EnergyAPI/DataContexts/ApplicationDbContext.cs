using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnergyAPI.DataContexts {
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> {

        public ApplicationDbContext(DbContextOptions options) : base(options) {

        }
    }
}
