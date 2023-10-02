using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace St_Patrick_and_St_Joseph_Choir_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateMusicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YoutubeUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusicSheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Soloist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "MusicSheet", "Soloist", "Song", "Title", "YoutubeUrl" },
                values: new object[,]
                {
                    { 1, null, "", "Processional/Entrance", "", "" },
                    { 2, null, "", "Gloria", "", "" },
                    { 3, null, "", "Psalm", "", "" },
                    { 4, null, "", "Gospel Acclamation", "", "" },
                    { 5, null, "", "Offertory", "", "" },
                    { 6, null, "", "Holy", "", "" },
                    { 7, null, "", "Memorial Acclamation", "", "" },
                    { 8, null, "", "Lamb of God", "", "" },
                    { 9, null, "", "Communion", "", "" },
                    { 10, null, "", "Recessional", "", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}
