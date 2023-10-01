using Microsoft.EntityFrameworkCore;
using St_Patrick_and_St_Joseph_Choir_API.Models;

namespace St_Patrick_and_St_Joseph_Choir_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Music>().HasData(
                new Music()
                {
                    Id = 1,
                    Song = "Processional/Entrance",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 2,
                    Song = "Gloria",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 3,
                    Song = "Psalm",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 4,
                    Song = "Gospel Acclamation",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 5,
                    Song = "Offertory",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 6,
                    Song = "Holy",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 7,
                    Song = "Memorial Acclamation",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 8,
                    Song = "Lamb of God",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 9,
                    Song = "Communion",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    Id = 10,
                    Song = "Recessional",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                }
            );
        }
    }
}
