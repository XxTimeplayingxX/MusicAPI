using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAPI.Models;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private static List<Song> _songs = new List<Song>
        {
            new Song
            {
                ID = 1,
                Title = "Almost Home",
                Language = "English"
            },
            new Song
            {
                ID = 2,
                Title = "Yeah",
                Language = "English"
            },
            new Song
            {
                ID = 3,
                Title = "Entre Nosotros",
                Language = "Español"
            }


        };

        [HttpGet]//Mediante este controlador podemos hacer la petición
        public IEnumerable<Song> GetAllSongs()
        {
            return _songs;
        }
    }
}
