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
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<EventPlace> EventsPlaces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<PrizeType> PrizesTypes { get; set; }
        public DbSet<PrizeCategory> PrizesCategories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }
        public DbSet<PegiType> PegiesTypes { get; set; }
        public DbSet<EventType> EventsTypes { get; set; }
        public DbSet<PodiumRanking> PodiumsRankings { get; set; }
        public DbSet<RoleType> RolesTypes { get; set; }

    }
}
