using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyAPI.Migrations
{
    public partial class InitialEnergyRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ENERGY_DATASET");

            migrationBuilder.CreateTable(
                name: "EnergyRecord",
                schema: "ENERGY_DATASET",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false, defaultValue: 0.0m),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Wind2 = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    WaveAndTidal = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    SolarPv = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    Hydro = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    LandfillGas = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    OtherBioEnergy = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    Total = table.Column<decimal>(type: "decimal(14,1)", precision: 14, scale: 1, nullable: false, defaultValue: 0.0m),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyRecord", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "ENERGY_DATASET",
                table: "EnergyRecord",
                columns: new[] { "Id", "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[,]
                {
                    { 1, 384.8m, "https://localhost:5001/images/energy.jpeg", 1390.7m, 38.7m, 143.99m, "Yorkshire and the Humber", 1210.4m, 1837.0m, 106.2m, 427.6m, 2005 },
                    { 28, 56.9m, "https://localhost:5001/images/energy.jpeg", 524.1m, 1652.5m, 199.71m, "England", 404.1m, 1803.8m, 794.6m, 722.6m, 2006 },
                    { 29, 1954.8m, "https://localhost:5001/images/energy.jpeg", 1170.5m, 1937.3m, 102.28m, "England", 242.0m, 1578.0m, 674.7m, 1513.3m, 2003 },
                    { 30, 286.8m, "https://localhost:5001/images/energy.jpeg", 1172.2m, 950.6m, 113.57m, "Scotland", 753.9m, 1872.9m, 1929.8m, 1544.6m, 2005 },
                    { 31, 429.7m, "https://localhost:5001/images/energy.jpeg", 694.8m, 530.0m, 65.36m, "England", 281.6m, 985.5m, 146.9m, 742.8m, 2003 },
                    { 32, 1404.3m, "https://localhost:5001/images/energy.jpeg", 1116.9m, 1155.2m, 63.96m, "England", 366.0m, 1891.8m, 441.2m, 585.5m, 2005 },
                    { 33, 1768.5m, "https://localhost:5001/images/energy.jpeg", 455.7m, 792.8m, 197.27m, "Northern Ireland", 961.9m, 40.6m, 1637.8m, 486.4m, 2005 },
                    { 34, 1812.4m, "https://localhost:5001/images/energy.jpeg", 1697.2m, 1366.3m, 11.73m, "Scotland", 649.5m, 393.0m, 1150.1m, 1779.5m, 2004 },
                    { 35, 750.8m, "https://localhost:5001/images/energy.jpeg", 1401.4m, 1103.4m, 181.23m, "Northern Ireland", 89.0m, 1563.7m, 938.3m, 951.7m, 2005 },
                    { 36, 1797.8m, "https://localhost:5001/images/energy.jpeg", 1710.9m, 1104.9m, 134.96m, "England", 1527.0m, 1185.0m, 1900.2m, 1058.7m, 2005 },
                    { 37, 1473.1m, "https://localhost:5001/images/energy.jpeg", 504.8m, 1435.3m, 51.31m, "Scotland", 1754.9m, 1791.7m, 868.2m, 489.3m, 2006 },
                    { 38, 486.1m, "https://localhost:5001/images/energy.jpeg", 1623.7m, 1548.0m, 55.36m, "Scotland", 712.8m, 1548.7m, 79.5m, 762.2m, 2006 },
                    { 39, 867.7m, "https://localhost:5001/images/energy.jpeg", 514.7m, 1879.2m, 21.10m, "Yorkshire and the Humber", 947.5m, 1623.1m, 691.0m, 1229.0m, 2003 },
                    { 40, 1357.8m, "https://localhost:5001/images/energy.jpeg", 151.1m, 83.5m, 85.17m, "Northern Ireland", 1838.3m, 1183.4m, 1879.9m, 181.3m, 2003 },
                    { 41, 1419.2m, "https://localhost:5001/images/energy.jpeg", 1254.7m, 979.2m, 61.59m, "Scotland", 1642.5m, 1187.4m, 1010.1m, 1311.6m, 2003 },
                    { 42, 621.5m, "https://localhost:5001/images/energy.jpeg", 673.0m, 1798.2m, 104.09m, "England", 146.1m, 1920.6m, 974.0m, 1556.2m, 2003 },
                    { 43, 1114.7m, "https://localhost:5001/images/energy.jpeg", 1569.2m, 882.3m, 88.72m, "Northern Ireland", 452.1m, 241.1m, 939.9m, 1812.1m, 2004 },
                    { 44, 400.9m, "https://localhost:5001/images/energy.jpeg", 40.6m, 218.9m, 135.49m, "Scotland", 1965.0m, 1048.4m, 932.8m, 364.6m, 2003 },
                    { 45, 1938.5m, "https://localhost:5001/images/energy.jpeg", 1036.0m, 1207.2m, 152.82m, "Scotland", 677.6m, 1733.8m, 582.2m, 691.8m, 2006 },
                    { 46, 1620.4m, "https://localhost:5001/images/energy.jpeg", 153.9m, 371.7m, 121.68m, "England", 1657.5m, 557.9m, 296.1m, 162.8m, 2004 },
                    { 47, 633.9m, "https://localhost:5001/images/energy.jpeg", 1798.2m, 623.3m, 52.78m, "England", 705.9m, 1008.9m, 1832.4m, 738.0m, 2006 },
                    { 48, 1422.8m, "https://localhost:5001/images/energy.jpeg", 1933.7m, 1229.9m, 174.51m, "England", 1274.3m, 262.3m, 392.4m, 749.8m, 2004 },
                    { 27, 297.1m, "https://localhost:5001/images/energy.jpeg", 512.8m, 64.4m, 37.58m, "Northern Ireland", 1927.5m, 773.6m, 133.9m, 1830.0m, 2006 },
                    { 26, 1570.8m, "https://localhost:5001/images/energy.jpeg", 1936.9m, 389.3m, 3.71m, "Yorkshire and the Humber", 696.6m, 1464.1m, 1389.7m, 1324.6m, 2003 },
                    { 25, 886.1m, "https://localhost:5001/images/energy.jpeg", 261.8m, 1516.4m, 59.83m, "Yorkshire and the Humber", 950.8m, 144.1m, 1800.5m, 1084.5m, 2004 },
                    { 24, 972.1m, "https://localhost:5001/images/energy.jpeg", 376.3m, 1008.8m, 67.21m, "England", 706.6m, 305.6m, 274.6m, 1327.0m, 2005 },
                    { 2, 90.5m, "https://localhost:5001/images/energy.jpeg", 660.8m, 1881.9m, 158.52m, "Northern Ireland", 1514.7m, 775.9m, 911.5m, 658.2m, 2003 },
                    { 3, 213.5m, "https://localhost:5001/images/energy.jpeg", 810.5m, 1779.0m, 90.71m, "Northern Ireland", 383.6m, 740.5m, 73.7m, 82.4m, 2003 },
                    { 4, 1962.7m, "https://localhost:5001/images/energy.jpeg", 1069.4m, 1610.5m, 49.99m, "Yorkshire and the Humber", 591.5m, 244.3m, 1355.6m, 1626.7m, 2003 },
                    { 5, 907.2m, "https://localhost:5001/images/energy.jpeg", 455.9m, 1079.8m, 93.83m, "Scotland", 491.7m, 1483.8m, 1414.1m, 1461.3m, 2006 },
                    { 6, 661.6m, "https://localhost:5001/images/energy.jpeg", 975.9m, 353.9m, 65.83m, "Yorkshire and the Humber", 1328.4m, 1722.5m, 170.5m, 292.7m, 2006 },
                    { 7, 1128.1m, "https://localhost:5001/images/energy.jpeg", 1179.1m, 1302.5m, 99.68m, "Scotland", 1554.2m, 319.9m, 1337.0m, 1298.1m, 2006 },
                    { 8, 538.5m, "https://localhost:5001/images/energy.jpeg", 1091.2m, 668.2m, 155.20m, "Yorkshire and the Humber", 1224.5m, 1582.0m, 1837.5m, 1637.6m, 2005 },
                    { 9, 611.9m, "https://localhost:5001/images/energy.jpeg", 882.6m, 1456.1m, 147.64m, "Scotland", 635.3m, 27.1m, 82.1m, 295.1m, 2006 },
                    { 10, 70.8m, "https://localhost:5001/images/energy.jpeg", 274.7m, 124.3m, 192.98m, "Northern Ireland", 1363.9m, 1859.9m, 1247.4m, 1888.0m, 2004 },
                    { 11, 814.3m, "https://localhost:5001/images/energy.jpeg", 1781.3m, 455.1m, 136.35m, "Yorkshire and the Humber", 1637.1m, 946.0m, 1931.8m, 759.8m, 2006 },
                    { 49, 1982.0m, "https://localhost:5001/images/energy.jpeg", 1377.3m, 68.5m, 51.36m, "England", 670.1m, 1275.3m, 1024.3m, 1148.4m, 2003 },
                    { 12, 1843.6m, "https://localhost:5001/images/energy.jpeg", 1316.5m, 1215.9m, 78.99m, "England", 1239.2m, 701.7m, 246.1m, 771.9m, 2006 },
                    { 14, 604.1m, "https://localhost:5001/images/energy.jpeg", 970.8m, 363.2m, 115.36m, "Northern Ireland", 1748.3m, 444.9m, 218.4m, 808.3m, 2003 },
                    { 15, 679.0m, "https://localhost:5001/images/energy.jpeg", 1943.5m, 1641.8m, 182.09m, "England", 359.4m, 8.2m, 1237.2m, 510.1m, 2004 },
                    { 16, 5.1m, "https://localhost:5001/images/energy.jpeg", 1878.0m, 369.7m, 152.03m, "Yorkshire and the Humber", 1118.0m, 1366.5m, 917.7m, 1422.6m, 2004 },
                    { 17, 603.5m, "https://localhost:5001/images/energy.jpeg", 1499.3m, 553.5m, 133.15m, "Yorkshire and the Humber", 526.2m, 497.8m, 1792.4m, 1981.5m, 2006 }
                });

            migrationBuilder.InsertData(
                schema: "ENERGY_DATASET",
                table: "EnergyRecord",
                columns: new[] { "Id", "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[,]
                {
                    { 18, 1818.1m, "https://localhost:5001/images/energy.jpeg", 1212.8m, 38.1m, 63.50m, "Northern Ireland", 111.6m, 30.6m, 880.7m, 770.9m, 2004 },
                    { 19, 1204.9m, "https://localhost:5001/images/energy.jpeg", 1544.2m, 1890.6m, 188.62m, "Scotland", 399.3m, 1100.4m, 953.2m, 381.9m, 2003 },
                    { 20, 1439.4m, "https://localhost:5001/images/energy.jpeg", 445.8m, 717.6m, 174.31m, "Northern Ireland", 168.8m, 711.0m, 1113.4m, 996.7m, 2004 },
                    { 21, 1800.9m, "https://localhost:5001/images/energy.jpeg", 287.8m, 541.9m, 175.59m, "Yorkshire and the Humber", 647.5m, 806.0m, 1373.1m, 1144.0m, 2005 },
                    { 22, 131.7m, "https://localhost:5001/images/energy.jpeg", 1009.2m, 1028.3m, 129.98m, "Scotland", 969.3m, 1393.0m, 1480.2m, 339.1m, 2004 },
                    { 23, 271.7m, "https://localhost:5001/images/energy.jpeg", 1956.5m, 1657.5m, 132.12m, "Scotland", 1909.0m, 711.8m, 754.6m, 1453.0m, 2005 },
                    { 13, 305.6m, "https://localhost:5001/images/energy.jpeg", 1162.2m, 390.1m, 94.22m, "Scotland", 565.3m, 473.6m, 390.0m, 1275.3m, 2003 },
                    { 50, 1240.4m, "https://localhost:5001/images/energy.jpeg", 797.4m, 859.4m, 34.46m, "Scotland", 1678.1m, 1876.2m, 520.6m, 1661.0m, 2003 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyRecord",
                schema: "ENERGY_DATASET");
        }
    }
}
