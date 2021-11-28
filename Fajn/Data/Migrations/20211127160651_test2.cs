using Microsoft.EntityFrameworkCore.Migrations;

namespace Fajn.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Joke",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Joke_userId",
                table: "Joke",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Joke_AspNetUsers_userId",
                table: "Joke",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_AspNetUsers_userId",
                table: "Joke");

            migrationBuilder.DropIndex(
                name: "IX_Joke_userId",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Joke");
        }
    }
}
