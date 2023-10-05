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
    public class MusicsAPI : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public MusicsAPI(ApplicationDbContext db)
        {
            _db = db;
        }

        // MUSIC APIs
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MusicDTO>> GetMassSongs()
        {
            var musicList = _db.Musics.Select(x => x.Song).Distinct().ToList();

            return Ok(musicList);
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

            if (musicDTO.MusicId > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            Music model = new Music()
            {
                MusicId = musicDTO.MusicId,
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

        [HttpPut("{id:int}", Name = "UpdateSong")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateSong(int id, [FromBody] MusicDTO musicDTO)
        {
            if (musicDTO == null || id == 0)
            {
                return BadRequest();
            }

            Music model = new Music()
            {
                MusicId = musicDTO.MusicId,
                Song = musicDTO.Song,
                Title = musicDTO.Title,
                YoutubeUrl = musicDTO.YoutubeUrl,
                MusicSheet = musicDTO.MusicSheet,
                Soloist = musicDTO.Soloist
            };

            _db.Musics.Update(model);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id:int}", Name = "DeleteSong")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteSong(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var music = _db.Musics.FirstOrDefault(x => x.MusicId == id);

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
