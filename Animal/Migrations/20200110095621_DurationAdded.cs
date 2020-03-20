using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal.Migrations
{
    public partial class DurationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationForWt",
                table: "dbug_goat",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationForWt",
                table: "dbug_goat");
        }
    }
}
