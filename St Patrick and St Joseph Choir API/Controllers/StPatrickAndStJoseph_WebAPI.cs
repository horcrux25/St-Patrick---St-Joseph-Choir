using Microsoft.AspNetCore.Mvc;
using St_Patrick_and_St_Joseph_Choir_API.Data;
using St_Patrick_and_St_Joseph_Choir_API.Models.Dto;

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
        public ActionResult<IEnumerable<MusicDTO>> GetMusic()
        {
            return Ok(_db.Musics.ToList());
        }

    };
}
