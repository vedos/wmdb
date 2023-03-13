using api_service.Model;
using Microsoft.EntityFrameworkCore;

namespace api_service.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) :base(options) 
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
