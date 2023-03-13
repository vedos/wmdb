using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_service.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastItem",
                columns: table => new
                {
                    CastsId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastItem", x => new { x.CastsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_CastItem_Casts_CastsId",
                        column: x => x.CastsId,
                        principalTable: "Casts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastItem_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "BirthDate", "FullName" },
                values: new object[,]
                {
                    { 1, null, "Keanu Reeves" },
                    { 2, null, "Leo DiCaprio" },
                    { 3, null, "Liam Neeson" },
                    { 4, null, "Bruno Ganz" },
                    { 5, null, "Diane Kruger" },
                    { 6, null, "Rainer Bock" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Tag" },
                values: new object[,]
                {
                    { 1, "Movie", "movies" },
                    { 2, "TV Shows", "shows" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, new byte[] { 45, 131, 171, 130, 198, 157, 191, 192, 136, 217, 5, 45, 197, 79, 205, 56, 165, 209, 188, 217, 71, 73, 18, 189, 219, 179, 48, 193, 1, 133, 136, 219, 60, 176, 55, 199, 115, 234, 91, 0, 18, 98, 136, 123, 158, 158, 138, 104, 5, 247, 237, 7, 245, 120, 116, 189, 181, 19, 201, 99, 22, 79, 34, 48 }, new byte[] { 249, 100, 222, 207, 35, 186, 165, 11, 70, 150, 111, 6, 229, 19, 174, 127, 164, 190, 104, 26, 55, 250, 43, 123, 197, 189, 71, 184, 239, 115, 168, 191, 28, 223, 253, 144, 184, 225, 60, 85, 143, 208, 189, 238, 79, 112, 8, 154, 63, 147, 81, 187, 63, 184, 174, 79, 177, 48, 168, 184, 180, 85, 222, 126, 141, 224, 44, 221, 180, 58, 74, 237, 150, 174, 116, 111, 188, 181, 222, 170, 184, 169, 13, 194, 232, 36, 14, 253, 192, 231, 62, 13, 30, 40, 209, 47, 193, 193, 190, 255, 210, 209, 182, 150, 107, 121, 246, 113, 103, 178, 125, 193, 130, 86, 212, 70, 126, 92, 159, 212, 170, 67, 132, 76, 184, 239, 132, 212 }, "admin" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Description", "ReleaseDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, 1, "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", new DateTime(1999, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://flxt.tmsimg.com/assets/p22804_p_v10_ab.jpg", "The Matrix" },
                    { 2, 1, "A young Algerian man is sent to a French prison.", new DateTime(2009, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/d/d1/A_Prophet.jpg", "A Prophet" },
                    { 3, 1, "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", new DateTime(1972, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY1200_CR107,0,630,1200_AL_.jpg", "The Godfather" },
                    { 4, 1, "King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.", new DateTime(2006, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://flxt.tmsimg.com/assets/p163191_p_v10_an.jpg", "300" },
                    { 5, 1, "After earning 00 status and a licence to kill, Secret Agent James Bond sets out on his first mission as 007. Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.", new DateTime(2006, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/M/MV5BMDI5ZWJhOWItYTlhOC00YWNhLTlkNzctNDU5YTI1M2E1MWZhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_.jpg", "Casino Royale" },
                    { 6, 1, "After losing Vanessa (Morena Baccarin), the love of his life, 4th-wall breaking mercenary Wade Wilson aka Deadpool (Ryan Reynolds) must assemble a team and protect a young, full-figured mutant Russell Collins aka Firefist (Julian Dennison) from Cable (Josh Brolin), a no-nonsense, dangerous cyborg from the future, and must also learn the most important lesson of all: to be part of a family again.", new DateTime(2018, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img.yts.mx/assets/images/movies/deadpool_2_2018/medium-cover.jpg", "Deadpool 2" },
                    { 7, 1, "Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against the enemies of Outworld in a high stakes battle for the universe.", new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/2xmx8oPlbDaxTjHsIOZvOt5L3aJ.jpg", "Mortal Kombat" },
                    { 8, 1, "", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/pwDvkDyaHEU9V7cApQhbcSJMG1w.jpg", "Cherry" },
                    { 9, 1, "Raya and the Last Dragon", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg", "Raya and the Last Dragon" },
                    { 10, 1, "", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6vcDalR50RWa309vBH1NLmG2rjQ.jpg", "The Marksman" },
                    { 11, 1, "", new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/29dCusd9PwHrbDqzxNG35WcpZpS.jpg", "Twist" },
                    { 14, 1, "", new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/t6HIqrRAclMCA60NsSmeqe9RmNV.jpg", "Avatar: The Way of Water" },
                    { 12, 2, "Sheriff Deputy Rick Grimes wakes up from a coma to learn the world is in ruins and must lead a group of survivors to stay alive.", new DateTime(2010, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/M/MV5BMTc5ZmM0OTQtNDY4MS00ZjMyLTgwYzgtOGY0Y2VlMWFmNDU0XkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg", "The Walking Dead" },
                    { 13, 2, "A gritty chronicle of the war against Colombia's infamously violent and powerful drug cartels.", new DateTime(2015, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rTmal9fDbwh5F0waol2hq35U4ah.jpg", "Narcos" },
                    { 15, 2, "Twenty years after modern civilization has been destroyed, Joel, a hardened survivor, is hired to smuggle Ellie, a 14-year-old girl, out of an oppressive quarantine zone. What starts as a small job soon becomes a brutal, heartbreaking journey, as they both must traverse the United States and depend on each other for survival.", new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/uKvVjHNqB5VmOrdxqAt2F7J78ED.jpg", "The Last of Us" }
                });

            migrationBuilder.InsertData(
                table: "CastItem",
                columns: new[] { "CastsId", "ItemsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 1, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 4 },
                    { 5, 4 },
                    { 6, 5 },
                    { 2, 5 },
                    { 1, 6 },
                    { 3, 6 },
                    { 4, 7 },
                    { 3, 7 },
                    { 5, 8 },
                    { 6, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CastItem_ItemsId",
                table: "CastItem",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ItemId",
                table: "Ratings",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastItem");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
