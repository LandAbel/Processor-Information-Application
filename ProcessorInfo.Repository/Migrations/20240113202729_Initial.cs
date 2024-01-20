using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessorInfo.Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Chipset",
                columns: table => new
                {
                    ChipsetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chipset", x => x.ChipsetId);
                });

            migrationBuilder.CreateTable(
                name: "Processor",
                columns: table => new
                {
                    processor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PerformanceCores = table.Column<double>(type: "float", nullable: false),
                    EfficencyCores = table.Column<double>(type: "float", nullable: false),
                    TotalThreads = table.Column<int>(type: "int", nullable: false),
                    MaxTurboFrequency = table.Column<double>(type: "float", nullable: false),
                    Cache = table.Column<double>(type: "float", nullable: false),
                    IntegratedGraphics = table.Column<bool>(type: "bit", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ChipsetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processor", x => x.processor_id);
                    table.ForeignKey(
                        name: "FK_Processor_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processor_Chipset_ChipsetId",
                        column: x => x.ChipsetId,
                        principalTable: "Chipset",
                        principalColumn: "ChipsetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processor_BrandId",
                table: "Processor",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Processor_ChipsetId",
                table: "Processor",
                column: "ChipsetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processor");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Chipset");
        }
    }
}
