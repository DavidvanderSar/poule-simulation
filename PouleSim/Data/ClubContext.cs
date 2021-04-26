using Microsoft.EntityFrameworkCore;
using PouleSim.Models;

namespace PouleSim.Data
{
    public class ClubContext : DbContext
    {
        public ClubContext (DbContextOptions<ClubContext> options)
            : base(options)
        {
        }

        public DbSet<Club> Club { get; set; }
    }
}