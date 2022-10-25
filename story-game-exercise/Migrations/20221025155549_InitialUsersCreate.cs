using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace story_game_exercise.Migrations
{
    public partial class InitialUsersCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Users",
               columns: table => new
               {
                   Id = table.Column<Guid>(),
                   Nickname = table.Column<string>(),
                   Password = table.Column<Guid>()
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Users", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Users");
        }
    }
}
