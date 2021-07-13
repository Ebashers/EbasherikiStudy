using Microsoft.EntityFrameworkCore.Migrations;

namespace EFKinopoisk.Migrations
{
    public partial class EFKinopoiskInitiate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorFilms",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilms", x => new { x.ActorId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_ActorFilms_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Biba" },
                    { 2, "Boba" },
                    { 3, "Ebanko" },
                    { 4, "KolaCation" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dva dolboyoba" },
                    { 2, "Ya ebu sobak" },
                    { 3, "Super crossover" }
                });

            migrationBuilder.InsertData(
                table: "ActorFilms",
                columns: new[] { "ActorId", "FilmId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 2, 1, 0 },
                    { 3, 2, 0 },
                    { 1, 3, 0 },
                    { 2, 3, 0 },
                    { 3, 3, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilms_FilmId",
                table: "ActorFilms",
                column: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorFilms");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
