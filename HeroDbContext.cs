using Microsoft.EntityFrameworkCore;
using CrudWebApi.Model;
namespace CrudWebApi
{
    public class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options)
        {
        }

        public DbSet<Hero> Heros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>().Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}
