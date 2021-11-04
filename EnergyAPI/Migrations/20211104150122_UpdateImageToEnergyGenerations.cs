using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyAPI.Migrations
{
    public partial class UpdateImageToEnergyGenerations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1910.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 120.6m, 468.9m, 48.04m, 1678.3m, 135.5m, 753.1m, 1880.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1938.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1558.2m, 952.6m, 23.75m, "Northern Ireland", 124.1m, 1892.7m, 1726.3m, 230.2m, 2006 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1490.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1360.5m, 531.7m, 187.91m, "Scotland", 748.0m, 1423.0m, 995.4m, 547.3m });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 415.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1832.8m, 10.5m, 149.65m, "Scotland", 1923.5m, 640.4m, 853.7m, 393.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 385.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 49.7m, 1234.7m, 199.43m, 740.7m, 978.2m, 256.4m, 1019.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 938.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 499.6m, 1618.2m, 63.37m, 261.5m, 1387.6m, 1940.7m, 1529.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1952.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1140.4m, 1693.5m, 117.58m, 563.3m, 1071.8m, 1952.4m, 736.4m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 718.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 598.6m, 885.2m, 33.29m, "Yorkshire and the Humber", 1572.2m, 1575.5m, 1428.7m, 1891.2m });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1544.1m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 998.0m, 1067.5m, 98.53m, "England", 1488.8m, 1693.0m, 1464.6m, 622.9m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1228.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1135.3m, 100.8m, 78.82m, "England", 976.1m, 368.5m, 645.3m, 162.9m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 561.8m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1119.3m, 1720.3m, 154.33m, "Scotland", 288.8m, 1034.2m, 1290.9m, 42.7m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1442.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 727.1m, 426.5m, 27.40m, "Northern Ireland", 417.4m, 1939.8m, 86.5m, 1101.2m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 530.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1780.7m, 1071.0m, 2.80m, 851.6m, 39.8m, 787.2m, 1192.1m });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 557.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1254.9m, 76.3m, 92.69m, 850.5m, 227.8m, 1419.0m, 33.2m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 808.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 422.3m, 1255.5m, 153.32m, 1823.1m, 439.2m, 340.4m, 160.9m });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 442.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1497.8m, 1773.0m, 11.63m, 1603.2m, 1936.6m, 1012.8m, 1250.7m });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1106.0m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1457.9m, 1148.0m, 82.67m, "Yorkshire and the Humber", 262.0m, 737.1m, 111.4m, 635.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1076.6m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1205.1m, 1173.8m, 138.07m, 482.2m, 156.0m, 145.1m, 1318.8m, 2005 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1229.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1597.4m, 747.4m, 8.24m, "Northern Ireland", 526.6m, 935.4m, 1845.0m, 1006.8m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1095.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 375.9m, 1032.2m, 106.92m, "England", 555.9m, 1873.9m, 1624.2m, 532.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 501.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1175.3m, 208.9m, 190.71m, "Scotland", 535.4m, 1805.6m, 1510.3m, 281.0m });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 421.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 276.2m, 1849.6m, 100.80m, "Scotland", 55.6m, 553.9m, 1797.7m, 897.5m, 2004 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 697.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1494.0m, 459.2m, 2.50m, "Yorkshire and the Humber", 1061.3m, 1936.7m, 526.4m, 941.8m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 848.3m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 727.3m, 483.3m, 89.01m, "Yorkshire and the Humber", 1149.6m, 1454.7m, 865.8m, 1955.5m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1971.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1615.8m, 591.7m, 11.35m, "Yorkshire and the Humber", 711.7m, 594.5m, 561.8m, 1655.0m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1369.0m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 813.2m, 371.1m, 32.52m, 953.9m, 736.4m, 1051.6m, 1672.0m, 2005 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 728.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1733.4m, 379.9m, 63.06m, "Scotland", 1799.7m, 1814.6m, 1195.9m, 41.8m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 888.2m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1722.2m, 903.9m, 108.98m, 1548.0m, 1911.9m, 1611.4m, 1864.6m, 2005 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1501.5m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 313.6m, 476.0m, 40.87m, "Scotland", 1690.3m, 1251.8m, 1963.8m, 1403.9m, 2006 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 278.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 93.4m, 1945.0m, 111.17m, 595.5m, 10.2m, 1407.2m, 79.9m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1457.9m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1498.4m, 1900.7m, 139.15m, 1199.1m, 1921.0m, 1405.9m, 1818.0m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1601.7m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1799.6m, 100.3m, 4.65m, "Yorkshire and the Humber", 144.9m, 1820.7m, 1686.3m, 1652.1m, 2004 });

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
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1893.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 615.2m, 1150.5m, 141.16m, "England", 909.8m, 447.4m, 1860.2m, 465.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1334.6m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1524.6m, 393.5m, 81.80m, "England", 537.1m, 1262.3m, 69.2m, 380.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 204.4m, "https://4d1e-138-75-155-224.ngrok.io/images/energy.jpeg", 1866.6m, 367.9m, 99.37m, 935.7m, 1578.0m, 850.0m, 124.2m, 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1157.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 508.2m, 1006.0m, 106.29m, 352.9m, 286.7m, 1315.3m, 1434.2m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1245.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1086.0m, 55.4m, 22.53m, "England", 850.5m, 606.6m, 684.7m, 1264.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1422.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 973.6m, 991.4m, 132.95m, "Northern Ireland", 1098.3m, 1727.3m, 1510.1m, 469.6m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1261.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 238.0m, 1830.3m, 173.06m, "England", 38.8m, 352.2m, 752.5m, 148.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1675.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1523.7m, 290.8m, 133.13m, "Yorkshire and the Humber", 1706.4m, 390.0m, 392.8m, 1423.3m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1711.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1526.9m, 1924.1m, 77.20m, "Yorkshire and the Humber", 783.6m, 216.9m, 1431.1m, 1689.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 996.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 301.4m, 512.1m, 93.00m, 975.8m, 645.9m, 556.1m, 1278.6m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 973.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1170.4m, 76.8m, 158.88m, 1259.0m, 1803.6m, 1275.2m, 1703.2m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 71.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 708.2m, 717.7m, 142.30m, 812.0m, 1968.8m, 955.2m, 601.3m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 553.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 27.4m, 867.2m, 32.75m, "England", 1147.7m, 1417.0m, 1422.1m, 1613.4m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1662.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1474.3m, 414.0m, 71.03m, "Yorkshire and the Humber", 1764.9m, 172.1m, 801.1m, 1644.8m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1500.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 915.4m, 323.3m, 181.04m, "Yorkshire and the Humber", 1030.9m, 1744.0m, 793.9m, 120.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 693.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1642.2m, 281.1m, 90.38m, "Scotland", 1854.1m, 127.5m, 318.3m, 543.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 887.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1037.9m, 1800.2m, 70.53m, "England", 49.1m, 1190.3m, 1093.2m, 659.8m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 284.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 193.3m, 819.4m, 114.91m, "England", 1786.6m, 391.2m, 158.4m, 545.5m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1790.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 468.4m, 1326.5m, 164.70m, 422.5m, 946.9m, 513.1m, 1123.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 237.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 790.2m, 1027.3m, 107.16m, "Yorkshire and the Humber", 864.7m, 744.7m, 1466.7m, 286.4m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1993.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1038.0m, 384.7m, 14.35m, 306.2m, 531.7m, 594.8m, 1132.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1241.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1180.0m, 146.6m, 156.95m, 1067.1m, 670.7m, 480.5m, 1889.9m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1404.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 7.7m, 1078.8m, 25.89m, "Scotland", 1128.6m, 1293.6m, 118.7m, 853.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 523.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 571.1m, 528.3m, 154.89m, 1184.1m, 206.9m, 247.7m, 74.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1197.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1303.2m, 1805.9m, 42.89m, "England", 571.5m, 399.6m, 1377.4m, 794.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 751.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 261.8m, 1014.1m, 162.31m, 1724.5m, 1466.2m, 485.8m, 356.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1334.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 748.0m, 1642.2m, 90.17m, "Scotland", 75.2m, 1296.3m, 982.7m, 1091.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 335.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 916.6m, 1475.8m, 54.40m, 1506.7m, 1547.1m, 241.7m, 1939.6m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 850.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 809.3m, 1588.8m, 193.08m, "England", 491.3m, 523.1m, 1670.5m, 679.1m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 792.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 992.5m, 1811.9m, 43.28m, "Scotland", 443.1m, 1302.1m, 1305.2m, 1062.0m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 405.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 704.0m, 114.8m, 123.75m, "Scotland", 952.7m, 979.0m, 1855.6m, 509.6m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1784.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1280.1m, 1420.6m, 138.92m, "Northern Ireland", 800.5m, 491.4m, 1535.3m, 1466.9m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1113.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1589.6m, 634.4m, 122.45m, "Yorkshire and the Humber", 282.8m, 1798.6m, 863.5m, 1119.0m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 440.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1692.1m, 823.4m, 71.39m, "Yorkshire and the Humber", 1481.1m, 717.7m, 309.6m, 173.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1475.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 90.0m, 1526.7m, 8.53m, "Northern Ireland", 598.1m, 504.6m, 1133.9m, 609.7m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1290.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 542.0m, 1646.1m, 65.91m, "Scotland", 712.9m, 1572.8m, 77.5m, 1320.4m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 729.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 612.3m, 1157.3m, 183.92m, "England", 46.4m, 54.1m, 265.1m, 316.2m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1830.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 549.4m, 1985.0m, 36.04m, "England", 1077.9m, 265.4m, 406.0m, 702.8m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1770.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1784.2m, 96.0m, 80.76m, "England", 1201.1m, 1596.6m, 1139.4m, 129.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 77.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 378.2m, 344.6m, 19.07m, 1269.1m, 1087.5m, 878.4m, 1250.5m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1056.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 869.0m, 914.4m, 186.81m, "Northern Ireland", 567.2m, 999.6m, 144.2m, 1472.5m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 753.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1939.7m, 1176.7m, 88.28m, "Northern Ireland", 815.8m, 1063.9m, 765.1m, 1380.7m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 45.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1206.1m, 1824.3m, 27.56m, 462.3m, 1136.9m, 1863.4m, 1560.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 90.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 590.4m, 1985.5m, 100.08m, 1944.9m, 572.2m, 397.2m, 897.5m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1341.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 665.2m, 485.4m, 14.51m, "Northern Ireland", 1449.7m, 62.6m, 713.7m, 1096.4m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 346.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1371.8m, 1609.0m, 51.57m, "Yorkshire and the Humber", 922.3m, 1681.8m, 811.8m, 1280.7m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 536.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1659.4m, 983.4m, 52.13m, 1431.0m, 820.2m, 1998.7m, 1777.4m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 75.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1419.8m, 846.9m, 72.50m, 1373.8m, 413.7m, 918.7m, 604.5m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 250.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 924.0m, 85.6m, 112.12m, "Northern Ireland", 863.6m, 1474.8m, 621.1m, 1761.7m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1857.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1092.3m, 1097.6m, 159.84m, "Northern Ireland", 295.2m, 1282.7m, 50.8m, 303.7m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 183.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 597.0m, 361.9m, 91.34m, "Scotland", 352.8m, 1437.9m, 1337.5m, 1665.1m, 2006 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2" },
                values: new object[] { 1129.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1282.9m, 1156.2m, 84.64m, "Northern Ireland", 1140.7m, 1135.1m, 560.5m, 1195.2m });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Price", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1181.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1650.4m, 553.6m, 118.07m, 6.1m, 623.5m, 1221.8m, 1508.5m, 2006 });
        }
    }
}
