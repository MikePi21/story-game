using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace story_game_exercise.Migrations
{
    public partial class InitialChaptersCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Chapters",
              columns: table => new
              {
                  Id = table.Column<Guid>(),
                  Title = table.Column<string>(),
                  Description = table.Column<string>(),
                  BookId = table.Column<Guid>()
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Chapters", x => x.Id);
                  table.ForeignKey(
                      name: "FK_Chapters_Books",
                      column: x => x.BookId,
                      principalTable: "Books",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Cascade);
              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Chapters");
        }
    }
}
