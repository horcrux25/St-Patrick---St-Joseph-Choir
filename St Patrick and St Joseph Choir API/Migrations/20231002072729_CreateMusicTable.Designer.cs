﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using St_Patrick_and_St_Joseph_Choir_API.Data;

#nullable disable

namespace St_Patrick_and_St_Joseph_Choir_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231002072729_CreateMusicTable")]
    partial class CreateMusicTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("St_Patrick_and_St_Joseph_Choir_API.Models.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("MusicSheet")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Soloist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Song")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Musics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Soloist = "",
                            Song = "Processional/Entrance",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 2,
                            Soloist = "",
                            Song = "Gloria",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 3,
                            Soloist = "",
                            Song = "Psalm",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 4,
                            Soloist = "",
                            Song = "Gospel Acclamation",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 5,
                            Soloist = "",
                            Song = "Offertory",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 6,
                            Soloist = "",
                            Song = "Holy",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 7,
                            Soloist = "",
                            Song = "Memorial Acclamation",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 8,
                            Soloist = "",
                            Song = "Lamb of God",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 9,
                            Soloist = "",
                            Song = "Communion",
                            Title = "",
                            YoutubeUrl = ""
                        },
                        new
                        {
                            Id = 10,
                            Soloist = "",
                            Song = "Recessional",
                            Title = "",
                            YoutubeUrl = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}