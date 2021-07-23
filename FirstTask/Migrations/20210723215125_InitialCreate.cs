using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstTask.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloggerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Videos_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "id", "BloggerName" },
                values: new object[] { 1, "Eles" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "id", "BlogId", "Dislikes", "Likes", "Url", "VideoName", "Views" },
                values: new object[] { 1, 1, 5672, 30764, "https://www.youtube.com/watch?v=jgELCkPJ4LQ", "Warface: НАЧАТЬ С НУЛЯ?", 1791927 });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "id", "BlogId", "Dislikes", "Likes", "Url", "VideoName", "Views" },
                values: new object[] { 2, 1, 5020, 19809, "https://www.youtube.com/watch?v=6vshj3lPUx0", "Intro для канала Элез", 4516796 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "CommentText", "Dislikes", "Likes", "VideoId" },
                values: new object[,]
                {
                    { 1, "' Всем привет, с вами Элез '  Мне больше нравился ^_^ ", 15, 159, 1 },
                    { 2, "6 лет назад... и тут рекомендация", 1, 10, 1 },
                    { 3, "Мне кажется,Элез бы отлично сыграл Джокера. Пугающе. Именно.", 28, 228000000, 2 },
                    { 4, "у меня мурашки по коже когда он разговаривает", 0, 8, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_VideoId",
                table: "Comments",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_BlogId",
                table: "Videos",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
