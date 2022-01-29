using Microsoft.EntityFrameworkCore.Migrations;

namespace Fajn.Data.Migrations
{
    public partial class addingtableEventType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameTypeId",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GameType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Rules = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameTypeId",
                table: "Games",
                column: "GameTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameType_GameTypeId",
                table: "Games",
                column: "GameTypeId",
                principalTable: "GameType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameType_GameTypeId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "GameType");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameTypeId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameTypeId",
                table: "Games");
        }
    }
}
