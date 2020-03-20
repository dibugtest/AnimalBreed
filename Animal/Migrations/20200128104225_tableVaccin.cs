using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal.Migrations
{
    public partial class tableVaccin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbug_vaccinationType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vaccinationName = table.Column<string>(nullable: true),
                    shortNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_vaccinationType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbug_vaccinationSubType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubTypeName = table.Column<string>(nullable: true),
                    VaccinationTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_vaccinationSubType", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbug_vaccinationSubType_dbug_vaccinationType_VaccinationTypeId",
                        column: x => x.VaccinationTypeId,
                        principalTable: "dbug_vaccinationType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbug_vaccination",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    vaccinName = table.Column<string>(nullable: true),
                    vaccinTypeId = table.Column<int>(nullable: true),
                    vaccinationSubTypeId = table.Column<int>(nullable: true),
                    vaccinForm = table.Column<string>(nullable: true),
                    manufacturedBy = table.Column<string>(nullable: true),
                    vaccinationTypeid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_vaccination", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbug_vaccination_dbug_vaccinationSubType_vaccinationSubTypeId",
                        column: x => x.vaccinationSubTypeId,
                        principalTable: "dbug_vaccinationSubType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbug_vaccination_dbug_vaccinationType_vaccinationTypeid",
                        column: x => x.vaccinationTypeid,
                        principalTable: "dbug_vaccinationType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dbug_vaccinationAnimal",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    earTagNo = table.Column<string>(nullable: true),
                    serviceProviderId = table.Column<string>(nullable: true),
                    vaccinId = table.Column<int>(nullable: false),
                    vaccinationid = table.Column<int>(nullable: true),
                    diseasesId = table.Column<int>(nullable: false),
                    vaccinationDate = table.Column<DateTime>(nullable: false),
                    dosage = table.Column<string>(nullable: true),
                    batchNo = table.Column<string>(nullable: true),
                    charge = table.Column<string>(nullable: true),
                    receiptNo = table.Column<string>(nullable: true),
                    animalId = table.Column<int>(nullable: false),
                    animalRegistrationid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_vaccinationAnimal", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbug_vaccinationAnimal_dbug_animal_animalRegistrationid",
                        column: x => x.animalRegistrationid,
                        principalTable: "dbug_animal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dbug_vaccinationAnimal_dbug_diseases_diseasesId",
                        column: x => x.diseasesId,
                        principalTable: "dbug_diseases",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbug_vaccinationAnimal_dbug_vaccination_vaccinationid",
                        column: x => x.vaccinationid,
                        principalTable: "dbug_vaccination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbug_vaccination_vaccinationSubTypeId",
                table: "dbug_vaccination",
                column: "vaccinationSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_dbug_vaccination_vaccinationTypeid",
                table: "dbug_vaccination",
                column: "vaccinationTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_dbug_vaccinationAnimal_animalRegistrationid",
                table: "dbug_vaccinationAnimal",
                column: "animalRegistrationid");

            migrationBuilder.CreateIndex(
                name: "IX_dbug_vaccinationAnimal_diseasesId",
                table: "dbug_vaccinationAnimal",
                column: "diseasesId");

            migrationBuilder.CreateIndex(
                name: "IX_dbug_vaccinationAnimal_vaccinationid",
                table: "dbug_vaccinationAnimal",
                column: "vaccinationid");

            migrationBuilder.CreateIndex(
                name: "IX_dbug_vaccinationSubType_VaccinationTypeId",
                table: "dbug_vaccinationSubType",
                column: "VaccinationTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbug_vaccinationAnimal");

            migrationBuilder.DropTable(
                name: "dbug_vaccination");

            migrationBuilder.DropTable(
                name: "dbug_vaccinationSubType");

            migrationBuilder.DropTable(
                name: "dbug_vaccinationType");
        }
    }
}
