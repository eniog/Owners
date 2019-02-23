using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace mistrzowiewynajmu.Models.Database
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

        public DbSet<Property> Properties { get; set; }
        public DbSet<Owner> Owners  { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
