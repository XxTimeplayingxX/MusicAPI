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
    }
}
