using HelpPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpPlatform.Data
{
    public class BlazorDbContext : DbContext
    {
        public BlazorDbContext(DbContextOptions<BlazorDbContext> options) : base(options) { }

        public DbSet<DonationRequest> DonationRequests { get; set; }
    }
}
