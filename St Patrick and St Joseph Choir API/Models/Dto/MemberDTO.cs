using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace St_Patrick_and_St_Joseph_Choir_API.Models.Dto
{
    public class MemberDTO
    {
        public int MemberId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthday { get; set; }
        public int Status { get; set; }
    }
}
