using Microsoft.EntityFrameworkCore.Migrations;

namespace EnergyAPI.Migrations
{
    public partial class UpdateEnergyGenerations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "EnergyGeneration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 1530.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1677.4m, 76.9m, "Northern Ireland", 1517.3m, 563.7m, 800.0m, 221.3m, 2004 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 860.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 447.8m, 1788.3m, 110.1m, 1397.1m, 233.3m, 994.0m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 887.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1855.1m, 1081.3m, 1136.9m, 671.8m, 225.6m, 197.6m, 2005 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 185.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1327.8m, 1834.0m, "Yorkshire and the Humber", 300.2m, 416.2m, 447.9m, 763.5m, 2003 });

            migrationBuilder.InsertData(
                table: "EnergyGeneration",
                columns: new[] { "Id", "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[,]
                {
                    { 49, 392.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1022.3m, 1221.3m, "Northern Ireland", 1897.5m, 447.1m, 722.8m, 1130.1m, 2006 },
                    { 31, 1634.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1546.5m, 1417.5m, "Yorkshire and the Humber", 1058.7m, 1214.5m, 1377.7m, 1214.1m, 2004 },
                    { 32, 29.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 219.8m, 1271.2m, "Northern Ireland", 95.8m, 1481.4m, 152.7m, 966.1m, 2003 },
                    { 33, 716.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 820.0m, 270.9m, "Yorkshire and the Humber", 539.9m, 1749.4m, 607.8m, 1401.2m, 2004 },
                    { 34, 31.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1600.1m, 1945.1m, "Yorkshire and the Humber", 188.5m, 374.3m, 1588.8m, 1419.6m, 2005 },
                    { 35, 1787.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1225.7m, 313.3m, "England", 1808.9m, 681.7m, 709.2m, 575.5m, 2006 },
                    { 36, 517.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1989.9m, 694.4m, "Scotland", 665.3m, 339.4m, 923.1m, 70.4m, 2005 },
                    { 37, 787.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1885.2m, 250.3m, "England", 557.6m, 1925.9m, 497.9m, 623.9m, 2003 },
                    { 38, 150.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1655.5m, 397.5m, "Northern Ireland", 552.5m, 853.7m, 935.0m, 718.7m, 2006 },
                    { 50, 354.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1223.5m, 1047.3m, "Northern Ireland", 583.9m, 551.8m, 472.5m, 1653.0m, 2004 },
                    { 39, 226.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 34.4m, 1806.7m, "Scotland", 1382.1m, 428.2m, 1613.3m, 1536.6m, 2004 },
                    { 30, 1471.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1244.5m, 1685.0m, "England", 1788.4m, 1896.1m, 885.2m, 953.0m, 2006 },
                    { 42, 267.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1663.3m, 1083.9m, "England", 1267.6m, 853.4m, 1919.7m, 1290.1m, 2006 },
                    { 43, 750.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 359.4m, 206.3m, "Northern Ireland", 463.4m, 1877.2m, 397.3m, 674.1m, 2004 },
                    { 44, 1447.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 261.9m, 1905.0m, "Northern Ireland", 1243.3m, 1073.1m, 1224.5m, 987.4m, 2005 },
                    { 45, 1951.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 499.7m, 71.4m, "Yorkshire and the Humber", 1751.3m, 1728.5m, 1977.9m, 1016.9m, 2004 },
                    { 46, 514.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 640.6m, 888.8m, "Scotland", 1239.2m, 223.7m, 558.3m, 1105.5m, 2005 },
                    { 47, 617.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1681.4m, 762.1m, "Yorkshire and the Humber", 1428.3m, 538.4m, 1108.9m, 860.9m, 2005 },
                    { 48, 1362.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1194.7m, 669.3m, "Northern Ireland", 1657.7m, 1965.8m, 1842.8m, 834.8m, 2004 },
                    { 40, 1494.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1691.6m, 1105.2m, "England", 1598.9m, 1888.7m, 902.5m, 826.2m, 2006 },
                    { 41, 1558.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1861.9m, 1430.8m, "Yorkshire and the Humber", 823.9m, 1726.8m, 1787.7m, 1859.8m, 2006 },
                    { 29, 440.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 488.6m, 1589.0m, "Scotland", 1205.4m, 1979.4m, 1355.5m, 343.9m, 2006 },
                    { 27, 799.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 266.3m, 1915.7m, "Northern Ireland", 305.2m, 249.2m, 1028.5m, 1048.1m, 2004 },
                    { 6, 1935.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1466.3m, 159.8m, "Scotland", 45.2m, 27.2m, 252.5m, 224.3m, 2005 },
                    { 7, 435.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 859.0m, 1275.3m, "Northern Ireland", 944.8m, 894.3m, 1333.6m, 1542.0m, 2004 },
                    { 8, 276.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 444.0m, 1016.6m, "Northern Ireland", 905.4m, 1051.7m, 808.6m, 262.8m, 2006 },
                    { 9, 385.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 548.5m, 501.8m, "England", 1555.4m, 1242.8m, 253.4m, 1480.4m, 2005 },
                    { 10, 140.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 158.1m, 634.9m, "England", 981.6m, 1255.3m, 828.4m, 1137.3m, 2003 },
                    { 11, 572.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1049.8m, 869.9m, "England", 253.1m, 1794.9m, 1800.4m, 1791.7m, 2004 },
                    { 12, 1028.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 883.4m, 305.5m, "Northern Ireland", 1808.5m, 1830.3m, 1948.1m, 932.9m, 2003 },
                    { 13, 442.9m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1193.0m, 411.5m, "England", 785.0m, 1125.7m, 1156.6m, 1023.2m, 2004 },
                    { 14, 270.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1020.7m, 1569.9m, "Northern Ireland", 650.5m, 919.0m, 122.3m, 1974.9m, 2006 },
                    { 15, 685.4m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 590.4m, 472.3m, "Yorkshire and the Humber", 1203.5m, 1957.2m, 908.0m, 76.2m, 2005 },
                    { 16, 676.0m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 310.0m, 1611.3m, "England", 1945.0m, 195.3m, 108.7m, 341.0m, 2003 },
                    { 17, 1841.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1446.6m, 1292.7m, "Scotland", 607.4m, 1898.2m, 1348.7m, 1312.5m, 2003 },
                    { 18, 238.6m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 109.4m, 1623.4m, "Scotland", 927.3m, 945.3m, 662.4m, 1894.1m, 2006 },
                    { 19, 312.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 485.7m, 883.1m, "Scotland", 566.1m, 1912.2m, 337.7m, 1235.9m, 2006 },
                    { 20, 1039.1m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 75.2m, 788.6m, "Scotland", 1812.3m, 1852.4m, 1298.8m, 1026.7m, 2004 }
                });

            migrationBuilder.InsertData(
                table: "EnergyGeneration",
                columns: new[] { "Id", "Hydro", "Image", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[,]
                {
                    { 21, 1910.8m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 787.2m, 770.4m, "Scotland", 1461.4m, 518.3m, 234.6m, 752.8m, 2006 },
                    { 22, 321.5m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1730.7m, 555.9m, "Scotland", 1999.2m, 1972.5m, 102.3m, 1571.8m, 2003 },
                    { 23, 1724.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1929.3m, 661.8m, "Scotland", 863.0m, 1644.4m, 999.8m, 1151.2m, 2004 },
                    { 24, 138.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 386.1m, 502.9m, "Northern Ireland", 587.2m, 1712.3m, 854.9m, 141.5m, 2004 },
                    { 25, 1795.7m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1794.3m, 422.6m, "Scotland", 1550.4m, 1235.6m, 1325.1m, 177.3m, 2003 },
                    { 26, 1256.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 1066.5m, 1115.7m, "Northern Ireland", 1568.1m, 894.1m, 705.1m, 1649.0m, 2003 },
                    { 28, 1496.3m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 609.2m, 1538.2m, "Yorkshire and the Humber", 1716.1m, 1036.5m, 1433.1m, 1060.3m, 2003 },
                    { 5, 1944.2m, "https://24e0-138-75-155-224.ngrok.io/images/energy.jpeg", 670.1m, 751.4m, "Northern Ireland", 1847.7m, 339.0m, 1112.1m, 236.4m, 2005 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "Image",
                table: "EnergyGeneration");

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 25.3m, 2899.0m, 2716.9m, "England", 25.3m, 5990.4m, 0.0m, 349.2m, 2003 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 30.8m, 22.5m, 0.8m, 0.0m, 19.3m, 0.6m, 743.8m, 2009 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 6.5m, 465.3m, 31.8m, 129.6m, 3637.6m, 0.2m, 774.5m, 2013 });

            migrationBuilder.UpdateData(
                table: "EnergyGeneration",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Hydro", "LandfillGas", "OtherBioEnergy", "Region", "SolarPv", "Total", "WaveAndTidal", "Wind2", "Year" },
                values: new object[] { 5757.1m, 503.4m, 26.2m, "Scotland", 173.9m, 1331.4m, 2.0m, 13833.5m, 2015 });
        }
    }
}
