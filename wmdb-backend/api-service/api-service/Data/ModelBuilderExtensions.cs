using api_service.Helper;
using api_service.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;

namespace api_service.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] passwordHash, passwordSalt;

            PasswordHash.Create("test", out passwordHash, out passwordSalt);

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Username = "admin", PasswordHash = passwordHash, PasswordSalt = passwordSalt }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Movie", Tag = "movies" },
                new Category { Id = 2, Name = "TV Shows", Tag = "shows" }
                );

            modelBuilder.Entity<Cast>().HasData(
                new Cast { Id = 1, FullName = "Keanu Reeves" },
                new Cast { Id = 2, FullName = "Leo DiCaprio" },
                new Cast { Id = 3, FullName = "Liam Neeson" },
                new Cast { Id = 4, FullName = "Bruno Ganz" },
                new Cast { Id = 5, FullName = "Diane Kruger" },
                new Cast { Id = 6, FullName = "Rainer Bock" }
                );

            modelBuilder.Entity<Item>().HasData(
                       new Item
                       {
                           Id = 1,
                           Title = "The Matrix",
                           Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld," +
                       " he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",
                           ReleaseDate = new DateTime(1999, 3, 24),
                           Thumbnail = "https://flxt.tmsimg.com/assets/p22804_p_v10_ab.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 2,
                           Title = "A Prophet",
                           Description = "A young Algerian man is sent to a French prison.",
                           ReleaseDate = new DateTime(2009, 5, 16),
                           Thumbnail = "https://upload.wikimedia.org/wikipedia/en/d/d1/A_Prophet.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 3,
                           Title = "The Godfather",
                           Description = "An organized crime dynasty's aging patriarch transfers control" +
                       " of his clandestine empire to his reluctant son.",
                           ReleaseDate = new DateTime(1972, 3, 14),
                           Thumbnail = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY1200_CR107,0,630,1200_AL_.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 4,
                           Title = "300",
                           Description = "King Leonidas of Sparta and a force of" +
                       " 300 men fight the Persians at Thermopylae in 480 B.C.",
                           ReleaseDate = new DateTime(2006, 12, 9),
                           Thumbnail = "https://flxt.tmsimg.com/assets/p163191_p_v10_an.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 5,
                           Title = "Casino Royale",
                           Description = "After earning 00 status and a licence to kill, Secret Agent " +
                       "James Bond sets out on his first mission as 007. " +
                       "Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.",
                           ReleaseDate = new DateTime(2006, 11, 14),
                           Thumbnail = "https://m.media-amazon.com/images/M/MV5BMDI5ZWJhOWItYTlhOC00YWNhLTlkNzctNDU5YTI1M2E1MWZhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_.jpg",
                           CategoryId = 1
                       },

                      new Item
                      {
                          Id = 6,
                          Title = "Deadpool 2",
                          Description = "After losing Vanessa (Morena Baccarin), the love of his life," +
                      " 4th-wall breaking mercenary Wade Wilson aka Deadpool (Ryan Reynolds) must assemble a team and protect a young, full-figured mutant" +
                      " Russell Collins aka Firefist (Julian Dennison) from Cable (Josh Brolin), a no-nonsense, dangerous cyborg from the future, and must " +
                      "also learn the most important lesson of all: to be part of a family again.",
                          ReleaseDate = new DateTime(2018, 7, 2),
                          Thumbnail = "https://img.yts.mx/assets/images/movies/deadpool_2_2018/medium-cover.jpg",
                          CategoryId = 1
                      },

                       new Item
                       {
                           Id = 7,
                           Title = "Mortal Kombat",
                           Description = "Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor " +
                         "Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against" +
                         " the enemies of Outworld in a high stakes battle for the universe.",
                           ReleaseDate = new DateTime(2021, 8, 9),
                           Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/2xmx8oPlbDaxTjHsIOZvOt5L3aJ.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 8,
                           Title = "Cherry",
                           Description = "",
                           ReleaseDate = new DateTime(2021, 2, 26),
                           Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/pwDvkDyaHEU9V7cApQhbcSJMG1w.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 9,
                           Title = "Raya and the Last Dragon",
                           Description = "Raya and the Last Dragon",
                           ReleaseDate = new DateTime(2021, 1, 1),
                           Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg",
                           CategoryId = 1
                       },

                       new Item
                       {
                           Id = 10,
                           Title = "The Marksman",
                           Description = "",
                           ReleaseDate = new DateTime(2021, 2, 26),
                           Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6vcDalR50RWa309vBH1NLmG2rjQ.jpg",
                           CategoryId = 1
                       },
                       new Item
                       {
                           Id = 11,
                           Title = "Twist",
                           Description = "",
                           ReleaseDate = new DateTime(2021, 2, 26),
                           Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/29dCusd9PwHrbDqzxNG35WcpZpS.jpg",
                           CategoryId = 1
                       },
                       new Item
                       {
                           Id = 14,
                           Title = "Avatar: The Way of Water",
                           Description = "",
                           ReleaseDate = new DateTime(2022, 12, 16),
                           Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/t6HIqrRAclMCA60NsSmeqe9RmNV.jpg",
                           CategoryId = 1
                       },
                      new Item
                      {
                          Id = 12,
                          Title = "The Walking Dead",
                          Description = "Sheriff Deputy Rick Grimes wakes up from a coma to learn " +
                      "the world is in ruins and must lead a group of survivors to stay alive.",
                          ReleaseDate = new DateTime(2010, 10, 31),
                          Thumbnail = "https://m.media-amazon.com/images/M/MV5BMTc5ZmM0OTQtNDY4MS00ZjMyLTgwYzgtOGY0Y2VlMWFmNDU0XkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg",
                          CategoryId = 2
                      },

                      new Item
                      {
                          Id = 13,
                          Title = "Narcos",
                          Description = "A gritty chronicle of the war against Colombia's infamously violent and powerful drug cartels.",
                          ReleaseDate = new DateTime(2015, 10, 31),
                          Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rTmal9fDbwh5F0waol2hq35U4ah.jpg",
                          CategoryId = 2
                      },
                      new Item
                      {
                          Id = 15,
                          Title = "The Last of Us",
                          Description = "Twenty years after modern civilization has been destroyed, Joel, a hardened survivor, is hired to smuggle Ellie, a 14-year-old girl, out of an oppressive quarantine zone. What starts as a small job soon becomes a brutal, heartbreaking journey, as they both must traverse the United States and depend on each other for survival.",
                          ReleaseDate = new DateTime(2022, 10, 31),
                          Thumbnail = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/uKvVjHNqB5VmOrdxqAt2F7J78ED.jpg",
                          CategoryId = 2
                      }
                      );

            modelBuilder.Entity("CastItem").HasData(
                new { CastsId = 1, ItemsId = 1 },
                new { CastsId = 2, ItemsId = 1 },
                new { CastsId = 3, ItemsId = 2 },
                new { CastsId = 1, ItemsId = 2 },
                new { CastsId = 4, ItemsId = 3 },
                new { CastsId = 5, ItemsId = 3 },
                new { CastsId = 6, ItemsId = 4 },
                new { CastsId = 5, ItemsId = 4 },
                new { CastsId = 6, ItemsId = 5 },
                new { CastsId = 2, ItemsId = 5 },
                new { CastsId = 1, ItemsId = 6 },
                new { CastsId = 3, ItemsId = 6 },
                new { CastsId = 4, ItemsId = 7 },
                new { CastsId = 3, ItemsId = 7 },
                new { CastsId = 5, ItemsId = 8 },
                new { CastsId = 6, ItemsId = 8 }
            );
        }
    }
}
