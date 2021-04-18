using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkingWithCSVFile.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    offerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monthlyFee = table.Column<double>(type: "float", nullable: false),
                    newContractsForMonth = table.Column<int>(type: "int", nullable: false),
                    sameContractsForMonth = table.Column<int>(type: "int", nullable: false),
                    CancelledContractsForMonth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.offerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");
        }
    }
}
