using EncounterMeAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EncounterMeAPI.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Trail> Trails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var trail = modelBuilder.Entity<Trail>();

            trail.HasKey(x => x.Id);
            trail.Property(x => x.UploadDate)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
