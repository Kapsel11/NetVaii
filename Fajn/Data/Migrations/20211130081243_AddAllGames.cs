using Microsoft.EntityFrameworkCore.Migrations;

namespace Fajn.Data.Migrations
{
    public partial class AddAllGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllGames",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    White = table.Column<string>(nullable: false),
                    Black = table.Column<string>(nullable: false),
                    Result = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Event = table.Column<string>(nullable: true),
                    Pgn = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllGames", x => x.GameId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllGames");
        }
    }
}
