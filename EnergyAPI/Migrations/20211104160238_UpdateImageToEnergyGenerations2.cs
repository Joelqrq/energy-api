using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyAPI.Migrations
{
    public partial class UpdateImageToEnergyGenerations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 319.8m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 799.5m, 201.7m, 197.70m, "England", 360.9m, 1055.2m, 271.9m, 607.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 982.0m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 578.4m, 1023.2m, 57.57m, "Scotland", 1654.0m, 1339.2m, 1435.8m, 1502.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 776.8m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1588.8m, 852.1m, 176.94m, "Northern Ireland", 921.2m, 1692.5m, 1215.4m, 1630.6m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1514.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1715.4m, 1937.6m, 171.05m, "Yorkshire and the Humber", 1217.0m, 967.1m, 640.0m, 1177.3m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 163.0m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1694.8m, 1254.4m, 56.74m, "England", 947.3m, 496.5m, 129.9m, 1813.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 557.2m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 478.7m, 1392.2m, 11.12m, 58.3m, 1350.7m, 588.5m, 1868.4m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 278.7m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 620.7m, 862.2m, 158.40m, 1756.4m, 218.8m, 1344.7m, 509.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1914.8m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 809.0m, 1500.6m, 13.90m, "Northern Ireland", 1436.0m, 268.1m, 771.8m, 56.0m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1292.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1377.1m, 588.8m, 75.81m, "England", 618.0m, 581.7m, 1581.3m, 355.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 385.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1494.5m, 469.2m, 65.97m, "England", 1836.4m, 373.5m, 1383.1m, 586.8m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 451.7m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1470.3m, 1096.6m, 66.86m, "Northern Ireland", 844.5m, 1152.4m, 357.4m, 1035.6m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 396.5m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1591.7m, 927.9m, 14.35m, "Northern Ireland", 502.0m, 726.6m, 592.5m, 1124.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 943.4m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 53.9m, 672.9m, 46.35m, 1102.8m, 935.3m, 1559.0m, 280.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 249.4m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1298.7m, 1998.2m, 105.00m, "England", 1215.8m, 736.7m, 1599.5m, 1127.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 58.1m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1199.1m, 1994.3m, 16.62m, "England", 911.6m, 881.0m, 438.1m, 1436.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1510.4m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 552.0m, 1476.6m, 143.98m, "Northern Ireland", 1767.0m, 1254.5m, 1909.9m, 1742.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1408.3m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1850.8m, 1524.5m, 190.11m, "Northern Ireland", 1723.3m, 1376.7m, 102.3m, 161.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 620.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 595.4m, 1842.3m, 25.26m, "Scotland", 641.0m, 647.3m, 560.4m, 191.1m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1853.5m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 597.2m, 1217.2m, 104.47m, "England", 255.8m, 1832.4m, 1495.5m, 1791.8m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1025.0m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 119.2m, 1334.0m, 170.53m, "Scotland", 1768.4m, 714.8m, 835.6m, 743.6m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1200.7m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 375.4m, 1182.1m, 150.32m, "Scotland", 342.0m, 1268.9m, 628.3m, 617.5m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 338.2m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1005.6m, 665.7m, 114.60m, "Northern Ireland", 156.7m, 1846.5m, 209.8m, 829.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1275.6m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 849.8m, 1355.5m, 186.97m, 555.2m, 792.0m, 1671.3m, 1692.1m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 69.8m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1442.0m, 1163.4m, 161.59m, 837.4m, 1153.4m, 1144.1m, 1127.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 987.7m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 992.9m, 533.8m, 105.50m, "Yorkshire and the Humber", 790.3m, 678.8m, 686.3m, 1948.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1573.5m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1982.3m, 946.2m, 143.02m, "Yorkshire and the Humber", 692.0m, 73.1m, 845.1m, 1487.4m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1653.5m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1582.0m, 1685.1m, 106.64m, "Yorkshire and the Humber", 644.3m, 1372.4m, 1652.9m, 390.1m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1396.1m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 685.3m, 1005.8m, 8.69m, "Scotland", 391.5m, 881.0m, 791.4m, 1512.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1048.2m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1773.9m, 282.4m, 156.74m, 1596.5m, 452.0m, 1361.7m, 676.6m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 458.2m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1024.9m, 295.4m, 126.38m, "England", 704.1m, 41.9m, 87.0m, 1090.3m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 177.2m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1941.1m, 696.0m, 113.67m, "Yorkshire and the Humber", 534.0m, 453.5m, 591.9m, 1161.4m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 34.8m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 343.2m, 1028.3m, 129.59m, "Northern Ireland", 783.7m, 56.3m, 505.7m, 65.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 400.4m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 751.8m, 1425.2m, 159.60m, "Yorkshire and the Humber", 1999.4m, 87.2m, 108.5m, 1233.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 974.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1154.6m, 84.7m, 193.33m, "England", 161.7m, 827.7m, 1744.2m, 963.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1110.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 430.6m, 584.5m, 141.92m, 375.5m, 1303.2m, 1156.0m, 1828.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 106.0m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 74.7m, 1052.8m, 66.92m, "Scotland", 1257.1m, 592.4m, 445.8m, 239.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 498.3m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 12.6m, 320.8m, 13.35m, "Northern Ireland", 924.7m, 343.9m, 520.2m, 608.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 801.6m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1470.7m, 76.9m, 180.88m, "England", 489.0m, 1732.9m, 637.0m, 200.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 374.6m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 150.8m, 517.9m, 88.85m, "England", 1818.2m, 487.1m, 1417.9m, 122.0m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 591.1m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 469.1m, 1308.6m, 5.56m, "England", 1993.8m, 231.2m, 694.1m, 1492.3m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1856.5m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1796.0m, 1601.9m, 187.72m, 1789.0m, 1956.8m, 1494.4m, 240.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1258.2m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 393.8m, 1190.7m, 45.54m, 163.8m, 701.9m, 1703.9m, 1319.8m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 778.4m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 766.1m, 1506.3m, 55.01m, "Yorkshire and the Humber", 908.6m, 643.2m, 288.3m, 1833.7m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1860.0m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1926.6m, 627.5m, 189.78m, "England", 1790.1m, 1628.9m, 1855.7m, 1845.7m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 902.4m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 781.9m, 1788.3m, 196.17m, "Northern Ireland", 1420.4m, 530.3m, 31.6m, 561.1m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1603.6m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 275.9m, 1952.3m, 73.56m, 1529.8m, 585.7m, 1681.1m, 606.6m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 473.0m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 152.0m, 1464.1m, 101.05m, "England", 122.9m, 1913.7m, 58.9m, 958.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1798.5m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 933.6m, 1802.0m, 30.38m, "Scotland", 1971.6m, 867.8m, 740.2m, 1561.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1054.1m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1555.5m, 164.5m, 0.62m, "Northern Ireland", 1700.6m, 325.8m, 1907.6m, 976.0m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 288.9m, "https://2776-138-75-155-224.ngrok.io/images/energy.jpeg", 1590.2m, 502.1m, 18.65m, 871.3m, 1908.7m, 618.4m, 41.7m, 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1910.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 120.6m, 468.9m, 48.04m, "Scotland", 1678.3m, 135.5m, 753.1m, 1880.3m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1938.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1558.2m, 952.6m, 23.75m, "Northern Ireland", 124.1m, 1892.7m, 1726.3m, 230.2m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1684.0m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1530.3m, 386.1m, 71.42m, "Scotland", 112.6m, 1448.9m, 1869.7m, 1934.6m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1490.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1360.5m, 531.7m, 187.91m, "Scotland", 748.0m, 1423.0m, 995.4m, 547.3m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 936.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1178.4m, 694.6m, 195.20m, "Scotland", 482.1m, 1649.7m, 316.3m, 1141.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 415.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1832.8m, 10.5m, 149.65m, 1923.5m, 640.4m, 853.7m, 393.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 385.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 49.7m, 1234.7m, 199.43m, 740.7m, 978.2m, 256.4m, 1019.9m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 938.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 499.6m, 1618.2m, 63.37m, "Yorkshire and the Humber", 261.5m, 1387.6m, 1940.7m, 1529.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1952.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1140.4m, 1693.5m, 117.58m, "Northern Ireland", 563.3m, 1071.8m, 1952.4m, 736.4m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 718.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 598.6m, 885.2m, 33.29m, "Yorkshire and the Humber", 1572.2m, 1575.5m, 1428.7m, 1891.2m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 289.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 14.7m, 453.0m, 9.66m, "Scotland", 918.1m, 592.2m, 1016.0m, 1716.3m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1544.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 998.0m, 1067.5m, 98.53m, "England", 1488.8m, 1693.0m, 1464.6m, 622.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1228.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1135.3m, 100.8m, 78.82m, 976.1m, 368.5m, 645.3m, 162.9m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 561.8m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1119.3m, 1720.3m, 154.33m, "Scotland", 288.8m, 1034.2m, 1290.9m, 42.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1442.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 727.1m, 426.5m, 27.40m, "Northern Ireland", 417.4m, 1939.8m, 86.5m, 1101.2m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 530.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1780.7m, 1071.0m, 2.80m, "Scotland", 851.6m, 39.8m, 787.2m, 1192.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 301.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 171.7m, 1331.9m, 168.97m, "Scotland", 645.7m, 1175.8m, 1048.9m, 84.5m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 557.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1254.9m, 76.3m, 92.69m, "Yorkshire and the Humber", 850.5m, 227.8m, 1419.0m, 33.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 808.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 422.3m, 1255.5m, 153.32m, "Northern Ireland", 1823.1m, 439.2m, 340.4m, 160.9m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 23.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 602.9m, 52.3m, 175.80m, "England", 1120.0m, 1440.7m, 1344.5m, 1680.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 442.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1497.8m, 1773.0m, 11.63m, "Yorkshire and the Humber", 1603.2m, 1936.6m, 1012.8m, 1250.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 445.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1752.9m, 1744.0m, 29.41m, "Scotland", 1188.5m, 1225.7m, 506.6m, 843.1m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 376.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1597.1m, 688.7m, 183.73m, 145.9m, 299.0m, 1417.7m, 892.6m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1106.0m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1457.9m, 1148.0m, 82.67m, 262.0m, 737.1m, 111.4m, 635.6m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1076.6m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1205.1m, 1173.8m, 138.07m, "Northern Ireland", 482.2m, 156.0m, 145.1m, 1318.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 354.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 502.5m, 1833.0m, 67.48m, "Northern Ireland", 237.5m, 866.9m, 1603.3m, 826.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 73.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1068.7m, 731.6m, 122.68m, "Northern Ireland", 339.5m, 244.6m, 1109.8m, 1473.9m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1229.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1597.4m, 747.4m, 8.24m, "Northern Ireland", 526.6m, 935.4m, 1845.0m, 1006.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1095.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 375.9m, 1032.2m, 106.92m, 555.9m, 1873.9m, 1624.2m, 532.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 501.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1175.3m, 208.9m, 190.71m, "Scotland", 535.4m, 1805.6m, 1510.3m, 281.0m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1665.8m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1852.0m, 981.6m, 40.90m, "England", 1687.5m, 1076.6m, 73.5m, 929.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 421.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 276.2m, 1849.6m, 100.80m, "Scotland", 55.6m, 553.9m, 1797.7m, 897.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1362.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 323.8m, 1496.5m, 124.37m, "England", 1479.0m, 1309.5m, 337.4m, 857.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 697.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1494.0m, 459.2m, 2.50m, "Yorkshire and the Humber", 1061.3m, 1936.7m, 526.4m, 941.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 848.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 727.3m, 483.3m, 89.01m, 1149.6m, 1454.7m, 865.8m, 1955.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1971.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1615.8m, 591.7m, 11.35m, "Yorkshire and the Humber", 711.7m, 594.5m, 561.8m, 1655.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1369.0m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 813.2m, 371.1m, 32.52m, "England", 953.9m, 736.4m, 1051.6m, 1672.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 303.0m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 80.8m, 1991.8m, 135.79m, "Scotland", 0.0m, 1187.8m, 1663.8m, 1912.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 728.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1733.4m, 379.9m, 63.06m, "Scotland", 1799.7m, 1814.6m, 1195.9m, 41.8m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 888.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1722.2m, 903.9m, 108.98m, "Northern Ireland", 1548.0m, 1911.9m, 1611.4m, 1864.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 408.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1412.7m, 1991.2m, 178.05m, 1185.7m, 561.8m, 96.7m, 1746.9m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1501.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 313.6m, 476.0m, 40.87m, 1690.3m, 1251.8m, 1963.8m, 1403.9m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 25.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1952.4m, 301.5m, 22.55m, "England", 276.0m, 115.7m, 1646.6m, 556.4m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 278.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 93.4m, 1945.0m, 111.17m, "Yorkshire and the Humber", 595.5m, 10.2m, 1407.2m, 79.9m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1457.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1498.4m, 1900.7m, 139.15m, "Scotland", 1199.1m, 1921.0m, 1405.9m, 1818.0m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1601.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1799.6m, 100.3m, 4.65m, 144.9m, 1820.7m, 1686.3m, 1652.1m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 713.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1544.0m, 1996.6m, 116.02m, "Yorkshire and the Humber", 1827.9m, 1368.3m, 1450.1m, 1875.5m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1893.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 615.2m, 1150.5m, 141.16m, "England", 909.8m, 447.4m, 1860.2m, 465.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1334.6m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1524.6m, 393.5m, 81.80m, "England", 537.1m, 1262.3m, 69.2m, 380.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 204.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1866.6m, 367.9m, 99.37m, 935.7m, 1578.0m, 850.0m, 124.2m, 2003 });
        }
    }
}
