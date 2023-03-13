﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_service.Data;

namespace api_service.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20230312143522_create")]
    partial class create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CastItem", b =>
                {
                    b.Property<int>("CastsId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("CastsId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("CastItem");

                    b.HasData(
                        new
                        {
                            CastsId = 1,
                            ItemsId = 1
                        },
                        new
                        {
                            CastsId = 2,
                            ItemsId = 1
                        },
                        new
                        {
                            CastsId = 3,
                            ItemsId = 2
                        },
                        new
                        {
                            CastsId = 1,
                            ItemsId = 2
                        },
                        new
                        {
                            CastsId = 4,
                            ItemsId = 3
                        },
                        new
                        {
                            CastsId = 5,
                            ItemsId = 3
                        },
                        new
                        {
                            CastsId = 6,
                            ItemsId = 4
                        },
                        new
                        {
                            CastsId = 5,
                            ItemsId = 4
                        },
                        new
                        {
                            CastsId = 6,
                            ItemsId = 5
                        },
                        new
                        {
                            CastsId = 2,
                            ItemsId = 5
                        },
                        new
                        {
                            CastsId = 1,
                            ItemsId = 6
                        },
                        new
                        {
                            CastsId = 3,
                            ItemsId = 6
                        },
                        new
                        {
                            CastsId = 4,
                            ItemsId = 7
                        },
                        new
                        {
                            CastsId = 3,
                            ItemsId = 7
                        },
                        new
                        {
                            CastsId = 5,
                            ItemsId = 8
                        },
                        new
                        {
                            CastsId = 6,
                            ItemsId = 8
                        });
                });

            modelBuilder.Entity("api_service.Model.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Casts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Keanu Reeves"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Leo DiCaprio"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Liam Neeson"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Bruno Ganz"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Diane Kruger"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Rainer Bock"
                        });
                });

            modelBuilder.Entity("api_service.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Movie",
                            Tag = "movies"
                        },
                        new
                        {
                            Id = 2,
                            Name = "TV Shows",
                            Tag = "shows"
                        });
                });

            modelBuilder.Entity("api_service.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                            ReleaseDate = new DateTime(1999, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://flxt.tmsimg.com/assets/p22804_p_v10_ab.jpg",
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A young Algerian man is sent to a French prison.",
                            ReleaseDate = new DateTime(2009, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://upload.wikimedia.org/wikipedia/en/d/d1/A_Prophet.jpg",
                            Title = "A Prophet"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                            ReleaseDate = new DateTime(1972, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY1200_CR107,0,630,1200_AL_.jpg",
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.",
                            ReleaseDate = new DateTime(2006, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://flxt.tmsimg.com/assets/p163191_p_v10_an.jpg",
                            Title = "300"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "After earning 00 status and a licence to kill, Secret Agent James Bond sets out on his first mission as 007. Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.",
                            ReleaseDate = new DateTime(2006, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://m.media-amazon.com/images/M/MV5BMDI5ZWJhOWItYTlhOC00YWNhLTlkNzctNDU5YTI1M2E1MWZhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_.jpg",
                            Title = "Casino Royale"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "After losing Vanessa (Morena Baccarin), the love of his life, 4th-wall breaking mercenary Wade Wilson aka Deadpool (Ryan Reynolds) must assemble a team and protect a young, full-figured mutant Russell Collins aka Firefist (Julian Dennison) from Cable (Josh Brolin), a no-nonsense, dangerous cyborg from the future, and must also learn the most important lesson of all: to be part of a family again.",
                            ReleaseDate = new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://img.yts.mx/assets/images/movies/deadpool_2_2018/medium-cover.jpg",
                            Title = "Deadpool 2"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against the enemies of Outworld in a high stakes battle for the universe.",
                            ReleaseDate = new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/2xmx8oPlbDaxTjHsIOZvOt5L3aJ.jpg",
                            Title = "Mortal Kombat"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "",
                            ReleaseDate = new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/pwDvkDyaHEU9V7cApQhbcSJMG1w.jpg",
                            Title = "Cherry"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Raya and the Last Dragon",
                            ReleaseDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg",
                            Title = "Raya and the Last Dragon"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "",
                            ReleaseDate = new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6vcDalR50RWa309vBH1NLmG2rjQ.jpg",
                            Title = "The Marksman"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "",
                            ReleaseDate = new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/29dCusd9PwHrbDqzxNG35WcpZpS.jpg",
                            Title = "Twist"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 1,
                            Description = "",
                            ReleaseDate = new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/t6HIqrRAclMCA60NsSmeqe9RmNV.jpg",
                            Title = "Avatar: The Way of Water"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.",
                            ReleaseDate = new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://m.media-amazon.com/images/M/MV5BMTc5ZmM0OTQtNDY4MS00ZjMyLTgwYzgtOGY0Y2VlMWFmNDU0XkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg",
                            Title = "The Walking Dead"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "A gritty chronicle of the war against Colombia's infamously violent and powerful drug cartels.",
                            ReleaseDate = new DateTime(2015, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rTmal9fDbwh5F0waol2hq35U4ah.jpg",
                            Title = "Narcos"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Twenty years after modern civilization has been destroyed, Joel, a hardened survivor, is hired to smuggle Ellie, a 14-year-old girl, out of an oppressive quarantine zone. What starts as a small job soon becomes a brutal, heartbreaking journey, as they both must traverse the United States and depend on each other for survival.",
                            ReleaseDate = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/uKvVjHNqB5VmOrdxqAt2F7J78ED.jpg",
                            Title = "The Last of Us"
                        });
                });

            modelBuilder.Entity("api_service.Model.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("api_service.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 45, 131, 171, 130, 198, 157, 191, 192, 136, 217, 5, 45, 197, 79, 205, 56, 165, 209, 188, 217, 71, 73, 18, 189, 219, 179, 48, 193, 1, 133, 136, 219, 60, 176, 55, 199, 115, 234, 91, 0, 18, 98, 136, 123, 158, 158, 138, 104, 5, 247, 237, 7, 245, 120, 116, 189, 181, 19, 201, 99, 22, 79, 34, 48 },
                            PasswordSalt = new byte[] { 249, 100, 222, 207, 35, 186, 165, 11, 70, 150, 111, 6, 229, 19, 174, 127, 164, 190, 104, 26, 55, 250, 43, 123, 197, 189, 71, 184, 239, 115, 168, 191, 28, 223, 253, 144, 184, 225, 60, 85, 143, 208, 189, 238, 79, 112, 8, 154, 63, 147, 81, 187, 63, 184, 174, 79, 177, 48, 168, 184, 180, 85, 222, 126, 141, 224, 44, 221, 180, 58, 74, 237, 150, 174, 116, 111, 188, 181, 222, 170, 184, 169, 13, 194, 232, 36, 14, 253, 192, 231, 62, 13, 30, 40, 209, 47, 193, 193, 190, 255, 210, 209, 182, 150, 107, 121, 246, 113, 103, 178, 125, 193, 130, 86, 212, 70, 126, 92, 159, 212, 170, 67, 132, 76, 184, 239, 132, 212 },
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("CastItem", b =>
                {
                    b.HasOne("api_service.Model.Cast", null)
                        .WithMany()
                        .HasForeignKey("CastsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_service.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_service.Model.Item", b =>
                {
                    b.HasOne("api_service.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("api_service.Model.Rating", b =>
                {
                    b.HasOne("api_service.Model.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_service.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Item");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}