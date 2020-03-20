using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal.Migrations
{
    public partial class AiModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bullId",
                table: "dbug_ai",
                newName: "BullId");

            migrationBuilder.RenameColumn(
                name: "inSemnatorId",
                table: "dbug_ai",
                newName: "inSemnator");

            migrationBuilder.RenameColumn(
                name: "earTagId",
                table: "dbug_ai",
                newName: "earTagNo");

            migrationBuilder.AlterColumn<int>(
                name: "BullId",
                table: "dbug_ai",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "dbug_ai",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BullEarTag",
                table: "dbug_ai",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_dbug_ai_AnimalId",
                table: "dbug_ai",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_dbug_ai_BullId",
                table: "dbug_ai",
                column: "BullId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbug_ai_dbug_animal_AnimalId",
                table: "dbug_ai",
                column: "AnimalId",
                principalTable: "dbug_animal",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_dbug_ai_dbug_animal_BullId",
                table: "dbug_ai",
                column: "BullId",
                principalTable: "dbug_animal",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbug_ai_dbug_animal_AnimalId",
                table: "dbug_ai");

            migrationBuilder.DropForeignKey(
                name: "FK_dbug_ai_dbug_animal_BullId",
                table: "dbug_ai");

            migrationBuilder.DropIndex(
                name: "IX_dbug_ai_AnimalId",
                table: "dbug_ai");

            migrationBuilder.DropIndex(
                name: "IX_dbug_ai_BullId",
                table: "dbug_ai");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "dbug_ai");

            migrationBuilder.DropColumn(
                name: "BullEarTag",
                table: "dbug_ai");

            migrationBuilder.RenameColumn(
                name: "BullId",
                table: "dbug_ai",
                newName: "bullId");

            migrationBuilder.RenameColumn(
                name: "inSemnator",
                table: "dbug_ai",
                newName: "inSemnatorId");

            migrationBuilder.RenameColumn(
                name: "earTagNo",
                table: "dbug_ai",
                newName: "earTagId");

            migrationBuilder.AlterColumn<string>(
                name: "bullId",
                table: "dbug_ai",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
