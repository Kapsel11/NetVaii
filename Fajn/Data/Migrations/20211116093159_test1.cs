using Microsoft.EntityFrameworkCore.Migrations;

namespace Fajn.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Joke",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Joke");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Joke",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Black",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Event",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "White",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Joke",
                table: "Joke",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Joke",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Black",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Event",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "White",
                table: "Joke");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Joke",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Joke",
                table: "Joke",
                column: "Id");
        }
    }
}
