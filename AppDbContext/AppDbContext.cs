using Microsoft.EntityFrameworkCore;
using Exosky.Models;

namespace Exosky.Data
{
    public class AppDbContext : DbContext
    {
        // Add-Migration init0 -Context AppDbContext
        // Update-Database -Context AppDbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QLS20Q3;Initial Catalog=ExoskyAPI;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Exoplanet> Exoplanets { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<SkyMap> SkyMaps { get; set; }
        public DbSet<Constellation> Constellations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SharedSkyMap> SharedSkyMaps { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
