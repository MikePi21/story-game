using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace story_game_exercise.Migrations
{
    public partial class InitialBooksCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Books",
               columns: table => new
               {
                   Id = table.Column<Guid>(),
                   Title = table.Column<string>(),
                   Description = table.Column<string>(),
                   AuthorId = table.Column<Guid>()
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Books", x => x.Id);
               });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Books");
        }
    }
}
