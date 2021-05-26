using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class DonationDbContext : DbContext
    {
        public DonationDbContext(DbContextOptions<DonationDbContext> options) : base(options)
        {
        }

        public DbSet<DCandidate> DCandidates { get; set; }
    }
}