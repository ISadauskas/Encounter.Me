using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Data
{
    public class EncounterMeContext : DbContext
    {
        public DbSet<Trails> Trails { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Runs> Runs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = encountermedbserver.database.windows.net; Initial Catalog = EncounterMeDb; User ID = Adminas1; Password = Password1");
        }
    }
}
