using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AirlineCompany> AirlineCompanies { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}
