using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using St_Patrick_and_St_Joseph_Choir_API.Data;
using St_Patrick_and_St_Joseph_Choir_API.Models;
using St_Patrick_and_St_Joseph_Choir_API.Models.Dto;
using System.Reflection.Metadata;

namespace St_Patrick_and_St_Joseph_Choir_API.Controllers
{
    [Route("api/MembersAPI")]
    [ApiController]
    public class MembersAPI : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public MembersAPI(ApplicationDbContext db)
        {
            _db = db;
        }

        // MEMBERS APIs
        [HttpGet(Name = "GetAllMembers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MemberDTO>> GetAllMembers()
        {
            return Ok(_db.Members.ToList());
        }

        [HttpGet("{status:int}", Name = "GetActiveMembers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<MemberDTO>> GetActiveMembers(int status)
        {
            var memberNames = _db.Members.Where(x => x.Status == status).Select(x => x.Name).ToList();

            return Ok(memberNames);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MemberDTO> CreateMember([FromBody] MemberDTO memberDTO)
        {
            if (_db.Members.FirstOrDefault(x => x.MemberId == memberDTO.MemberId) != null)
            {
                ModelState.AddModelError("CustomError", "Member already exists");
                return BadRequest(ModelState);
            }

            if (memberDTO == null)
            {
                return BadRequest(memberDTO);
            }

            if (memberDTO.MemberId > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            Member model = new Member()
            {
                MemberId = memberDTO.MemberId,
                Name = memberDTO.Name,
                Email = memberDTO.Email,
                Birthday = memberDTO.Birthday,
                Status = memberDTO.Status
            };

            _db.Members.Add(model);
            _db.SaveChanges();
            return Ok(model);

        }

        [HttpPut("{id:int}", Name = "UpdateMember")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateMember(int id, [FromBody] MemberDTO memberDTO)
        {
            if (memberDTO == null || id == 0) 
            { 
                return BadRequest(); 
            }

            Member model = new Member()
            {
                MemberId = memberDTO.MemberId,
                Name = memberDTO.Name,
                Email = memberDTO.Email,
                Birthday = memberDTO.Birthday,
                Status = memberDTO.Status
            };

            _db.Members.Update(model);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpDelete("id:int", Name = "DeleteMember")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteMember(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var member = _db.Members.FirstOrDefault(x => x.MemberId == id);

            if (member == null)
            {
                return NotFound();
            }

            _db.Members.Remove(member);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePartialMember(int id, JsonPatchDocument<MemberDTO> patchDTO)
        {
            if (patchDTO == null | id == 0)
            {
                return BadRequest();
            }

            var member = _db.Members.AsNoTracking().FirstOrDefault(x => x.MemberId == id);

            MemberDTO memberDTO = new()
            {
                MemberId = member.MemberId,
                Name = member.Name,
                Email = member.Email,
                Birthday = member.Birthday,
                Status = member.Status
            };

            if (member == null)
            {
                return NotFound();
            };

            patchDTO.ApplyTo(memberDTO, ModelState);

            Member model = new Member()
            {
                MemberId = memberDTO.MemberId,
                Name = memberDTO.Name,
                Email = memberDTO.Email,
                Birthday = memberDTO.Birthday,
                Status = memberDTO.Status
            };

            _db.Members.Update(model);
            _db.SaveChanges();

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
