using Microsoft.EntityFrameworkCore.Migrations;

namespace Fajn.Data.Migrations
{
    public partial class AddingColumnstoEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndingDate",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartingDate",
                table: "Event",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndingDate",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "StartingDate",
                table: "Event");
        }
    }
}
