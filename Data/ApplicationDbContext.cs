using Microsoft.EntityFrameworkCore;
using WebLearningMVCEF.Models;

namespace WebLearningMVCEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
