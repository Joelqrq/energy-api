using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyAPI.Migrations
{
    public partial class AddPriceToEnergyGenerations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "EnergyGeneration",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                defaultValue: 0.0m);

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1157.2m, 508.2m, 1006.0m, 106.29m, "Scotland", 352.9m, 286.7m, 1315.3m, 1434.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1245.1m, 1086.0m, 55.4m, 22.53m, "England", 850.5m, 606.6m, 684.7m, 1264.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1422.8m, 973.6m, 991.4m, 132.95m, "Northern Ireland", 1098.3m, 1727.3m, 1510.1m, 469.6m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1261.6m, 238.0m, 1830.3m, 173.06m, "England", 38.8m, 352.2m, 752.5m, 148.9m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1675.3m, 1523.7m, 290.8m, 133.13m, "Yorkshire and the Humber", 1706.4m, 390.0m, 392.8m, 1423.3m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1711.2m, 1526.9m, 1924.1m, 77.20m, "Yorkshire and the Humber", 783.6m, 216.9m, 1431.1m, 1689.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 996.1m, 301.4m, 512.1m, 93.00m, "Scotland", 975.8m, 645.9m, 556.1m, 1278.6m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 973.1m, 1170.4m, 76.8m, 158.88m, "Yorkshire and the Humber", 1259.0m, 1803.6m, 1275.2m, 1703.2m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 71.9m, 708.2m, 717.7m, 142.30m, "Northern Ireland", 812.0m, 1968.8m, 955.2m, 601.3m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 553.6m, 27.4m, 867.2m, 32.75m, 1147.7m, 1417.0m, 1422.1m, 1613.4m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1662.8m, 1474.3m, 414.0m, 71.03m, "Yorkshire and the Humber", 1764.9m, 172.1m, 801.1m, 1644.8m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1500.7m, 915.4m, 323.3m, 181.04m, "Yorkshire and the Humber", 1030.9m, 1744.0m, 793.9m, 120.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 693.3m, 1642.2m, 281.1m, 90.38m, "Scotland", 1854.1m, 127.5m, 318.3m, 543.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 887.4m, 1037.9m, 1800.2m, 70.53m, "England", 49.1m, 1190.3m, 1093.2m, 659.8m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 284.6m, 193.3m, 819.4m, 114.91m, "England", 1786.6m, 391.2m, 158.4m, 545.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1790.2m, 468.4m, 1326.5m, 164.70m, "Scotland", 422.5m, 946.9m, 513.1m, 1123.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 237.6m, 790.2m, 1027.3m, 107.16m, "Yorkshire and the Humber", 864.7m, 744.7m, 1466.7m, 286.4m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1993.5m, 1038.0m, 384.7m, 14.35m, "Yorkshire and the Humber", 306.2m, 531.7m, 594.8m, 1132.9m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1241.5m, 1180.0m, 146.6m, 156.95m, "Northern Ireland", 1067.1m, 670.7m, 480.5m, 1889.9m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1404.4m, 7.7m, 1078.8m, 25.89m, 1128.6m, 1293.6m, 118.7m, 853.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 523.0m, 571.1m, 528.3m, 154.89m, "Yorkshire and the Humber", 1184.1m, 206.9m, 247.7m, 74.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1197.7m, 1303.2m, 1805.9m, 42.89m, "England", 571.5m, 399.6m, 1377.4m, 794.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 751.3m, 261.8m, 1014.1m, 162.31m, "Northern Ireland", 1724.5m, 1466.2m, 485.8m, 356.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1334.0m, 748.0m, 1642.2m, 90.17m, "Scotland", 75.2m, 1296.3m, 982.7m, 1091.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 335.3m, 916.6m, 1475.8m, 54.40m, "Northern Ireland", 1506.7m, 1547.1m, 241.7m, 1939.6m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 850.6m, 809.3m, 1588.8m, 193.08m, "England", 491.3m, 523.1m, 1670.5m, 679.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 792.8m, 992.5m, 1811.9m, 43.28m, "Scotland", 443.1m, 1302.1m, 1305.2m, 1062.0m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 405.9m, 704.0m, 114.8m, 123.75m, "Scotland", 952.7m, 979.0m, 1855.6m, 509.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1784.0m, 1280.1m, 1420.6m, 138.92m, "Northern Ireland", 800.5m, 491.4m, 1535.3m, 1466.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1113.4m, 1589.6m, 634.4m, 122.45m, "Yorkshire and the Humber", 282.8m, 1798.6m, 863.5m, 1119.0m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 440.1m, 1692.1m, 823.4m, 71.39m, 1481.1m, 717.7m, 309.6m, 173.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1475.1m, 90.0m, 1526.7m, 8.53m, 598.1m, 504.6m, 1133.9m, 609.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1290.4m, 542.0m, 1646.1m, 65.91m, "Scotland", 712.9m, 1572.8m, 77.5m, 1320.4m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 729.9m, 612.3m, 1157.3m, 183.92m, "England", 46.4m, 54.1m, 265.1m, 316.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1830.1m, 549.4m, 1985.0m, 36.04m, 1077.9m, 265.4m, 406.0m, 702.8m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1770.8m, 1784.2m, 96.0m, 80.76m, "England", 1201.1m, 1596.6m, 1139.4m, 129.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 77.0m, 378.2m, 344.6m, 19.07m, 1269.1m, 1087.5m, 878.4m, 1250.5m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1056.0m, 869.0m, 914.4m, 186.81m, 567.2m, 999.6m, 144.2m, 1472.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 753.3m, 1939.7m, 1176.7m, 88.28m, "Northern Ireland", 815.8m, 1063.9m, 765.1m, 1380.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 45.8m, 1206.1m, 1824.3m, 27.56m, "Northern Ireland", 462.3m, 1136.9m, 1863.4m, 1560.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 90.8m, 590.4m, 1985.5m, 100.08m, "England", 1944.9m, 572.2m, 397.2m, 897.5m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1341.0m, 665.2m, 485.4m, 14.51m, "Northern Ireland", 1449.7m, 62.6m, 713.7m, 1096.4m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 346.4m, 1371.8m, 1609.0m, 51.57m, "Yorkshire and the Humber", 922.3m, 1681.8m, 811.8m, 1280.7m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 536.2m, 1659.4m, 983.4m, 52.13m, "Yorkshire and the Humber", 1431.0m, 820.2m, 1998.7m, 1777.4m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 75.9m, 1419.8m, 846.9m, 72.50m, "Scotland", 1373.8m, 413.7m, 918.7m, 604.5m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 250.3m, 924.0m, 85.6m, 112.12m, "Northern Ireland", 863.6m, 1474.8m, 621.1m, 1761.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1857.0m, 1092.3m, 1097.6m, 159.84m, "Northern Ireland", 295.2m, 1282.7m, 50.8m, 303.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 183.0m, 597.0m, 361.9m, 91.34m, "Scotland", 352.8m, 1437.9m, 1337.5m, 1665.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1129.2m, 1282.9m, 1156.2m, 84.64m, 1140.7m, 1135.1m, 560.5m, 1195.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1181.5m, 1650.4m, 553.6m, 118.07m, "Scotland", 6.1m, 623.5m, 1221.8m, 1508.5m, 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "EnergyGeneration");

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1530.8m, 1677.4m, 76.9m, "Northern Ireland", 1517.3m, 563.7m, 800.0m, 221.3m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 860.2m, 447.8m, 1788.3m, "Northern Ireland", 110.1m, 1397.1m, 233.3m, 994.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 887.6m, 1855.1m, 1081.3m, "Yorkshire and the Humber", 1136.9m, 671.8m, 225.6m, 197.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 185.3m, 1327.8m, 1834.0m, "Yorkshire and the Humber", 300.2m, 416.2m, 447.9m, 763.5m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1944.2m, 670.1m, 751.4m, "Northern Ireland", 1847.7m, 339.0m, 1112.1m, 236.4m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1935.1m, 1466.3m, 159.8m, "Scotland", 45.2m, 27.2m, 252.5m, 224.3m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 435.9m, 859.0m, 1275.3m, "Northern Ireland", 944.8m, 894.3m, 1333.6m, 1542.0m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 276.1m, 444.0m, 1016.6m, "Northern Ireland", 905.4m, 1051.7m, 808.6m, 262.8m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 385.4m, 548.5m, 501.8m, "England", 1555.4m, 1242.8m, 253.4m, 1480.4m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 140.4m, 158.1m, 634.9m, 981.6m, 1255.3m, 828.4m, 1137.3m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 572.3m, 1049.8m, 869.9m, "England", 253.1m, 1794.9m, 1800.4m, 1791.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1028.5m, 883.4m, 305.5m, "Northern Ireland", 1808.5m, 1830.3m, 1948.1m, 932.9m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 442.9m, 1193.0m, 411.5m, "England", 785.0m, 1125.7m, 1156.6m, 1023.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 270.5m, 1020.7m, 1569.9m, "Northern Ireland", 650.5m, 919.0m, 122.3m, 1974.9m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 685.4m, 590.4m, 472.3m, "Yorkshire and the Humber", 1203.5m, 1957.2m, 908.0m, 76.2m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 676.0m, 310.0m, 1611.3m, "England", 1945.0m, 195.3m, 108.7m, 341.0m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1841.6m, 1446.6m, 1292.7m, "Scotland", 607.4m, 1898.2m, 1348.7m, 1312.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 238.6m, 109.4m, 1623.4m, "Scotland", 927.3m, 945.3m, 662.4m, 1894.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 312.7m, 485.7m, 883.1m, "Scotland", 566.1m, 1912.2m, 337.7m, 1235.9m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1039.1m, 75.2m, 788.6m, 1812.3m, 1852.4m, 1298.8m, 1026.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1910.8m, 787.2m, 770.4m, "Scotland", 1461.4m, 518.3m, 234.6m, 752.8m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 321.5m, 1730.7m, 555.9m, "Scotland", 1999.2m, 1972.5m, 102.3m, 1571.8m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1724.2m, 1929.3m, 661.8m, "Scotland", 863.0m, 1644.4m, 999.8m, 1151.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 138.7m, 386.1m, 502.9m, "Northern Ireland", 587.2m, 1712.3m, 854.9m, 141.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1795.7m, 1794.3m, 422.6m, "Scotland", 1550.4m, 1235.6m, 1325.1m, 177.3m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1256.3m, 1066.5m, 1115.7m, "Northern Ireland", 1568.1m, 894.1m, 705.1m, 1649.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 799.5m, 266.3m, 1915.7m, "Northern Ireland", 305.2m, 249.2m, 1028.5m, 1048.1m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1496.3m, 609.2m, 1538.2m, "Yorkshire and the Humber", 1716.1m, 1036.5m, 1433.1m, 1060.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 440.3m, 488.6m, 1589.0m, "Scotland", 1205.4m, 1979.4m, 1355.5m, 343.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1471.4m, 1244.5m, 1685.0m, "England", 1788.4m, 1896.1m, 885.2m, 953.0m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1634.6m, 1546.5m, 1417.5m, 1058.7m, 1214.5m, 1377.7m, 1214.1m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 29.9m, 219.8m, 1271.2m, 95.8m, 1481.4m, 152.7m, 966.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 716.2m, 820.0m, 270.9m, "Yorkshire and the Humber", 539.9m, 1749.4m, 607.8m, 1401.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 31.1m, 1600.1m, 1945.1m, "Yorkshire and the Humber", 188.5m, 374.3m, 1588.8m, 1419.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1787.9m, 1225.7m, 313.3m, 1808.9m, 681.7m, 709.2m, 575.5m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 517.1m, 1989.9m, 694.4m, "Scotland", 665.3m, 339.4m, 923.1m, 70.4m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 787.7m, 1885.2m, 250.3m, 557.6m, 1925.9m, 497.9m, 623.9m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 150.7m, 1655.5m, 397.5m, 552.5m, 853.7m, 935.0m, 718.7m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 226.6m, 34.4m, 1806.7m, "Scotland", 1382.1m, 428.2m, 1613.3m, 1536.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1494.1m, 1691.6m, 1105.2m, "England", 1598.9m, 1888.7m, 902.5m, 826.2m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1558.6m, 1861.9m, 1430.8m, "Yorkshire and the Humber", 823.9m, 1726.8m, 1787.7m, 1859.8m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 267.8m, 1663.3m, 1083.9m, "England", 1267.6m, 853.4m, 1919.7m, 1290.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 750.8m, 359.4m, 206.3m, "Northern Ireland", 463.4m, 1877.2m, 397.3m, 674.1m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1447.2m, 261.9m, 1905.0m, "Northern Ireland", 1243.3m, 1073.1m, 1224.5m, 987.4m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1951.2m, 499.7m, 71.4m, "Yorkshire and the Humber", 1751.3m, 1728.5m, 1977.9m, 1016.9m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 514.9m, 640.6m, 888.8m, "Scotland", 1239.2m, 223.7m, 558.3m, 1105.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 617.6m, 1681.4m, 762.1m, "Yorkshire and the Humber", 1428.3m, 538.4m, 1108.9m, 860.9m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1362.5m, 1194.7m, 669.3m, "Northern Ireland", 1657.7m, 1965.8m, 1842.8m, 834.8m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 392.0m, 1022.3m, 1221.3m, 1897.5m, 447.1m, 722.8m, 1130.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 354.4m, 1223.5m, 1047.3m, "Northern Ireland", 583.9m, 551.8m, 472.5m, 1653.0m, 2004 });
        }
    }
}
