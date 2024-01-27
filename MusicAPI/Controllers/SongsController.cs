using Microsoft.AspNetCore.Mvc;
using MusicAPI.Data;
using MusicAPI.Models;

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
        public Song Get(int id)
        {
            return dbContext.Songs.Find(id);
        }

        // POST api/<SongsController>
        [HttpPost]
        public IActionResult Post([FromBody] Song newSong)
        {
            dbContext.Songs.Add(newSong);
            dbContext.SaveChanges();
            return Ok();
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Song updatedSong)
        {
            var song = dbContext.Songs.Find(id);

            song.Title = 
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(Song id)
        {
            var song = dbContext.Songs.Find()
        }
    }
}
