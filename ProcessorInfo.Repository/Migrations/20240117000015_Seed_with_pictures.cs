using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessorInfo.Repository.Migrations
{
    public partial class Seed_with_pictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Processor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Chipset",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/intel-new-logo-16x9.jpg.rendition.intel.web.1648.927.jpg");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/AMD_Logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/mobile.jpg");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/z790-chipset-blockdiagram-4.png");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/z690.jpg");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/z590.jpg");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 4,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/Intel-Z490-Chipset-Diagram.jpg");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 5,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/z390.png");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 8,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/amd-b550-chipset-block-diagram.png");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 9,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/c11947df-28fa-44df-9c0f-55142218f797_6083x2097.jpg");

            migrationBuilder.UpdateData(
                table: "Chipset",
                keyColumn: "ChipsetId",
                keyValue: 10,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/mobile.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/13900k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/12900ks.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/11900k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 4,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/10900k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 5,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/9900k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 6,
                columns: new[] { "Cache", "ChipsetId", "EfficencyCores", "MaxTurboFrequency", "Name", "PerformanceCores", "PhotoUrl", "TotalThreads" },
                values: new object[] { 30.0, 1, 8.0, 5.4000000000000004, "Intel Core i9-13700K", 8.0, "https://processorinfostorageacc.blob.core.windows.net/processorinfo/13700kf.jpg", 24 });

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 8,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/12700k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 9,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/11700k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 10,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/10700k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 11,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/9700k.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 13,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/13700kf.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 15,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/743796831.amd-ryzen-9-5950x-16-core-3-4ghz-am4-box-without-fan-and-heatsink.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 16,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/7950X.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 17,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/5750X.jpg");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 18,
                column: "PhotoUrl",
                value: "https://processorinfostorageacc.blob.core.windows.net/processorinfo/snapdragon.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Processor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Chipset",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoUrl",
                table: "Brands",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "PhotoUrl",
                value: "temp");

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

            migrationBuilder.InsertData(
                table: "Chipset",
                columns: new[] { "ChipsetId", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { 6, "Z270", "temp" },
                    { 7, "Z170", "temp" }
                });

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 4,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 5,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 6,
                columns: new[] { "Cache", "ChipsetId", "EfficencyCores", "MaxTurboFrequency", "Name", "PerformanceCores", "PhotoUrl", "TotalThreads" },
                values: new object[] { 12.0, 5, 0.0, 4.7999999999999998, "Intel Core i9-8950HK", 6.0, "temp", 12 });

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 8,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 9,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 10,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 11,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 13,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 15,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 16,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 17,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.UpdateData(
                table: "Processor",
                keyColumn: "processor_id",
                keyValue: 18,
                column: "PhotoUrl",
                value: "temp");

            migrationBuilder.InsertData(
                table: "Processor",
                columns: new[] { "processor_id", "BrandId", "Cache", "ChipsetId", "EfficencyCores", "IntegratedGraphics", "MaxTurboFrequency", "Name", "PerformanceCores", "PhotoUrl", "TotalThreads" },
                values: new object[,]
                {
                    { 7, 1, 30.0, 1, 8.0, true, 5.4000000000000004, "Intel Core i9-13700K", 8.0, "temp", 24 },
                    { 14, 1, 25.0, 2, 4.0, false, 5.0, "Intel Core i9-12700KF", 8.0, "temp", 20 }
                });

            migrationBuilder.InsertData(
                table: "Processor",
                columns: new[] { "processor_id", "BrandId", "Cache", "ChipsetId", "EfficencyCores", "IntegratedGraphics", "MaxTurboFrequency", "Name", "PerformanceCores", "PhotoUrl", "TotalThreads" },
                values: new object[] { 12, 1, 12.0, 6, 0.0, true, 4.7000000000000002, "Intel Core i7-8700K", 6.0, "temp", 12 });
        }
    }
}
