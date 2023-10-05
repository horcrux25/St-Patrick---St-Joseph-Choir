using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace St_Patrick_and_St_Joseph_Choir_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    MusicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusicSheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Soloist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.MusicId);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "Birthday", "Email", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ljane.dio@gmail.com", "Lucy D", 1 },
                    { 2, new DateTime(2000, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "thomasjbpark324@gmail.com", "Thomas", 1 },
                    { 3, new DateTime(2000, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "audeehalim@gmail.com", "Audee", 1 },
                    { 4, new DateTime(2000, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "jericjaymallari@gmail.com", "Jeric", 1 },
                    { 5, new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "adavalsantos@gmail.com", "Ally", 1 },
                    { 6, new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Delysse", 3 },
                    { 7, new DateTime(2000, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sonadavsan@gmail.com", "Sona", 1 },
                    { 8, new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "sabinalama@gmail.com", "Sabina", 1 },
                    { 9, new DateTime(2000, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "mr.khoa1412@gmail.com", "Kelvin", 1 },
                    { 10, new DateTime(2000, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ninzrevalde@gmail.com", "Niña", 1 },
                    { 11, new DateTime(2000, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "jfbenavid@gmail.com", "Fabian", 1 },
                    { 12, new DateTime(2000, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "acanjohnpaul07@gmail.com", "Paul", 1 },
                    { 13, new DateTime(2000, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikkoverdionisio@yahoo.co.nz", "Nikko", 1 },
                    { 14, new DateTime(2000, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "maye.benitezparra@gmail.com", "Mayerly", 1 },
                    { 15, new DateTime(2000, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "agonhd@gmail.com", "Harsen", 1 },
                    { 16, new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucia.dk83@gmail.com", "Lucia K", 1 },
                    { 17, new DateTime(2000, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "willsenwijaya@gmail.com", "Willsen", 1 },
                    { 18, new DateTime(2000, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "omallnico@myvuw.ac.nz", "Nicola", 1 },
                    { 19, null, "verondionisio@yahoo.co.nz", "Veronica", 2 }
                });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "MusicId", "MusicSheet", "Soloist", "Song", "Title", "YoutubeUrl" },
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
                name: "Members");

            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}
