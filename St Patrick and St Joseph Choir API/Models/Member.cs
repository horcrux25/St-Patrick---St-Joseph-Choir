using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace St_Patrick_and_St_Joseph_Choir_API.Models
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public DateTime? Birthday { get; set; }
        public int Status { get; set; }
        // 1 - Active, 2 - Inactive, 3 - Semi-Regular
    }
}
