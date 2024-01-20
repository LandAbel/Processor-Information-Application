using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessorInfo.Repository.Migrations
{
    public partial class complex_with_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, "INTEL", "temp" },
                    { 2, "AMD", "temp" },
                    { 3, "QUALCOMM", "temp" }
                });

            migrationBuilder.InsertData(
                table: "Chipset",
                columns: new[] { "ChipsetId", "Name" },
                values: new object[,]
                {
                    { 1, "Z790" },
                    { 2, "Z690" },
                    { 3, "Z590" },
                    { 4, "Z490" },
                    { 5, "Z390" },
                    { 6, "Z270" },
                    { 7, "Z170" },
                    { 8, "AM4" },
                    { 9, "AM5" },
                    { 10, "Mobile" }
                });

            migrationBuilder.InsertData(
                table: "Processor",
                columns: new[] { "processor_id", "BrandId", "Cache", "ChipsetId", "EfficencyCores", "IntegratedGraphics", "MaxTurboFrequency", "Name", "PerformanceCores", "PhotoUrl", "TotalThreads" },
                values: new object[,]
                {
                    { 1, 1, 36.0, 1, 16.0, true, 5.7999999999999998, "Intel Core i9-13900K", 8.0, "temp", 32 },
                    { 2, 1, 30.0, 2, 8.0, true, 5.5, "Intel Core i9-12900KS", 8.0, "temp", 24 },
                    { 3, 1, 16.0, 3, 0.0, true, 5.2000000000000002, "Intel Core i9-11900K", 8.0, "temp", 16 },
                    { 4, 1, 20.0, 4, 0.0, true, 5.2999999999999998, "Intel Core i9-10900K", 10.0, "temp", 20 },
                    { 5, 1, 16.0, 5, 0.0, true, 5.0, "Intel Core i9-9900K", 8.0, "temp", 16 },
                    { 6, 1, 12.0, 5, 0.0, true, 4.7999999999999998, "Intel Core i9-8950HK", 6.0, "temp", 12 },
                    { 7, 1, 30.0, 1, 8.0, true, 5.4000000000000004, "Intel Core i9-13700K", 8.0, "temp", 24 },
                    { 8, 1, 25.0, 2, 4.0, true, 5.0, "Intel Core i9-12700K", 8.0, "temp", 20 },
                    { 9, 1, 16.0, 3, 0.0, true, 5.0, "Intel Core i9-11700K", 8.0, "temp", 16 },
                    { 10, 1, 16.0, 4, 0.0, true, 5.0999999999999996, "Intel Core i9-10700K", 8.0, "temp", 16 },
                    { 11, 1, 12.0, 6, 0.0, true, 4.9000000000000004, "Intel Core i7-9700K", 8.0, "temp", 8 },
                    { 12, 1, 12.0, 6, 0.0, true, 4.7000000000000002, "Intel Core i7-8700K", 6.0, "temp", 12 },
                    { 13, 1, 30.0, 1, 8.0, false, 5.4000000000000004, "Intel Core i9-13700KF", 8.0, "temp", 24 },
                    { 14, 1, 25.0, 2, 4.0, false, 5.0, "Intel Core i9-12700KF", 8.0, "temp", 20 },
                    { 15, 2, 72.0, 8, 0.0, false, 4.9000000000000004, "AMD Ryzen 9 5950X", 16.0, "temp", 32 },
                    { 16, 2, 81.0, 9, 0.0, false, 5.7000000000000002, "AMD Ryzen 9 7950X", 16.0, "temp", 32 },
                    { 17, 2, 60.0, 8, 0.0, false, 4.7000000000000002, "AMD Ryzen 7 5750X", 10.0, "temp", 20 },
                    { 18, 3, 6.7999999999999998, 10, 0.0, true, 2.8399999999999999, "Snapdragon 865 5G", 8.0, "temp", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 10);
        }
    }
}
