using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacjaPodst.Migrations
{
    public partial class Instal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warzywa",
                columns: table => new
                {
                    WarzywoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warzywa", x => x.WarzywoId);
                });

            migrationBuilder.InsertData(
                table: "Warzywa",
                columns: new[] { "WarzywoId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "pomidor", 8.5m, 30 },
                    { 2, "ziemniaki", 2.3m, 85 },
                    { 3, "ogórek", 6m, 10 },
                    { 4, "kalafior", 5.99m, 40 },
                    { 5, "cukinia", 4.6m, 16 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warzywa");
        }
    }
}
