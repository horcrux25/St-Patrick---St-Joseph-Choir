using System.ComponentModel.DataAnnotations;

namespace St_Patrick_and_St_Joseph_Choir_API.Models.Dto
{
    public class MusicDTO
    {
        public int Id { get; set; }
        [Required]
        public string Song { get; set; }
        [Required]
        public string Title { get; set; }
        public string YoutubeUrl { get; set; }
        public byte[]? MusicSheet { get; set; }
        public string Soloist { get; set; }
    }
}
