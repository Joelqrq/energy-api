using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyAPI.Migrations
{
    public partial class InitialEnergyGenerationSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyGeneration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Wind2 = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    WaveAndTidal = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    SolarPv = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    Hydro = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    LandfillGas = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    OtherBioEnergy = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    Total = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyGeneration", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EnergyGeneration",
                columns: new[] { "Id", "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "Wind2", "Year" },
                values: new object[] { 1, 25.3m, 2899.0m, 2716.9m, "England", 25.3m, 5990.4m, 349.2m, 2003 });

            migrationBuilder.InsertData(
                table: "EnergyGeneration",
                columns: new[] { "Id", "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 2, 30.8m, 22.5m, 0.8m, "Northern Ireland", 19.3m, 0.6m, 743.8m, 2009 });

            migrationBuilder.InsertData(
                table: "EnergyGeneration",
                columns: new[] { "Id", "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[,]
                {
                    { 3, 6.5m, 465.3m, 31.8m, "Yorkshire and the Humber", 129.6m, 3637.6m, 0.2m, 774.5m, 2013 },
                    { 4, 5757.1m, 503.4m, 26.2m, "Scotland", 173.9m, 1331.4m, 2.0m, 13833.5m, 2015 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyGeneration");
        }
    }
}
