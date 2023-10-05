using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace St_Patrick_and_St_Joseph_Choir_API.Models
{
    public class Music
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MusicId { get; set; }
        public string? Song { get; set; }
        public string? Title { get; set; }
        public string? YoutubeUrl { get; set; }
        public byte[]? MusicSheet { get; set; }
        public string? Soloist { get; set; }
    }
}
