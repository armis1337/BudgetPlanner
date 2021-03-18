using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetPlanner2Web.Migrations
{
    public partial class CreatedUpdatedAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1337,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 446, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1338,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1339,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1340,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1341,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1342,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1343,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1344,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1345,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1346,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1347,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1348,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1349,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1350,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1351,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1352,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1353,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1354,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1355,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1356,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1357,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1358,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1359,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1360,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1361,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1362,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1363,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1364,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1365,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1366,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1367,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1368,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1369,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1370,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1371,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1372,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1373,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1374,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1375,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1376,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1377,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1378,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1379,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1380,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1381,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1382,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1383,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1384,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1385,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1386,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1387,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1388,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1389,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1390,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1391,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1392,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1393,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1394,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1395,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1396,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1397,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1398,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1399,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1401,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1402,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1403,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1404,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1405,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1406,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1407,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1408,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1409,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1410,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1411,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1412,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1413,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1414,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1415,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1416,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1417,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1418,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1419,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1420,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1421,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1422,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1423,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1424,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1425,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1426,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1427,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1428,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1429,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1430,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1431,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1432,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1433,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1434,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1435,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1436,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1437,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1438,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1439,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1440,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1441,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1442,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1443,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1444,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1445,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1446,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1447,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1448,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1449,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1450,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1451,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1452,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1453,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1454,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1455,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1456,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1457,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1458,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1459,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1460,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1461,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1462,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1463,
                column: "Date",
                value: new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1369));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Categories");

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
    }
}
