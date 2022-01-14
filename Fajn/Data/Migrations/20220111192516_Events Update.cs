using Microsoft.EntityFrameworkCore.Migrations;

namespace Fajn.Data.Migrations
{
    public partial class EventsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Event",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Event",
                table: "AllGames");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "AllGames",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_EventId",
                table: "Games",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_AllGames_EventId",
                table: "AllGames",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllGames_Event_EventId",
                table: "AllGames",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Event_EventId",
                table: "Games",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllGames_Event_EventId",
                table: "AllGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Event_EventId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Games_EventId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_AllGames_EventId",
                table: "AllGames");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "AllGames");

            migrationBuilder.AddColumn<string>(
                name: "Event",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Event",
                table: "AllGames",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
