using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetPlanner2Web.Migrations
{
    public partial class GeneralizeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseId",
                table: "Expenses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1337,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 68, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1338,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1339,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1340,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1341,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1342,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1343,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1344,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1345,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1346,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1347,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1348,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1349,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1350,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1351,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1352,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1353,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1354,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1355,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1356,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1357,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1358,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1359,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1360,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1361,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1362,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1363,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1364,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1365,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1366,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1367,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1368,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1369,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1370,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1371,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1372,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1373,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1374,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1375,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1376,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1377,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1378,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1379,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1380,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1381,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1382,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1383,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1384,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1385,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1386,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1387,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1388,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1389,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1390,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1391,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1392,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1393,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1394,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1395,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1396,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1397,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1398,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1399,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1401,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1402,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1403,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1404,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1405,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1406,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1407,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1408,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1409,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1410,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1411,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1412,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1413,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1414,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1415,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1416,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1417,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1418,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1419,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1420,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1421,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1422,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1423,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1424,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1425,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1426,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1427,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1428,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1429,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1430,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1431,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1432,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1433,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1434,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1435,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1436,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1437,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1438,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 78, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1439,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1440,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1441,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1442,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1443,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1444,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1445,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1446,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1447,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1448,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1449,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1450,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1451,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1452,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1453,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1454,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1455,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1456,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1457,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1458,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1459,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1460,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1461,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1462,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1463,
                column: "Date",
                value: new DateTime(2021, 3, 16, 23, 40, 57, 79, DateTimeKind.Local).AddTicks(2507));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Expenses",
                newName: "ExpenseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1337,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 993, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1338,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1339,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1340,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1341,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1342,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1343,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1344,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1345,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1346,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1347,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1348,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1349,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1350,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1351,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1352,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1353,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1354,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1355,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1356,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1357,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1358,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1359,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1360,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1361,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1362,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1363,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1364,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1365,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1366,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1367,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1368,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1369,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1370,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1371,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1372,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1373,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1374,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1375,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1376,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1377,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1378,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1379,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1380,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1381,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1382,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1383,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1384,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1385,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1386,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1387,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1388,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1389,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1390,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1391,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1392,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1393,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1394,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1395,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1396,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1397,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1398,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1399,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1400,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1401,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1402,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1403,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1404,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1405,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1406,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1407,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1408,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1409,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1410,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1411,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1412,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1413,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1414,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1415,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1416,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1417,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1418,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1419,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1420,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1421,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1422,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1423,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1424,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1425,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1426,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1427,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1428,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1429,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1430,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1431,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1432,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1433,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1434,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1435,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1436,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1437,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1438,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1439,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1440,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1441,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1442,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1443,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1444,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1445,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1446,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1447,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1448,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1449,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1450,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1451,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1452,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1453,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1454,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1455,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1456,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1457,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1458,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1459,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1460,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1461,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1462,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1463,
                column: "Date",
                value: new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6939));
        }
    }
}
