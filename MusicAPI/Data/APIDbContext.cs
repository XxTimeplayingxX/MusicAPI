using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;

namespace MusicAPI.Data
{
    public class APIDbContext : DbContext
    {
        //Necesita opciones un constructor donde agregamos las opciones
        public APIDbContext(DbContextOptions<APIDbContext> options) 
            : base (options)
        {
            
        }
        public DbSet<Song> Songs{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var song1 = new Song() { ID = 1, Title = "Data Seed1", Language = "English", Duration = "3:00" };
            var song2 = new Song() { ID = 2, Title = "Data Seed2", Language = "English", Duration = "2:30" };
            var song3 = new Song() { ID = 3, Title = "Data Seed3", Language = "Spanish", Duration = "3:50" };
            var song4 = new Song() { ID = 4, Title = "Data Seed4", Language = "Spanish", Duration = "7:00" };

            modelBuilder.Entity<Song>().HasData(new Song[] { song1, song2, song3, song4 });
        }
    }
}
