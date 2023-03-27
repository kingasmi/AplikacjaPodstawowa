using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacjaPodst.Migrations
{
    public partial class AddCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Warzywa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "nieznany");

            migrationBuilder.UpdateData(
                table: "Warzywa",
                keyColumn: "WarzywoId",
                keyValue: 1,
                column: "Country",
                value: "Włochy");

            migrationBuilder.UpdateData(
                table: "Warzywa",
                keyColumn: "WarzywoId",
                keyValue: 2,
                column: "Country",
                value: "Polska");

            migrationBuilder.UpdateData(
                table: "Warzywa",
                keyColumn: "WarzywoId",
                keyValue: 3,
                column: "Country",
                value: "Dania");

            migrationBuilder.UpdateData(
                table: "Warzywa",
                keyColumn: "WarzywoId",
                keyValue: 4,
                column: "Country",
                value: "Holandia");

            migrationBuilder.UpdateData(
                table: "Warzywa",
                keyColumn: "WarzywoId",
                keyValue: 5,
                column: "Country",
                value: "Szwecja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Warzywa");
        }
    }
}
