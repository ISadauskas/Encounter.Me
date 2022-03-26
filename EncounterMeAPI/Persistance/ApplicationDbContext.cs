using EncounterMeAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EncounterMeAPI.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        DbSet<Trail> Trails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var trail = modelBuilder.Entity<Trail>();

            trail.HasKey(x => x.Id);
            trail.Property(x => x.UploadDate)
                .HasField("_uploadDate")
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
