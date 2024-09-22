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

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-3HFKTLSG\\SQL2022;Integrated Security=True; Database=ExoskyAPI;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
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
    }
}
