using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal.Migrations
{
    public partial class Goat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbug_goatBreed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BreedName = table.Column<string>(nullable: false),
                    ShortDetails = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_goatBreed", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "LrpVM",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        fullName = table.Column<string>(nullable: false),
            //        email = table.Column<string>(nullable: false),
            //        address = table.Column<string>(nullable: true),
            //        provience = table.Column<string>(nullable: true),
            //        munipalicity = table.Column<string>(nullable: true),
            //        area = table.Column<string>(nullable: true),
            //        password = table.Column<string>(maxLength: 255, nullable: false),
            //        confirmPassword = table.Column<string>(maxLength: 255, nullable: false),
            //        userName = table.Column<string>(nullable: false),
            //        phoneNo = table.Column<string>(nullable: true),
            //        role = table.Column<string>(nullable: true),
            //        permission = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LrpVM", x => x.id);
            //    });

            migrationBuilder.CreateTable(
                name: "dbug_goat",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    earTagNo = table.Column<string>(nullable: true),
                    GoatBreedId = table.Column<int>(nullable: true),
                    OriginOf = table.Column<string>(nullable: true),
                    Weather = table.Column<string>(nullable: true),
                    MainPurpose = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    FeedingNature = table.Column<string>(nullable: true),
                    FirstPregnancyTime = table.Column<decimal>(nullable: false),
                    WeightOnBirth = table.Column<decimal>(nullable: false),
                    GrowthRateWt = table.Column<decimal>(nullable: false),
                    PregnancyDuration = table.Column<decimal>(nullable: false),
                    AverageWtFemale = table.Column<decimal>(nullable: false),
                    AverageWtMale = table.Column<decimal>(nullable: false),
                    Siration = table.Column<decimal>(nullable: false),
                    NoOfBaby = table.Column<int>(nullable: false),
                    PurchasePerKg = table.Column<decimal>(nullable: false),
                    PricePerKg = table.Column<decimal>(nullable: false),
                    PricePerKgDam = table.Column<decimal>(nullable: false),
                    MarketPlace = table.Column<string>(nullable: true),
                    FeedingExpense = table.Column<decimal>(nullable: false),
                    MscExpense = table.Column<decimal>(nullable: false),
                    PasminaProduction = table.Column<decimal>(nullable: false),
                    PasminaPrice = table.Column<decimal>(nullable: false),
                    FertilizerWt = table.Column<decimal>(nullable: false),
                    FertilizerPrice = table.Column<decimal>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbug_goat", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbug_goat_dbug_goatBreed_GoatBreedId",
                        column: x => x.GoatBreedId,
                        principalTable: "dbug_goatBreed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbug_goat_GoatBreedId",
                table: "dbug_goat",
                column: "GoatBreedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbug_goat");

            //migrationBuilder.DropTable(
            //    name: "LrpVM");

            migrationBuilder.DropTable(
                name: "dbug_goatBreed");
        }
    }
}
