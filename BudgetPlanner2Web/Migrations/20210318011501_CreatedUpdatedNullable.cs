using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetPlanner2Web.Migrations
{
    public partial class CreatedUpdatedNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Expenses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Expenses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 259, DateTimeKind.Local).AddTicks(480), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1338,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2251), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1339,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2496), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1340,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2550), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1341,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2592), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1342,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2644), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1343,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2685), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1344,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2746), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1345,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2789), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1346,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2832), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1347,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2871), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1348,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2911), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1349,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2949), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1350,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(2986), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1351,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3024), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1352,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3061), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1353,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3099), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1354,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3140), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1355,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3178), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1356,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3217), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3264), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3306), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3344), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3382), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3420), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3457), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3495), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3532), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1365,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3569), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1366,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3606), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1367,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3643), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1368,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3680), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1369,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3717), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3757), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1371,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3805), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3845), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1373,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3883), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1374,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3921), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1375,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(3960), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4035), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1377,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4080), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4119), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1379,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4158), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1380,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4197), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1381,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4235), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1382,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4273), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1383,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4311), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4348), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4396), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1386,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4437), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4475), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1388,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4513), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1389,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4550), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4588), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4625), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4663), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4701), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4738), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4776), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4813), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4851), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4888), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4935), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(4977), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5017), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5059), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5097), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5135), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5173), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5211), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5248), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5285), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5322), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5359), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5404), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5443), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5481), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5518), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5556), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5595), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5633), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5670), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5708), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5745), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5783), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5820), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5858), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5895), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5932), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(5985), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6024), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6061), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6098), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6136), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6172), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6209), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6246), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1434,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6284), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1435,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6322), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1436,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6359), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1437,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6396), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1438,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6434), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6471), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1440,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6517), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1441,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6557), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1442,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6594), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1443,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6632), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1444,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6670), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1445,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6707), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1446,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6745), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1447,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6782), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1448,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6818), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1449,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6855), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1450,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6892), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1451,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6929), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1452,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(6966), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1453,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7003), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1454,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7184), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1455,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7242), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1456,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7283), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1457,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7322), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1458,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7361), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7401), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7440), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7479), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7518), null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { null, new DateTime(2021, 3, 18, 3, 15, 0, 265, DateTimeKind.Local).AddTicks(7557), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 446, DateTimeKind.Local).AddTicks(9734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1338,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(8910), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1339,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9388), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1340,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9496), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1341,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1342,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1343,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1344,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 455, DateTimeKind.Local).AddTicks(9839), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1345,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(257), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1346,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(413), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1347,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(548), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1348,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(669), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1349,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(757), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1350,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(835), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1351,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(918), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1352,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1005), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1353,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1089), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1354,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1229), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1355,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1351), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1356,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1423), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1505), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1590), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1794), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1885), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(1964), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2043), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2118), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2188), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1365,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2255), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1366,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1367,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2401), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1368,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2473), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1369,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2554), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1371,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(2912), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1373,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3012), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1374,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3104), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1375,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3192), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3280), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1377,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3459), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1379,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3549), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1380,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3636), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1381,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3719), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1382,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1383,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(3923), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4001), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1386,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4075), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1388,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1389,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4424), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4556), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4636), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4789), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4863), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(4941), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5018), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5091), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5244), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5669), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5817), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5892), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(5966), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6040), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6115), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6197), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6771), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6922), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(6999), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7074), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7152), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7752), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7908), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(7984), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8058), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8136), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8212), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8298), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8374), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8449), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8661), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1434,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(8784), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1435,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9142), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1436,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9230), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1437,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9307), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1438,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9387), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9458), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1440,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9529), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1441,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9604), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1442,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1443,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9780), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1444,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9859), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1445,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9927), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1446,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 456, DateTimeKind.Local).AddTicks(9998), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1447,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(125), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1448,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(217), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1449,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(288), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1450,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1451,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1452,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(607), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1453,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1454,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(748), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1455,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(821), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1456,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(889), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1457,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(961), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1458,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1028), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1101), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1164), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1235), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "CreatedAt", "Date", "UpdatedAt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 2, 51, 47, 457, DateTimeKind.Local).AddTicks(1369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
