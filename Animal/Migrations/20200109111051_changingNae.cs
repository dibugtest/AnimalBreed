using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal.Migrations
{
    public partial class changingNae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Siration",
                table: "dbug_goat",
                nullable: true,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Siration",
                table: "dbug_goat",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
