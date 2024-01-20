using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessorInfo.Repository.Migrations
{
    public partial class photos_chipset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Chipset",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 4,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 5,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 6,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 7,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 8,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 9,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 10,
                column: "PhotoUrl",
                value: "temp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Chipset");
        }
    }
}
