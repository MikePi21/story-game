using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace story_game_exercise.Migrations
{
    public partial class InitialStoriesCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    ChapterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                      name: "FK_Stories_Chapters",
                      column: x => x.ChapterId,
                      principalTable: "Chapters",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Cascade);

                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
