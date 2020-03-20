using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal.Migrations
{
    public partial class lrp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lrpid",
                table: "dbug_farm",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "dbug_lrpUser",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    provience = table.Column<string>(nullable: true),
                    munipalicity = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_lrpUser", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbug_farm_Lrpid",
                table: "dbug_farm",
                column: "Lrpid");

            migrationBuilder.AddForeignKey(
                name: "FK_dbug_farm_dbug_lrpUser_Lrpid",
                table: "dbug_farm",
                column: "Lrpid",
                principalTable: "dbug_lrpUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbug_farm_dbug_lrpUser_Lrpid",
                table: "dbug_farm");

            migrationBuilder.DropTable(
                name: "dbug_lrpUser");

            migrationBuilder.DropIndex(
                name: "IX_dbug_farm_Lrpid",
                table: "dbug_farm");

            migrationBuilder.DropColumn(
                name: "Lrpid",
                table: "dbug_farm");
        }
    }
}
