using Microsoft.EntityFrameworkCore;
using St_Patrick_and_St_Joseph_Choir_API.Models;
using System.Globalization;

namespace St_Patrick_and_St_Joseph_Choir_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Music> Musics { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Music>().HasData(
                new Music()
                {
                    MusicId = 1,
                    Song = "Processional/Entrance",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 2,
                    Song = "Gloria",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 3,
                    Song = "Psalm",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 4,
                    Song = "Gospel Acclamation",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 5,
                    Song = "Offertory",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 6,
                    Song = "Holy",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 7,
                    Song = "Memorial Acclamation",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 8,
                    Song = "Lamb of God",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 9,
                    Song = "Communion",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                },
                new Music()
                {
                    MusicId = 10,
                    Song = "Recessional",
                    Title = "",
                    YoutubeUrl = "",
                    MusicSheet = null,
                    Soloist = ""
                }
            );

            modelBuilder.Entity<Member>().HasData(
                new Member()
                {
                    MemberId = 1,
                    Name = "Lucy D",
                    Email = "ljane.dio@gmail.com",
                    Birthday = DateTime.Parse("2000/03/20"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 2,
                    Name = "Thomas",
                    Email = "thomasjbpark324@gmail.com",
                    Birthday = DateTime.Parse("2000/03/24"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 3,
                    Name = "Audee",
                    Email = "audeehalim@gmail.com",
                    Birthday = DateTime.Parse("2000/04/08"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 4,
                    Name = "Jeric",
                    Email = "jericjaymallari@gmail.com",
                    Birthday = DateTime.Parse("2000/04/25"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 5,
                    Name = "Ally",
                    Email = "adavalsantos@gmail.com",
                    Birthday = DateTime.Parse("2000/05/18"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 6,
                    Name = "Delysse",
                    Email = "",
                    Birthday = DateTime.Parse("2000/05/18"),
                    Status = 3
                },
                new Member()
                {
                    MemberId = 7,
                    Name = "Sona",
                    Email = "sonadavsan@gmail.com",
                    Birthday = DateTime.Parse("2000/05/25"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 8,
                    Name = "Sabina",
                    Email = "sabinalama@gmail.com",
                    Birthday = DateTime.Parse("2000/06/02"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 9,
                    Name = "Kelvin",
                    Email = "mr.khoa1412@gmail.com",
                    Birthday = DateTime.Parse("2000/06/21"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 10,
                    Name = "Niña",
                    Email = "ninzrevalde@gmail.com",
                    Birthday = DateTime.Parse("2000/06/22"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 11,
                    Name = "Fabian",
                    Email = "jfbenavid@gmail.com",
                    Birthday = DateTime.Parse("2000/07/03"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 12,
                    Name = "Paul",
                    Email = "acanjohnpaul07@gmail.com",
                    Birthday = DateTime.Parse("2000/08/10"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 13,
                    Name = "Nikko",
                    Email = "nikkoverdionisio@yahoo.co.nz",
                    Birthday = DateTime.Parse("2000/09/02"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 14,
                    Name = "Mayerly",
                    Email = "maye.benitezparra@gmail.com",
                    Birthday = DateTime.Parse("2000/09/26"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 15,
                    Name = "Harsen",
                    Email = "agonhd@gmail.com",
                    Birthday = DateTime.Parse("2000/09/26"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 16,
                    Name = "Lucia K",
                    Email = "lucia.dk83@gmail.com",
                    Birthday = DateTime.Parse("2000/11/11"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 17,
                    Name = "Willsen",
                    Email = "willsenwijaya@gmail.com",
                    Birthday = DateTime.Parse("2000/12/10"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 18,
                    Name = "Nicola",
                    Email = "omallnico@myvuw.ac.nz",
                    Birthday = DateTime.Parse("2000/12/11"),
                    Status = 1
                },
                new Member()
                {
                    MemberId = 19,
                    Name = "Veronica",
                    Email = "verondionisio@yahoo.co.nz",
                    Birthday = null,
                    Status = 2
                }
            );
        }
    }
}
