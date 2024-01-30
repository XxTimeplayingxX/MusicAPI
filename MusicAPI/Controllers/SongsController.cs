using Microsoft.AspNetCore.Mvc;
using MusicAPI.Data;
using MusicAPI.DTO;
using MusicAPI.Models;
using System.Net;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly APIDbContext dbContext;

        public SongsController(APIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return dbContext.Songs;
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("El ID debe de ser mayor que 0");
            }
            Song song = dbContext.Songs.Find(id);
            if (song == null)
            {
                return NotFound("Héroe NO encontrado");
            }
            return Ok(song);
        }

        // POST api/<SongsController>
        [HttpPost]
        //Aquí cambiamos y va a recibir un objeto DTP
        public IActionResult Post([FromBody] SongDTO newSong)
        {
            if (newSong == null)
            {
                return BadRequest("Los datos de la música están vacíos");
            }
            if ((string.IsNullOrEmpty(newSong.Title)) || string.IsNullOrEmpty(newSong.Language))
            {
                return BadRequest("Uno de los campos esta vacío");
            }
            var song = new Song
            {
                Title = newSong.Title,
                Language = newSong.Language
            };
            dbContext.Songs.Add(song);
            dbContext.SaveChanges();
            return Ok();
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Song updatedSong)
        {
            if(updatedSong == null)
            {
                return BadRequest("los datos son nulos");
            }

            var existingSong = dbContext.Songs.Find(id);

            if(existingSong == null)
            {
                return BadRequest("Canción NO encontrada");
            }


            existingSong.Title = updatedSong.Title;
            existingSong.Language = updatedSong.Language;   

            dbContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Song id)
        {
            var songToDelete = dbContext.Songs.Find(id);
            if (songToDelete != null)
            {
                dbContext.Songs.Remove(songToDelete);
                dbContext.SaveChanges();
            }
            return Ok();
        }
    }
}
