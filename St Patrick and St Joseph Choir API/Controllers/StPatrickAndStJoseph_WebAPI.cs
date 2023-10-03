using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using St_Patrick_and_St_Joseph_Choir_API.Data;
using St_Patrick_and_St_Joseph_Choir_API.Models;
using St_Patrick_and_St_Joseph_Choir_API.Models.Dto;
using System.ComponentModel;

namespace St_Patrick_and_St_Joseph_Choir_API.Controllers
{
    [Route("api/MusicAPI")]
    [ApiController]
    public class ChoirMusic_WebAPI : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ChoirMusic_WebAPI(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MusicDTO>> GetMassSongs()
        {
            return Ok(_db.Musics.ToList());
        }

        [HttpGet("{song}", Name = "GetSongLists")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<MusicDTO>> GetSongLists(string song)
        {
            if (song.Equals(""))
            {
                return BadRequest();
            }

            var musicList = _db.Musics.Where(x => x.Song == song).ToList();
            
            if (musicList == null | musicList.Count == 0)
            {
                return NotFound();
            }

            return Ok(musicList);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MusicDTO> CreateSong([FromBody] MusicDTO musicDTO)
        {
            if (_db.Musics.FirstOrDefault(x => 
                x.Song.ToLower() == musicDTO.Song.ToLower() & 
                x.Title.ToLower() == musicDTO.Title.ToLower()) 
                != null)
            {
                ModelState.AddModelError("CustomError", "Song Already Exists");
                return BadRequest(ModelState);
            } 

            if (musicDTO == null)
            {
                return BadRequest(musicDTO);
            }

            if (musicDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            Music model = new Music()
            {
                Id = musicDTO.Id,
                Song = musicDTO.Song,
                Title = musicDTO.Title,
                YoutubeUrl = musicDTO.YoutubeUrl,
                MusicSheet = musicDTO.MusicSheet,
                Soloist = musicDTO.Soloist
            };

            _db.Musics.Add(model);
            _db.SaveChanges();

            return Ok(model);
        }

        [HttpDelete("{id:int}",Name ="DeleteSong")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteSong(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var music = _db.Musics.FirstOrDefault(x => x.Id == id);

            if (music == null)
            {
                return NotFound();
            }

            _db.Musics.Remove(music);
            _db.SaveChanges();
            return NoContent();
        }
    };
}
