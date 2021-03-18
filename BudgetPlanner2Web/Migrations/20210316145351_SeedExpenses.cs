using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetPlanner2Web.Migrations
{
    public partial class SeedExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "ApplicationUserId", "CategoryId", "Comment", "Date" },
                values: new object[,]
                {
                    { 1337, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "0 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 993, DateTimeKind.Local).AddTicks(2587) },
                    { 1429, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "92 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5412) },
                    { 1428, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "91 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5374) },
                    { 1427, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "90 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5337) },
                    { 1426, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "89 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5298) },
                    { 1425, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "88 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5260) },
                    { 1424, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "87 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5220) },
                    { 1423, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "86 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5172) },
                    { 1422, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "85 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5083) },
                    { 1421, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "84 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5045) },
                    { 1420, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "83 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5008) },
                    { 1419, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "82 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4971) },
                    { 1418, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "81 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4934) },
                    { 1417, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "80 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4896) },
                    { 1430, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "93 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5449) },
                    { 1416, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "79 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4858) },
                    { 1414, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "77 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4783) },
                    { 1413, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "76 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4746) },
                    { 1412, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "75 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4708) },
                    { 1411, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "74 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4670) },
                    { 1410, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "73 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4632) },
                    { 1409, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "72 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4593) },
                    { 1408, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "71 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4551) },
                    { 1407, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "70 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4455) },
                    { 1406, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "69 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4417) },
                    { 1405, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "68 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4379) },
                    { 1404, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "67 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4341) },
                    { 1403, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "66 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4304) },
                    { 1402, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "65 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4265) },
                    { 1415, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "78 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4821) },
                    { 1401, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "64 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4222) },
                    { 1431, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "94 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5487) },
                    { 1433, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "96 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5561) },
                    { 1461, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "124 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6864) },
                    { 1460, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "123 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6826) },
                    { 1459, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "122 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6788) },
                    { 1458, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "121 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6750) },
                    { 1457, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "120 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6712) },
                    { 1456, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "119 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6674) },
                    { 1455, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "118 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6636) },
                    { 1454, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "117 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6594) },
                    { 1453, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "116 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6495) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "ApplicationUserId", "CategoryId", "Comment", "Date" },
                values: new object[,]
                {
                    { 1452, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "115 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6458) },
                    { 1451, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "114 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6420) },
                    { 1450, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "113 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6382) },
                    { 1449, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "112 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6344) },
                    { 1432, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "95 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5524) },
                    { 1448, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "111 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6306) },
                    { 1446, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "109 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6230) },
                    { 1445, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "108 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6192) },
                    { 1444, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "107 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6155) },
                    { 1443, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "106 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6117) },
                    { 1442, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "105 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6079) },
                    { 1441, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "104 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6041) },
                    { 1440, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "103 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6003) },
                    { 1439, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "102 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5962) },
                    { 1438, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "101 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5894) },
                    { 1437, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "100 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5709) },
                    { 1436, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "99 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5672) },
                    { 1435, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "98 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5635) },
                    { 1434, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "97 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(5598) },
                    { 1447, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "110 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6268) },
                    { 1462, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "125 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6902) },
                    { 1400, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "63 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4184) },
                    { 1398, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "61 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4108) },
                    { 1365, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "28 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2625) },
                    { 1364, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "27 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2534) },
                    { 1363, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "26 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2492) },
                    { 1362, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "25 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2451) },
                    { 1361, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "24 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2412) },
                    { 1360, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "23 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2372) },
                    { 1359, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "22 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2332) },
                    { 1358, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "21 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2292) },
                    { 1357, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "20 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2253) },
                    { 1356, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "19 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2212) },
                    { 1355, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "18 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2172) },
                    { 1354, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "17 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2124) },
                    { 1353, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "16 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2077) },
                    { 1366, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "29 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2677) },
                    { 1352, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "15 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2035) },
                    { 1350, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "13 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1924) },
                    { 1349, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "12 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1809) },
                    { 1348, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "11 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1765) },
                    { 1347, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "10 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1722) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "ApplicationUserId", "CategoryId", "Comment", "Date" },
                values: new object[,]
                {
                    { 1346, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "9 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1672) },
                    { 1345, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "8 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1623) },
                    { 1344, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "7 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1580) },
                    { 1343, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "6 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1533) },
                    { 1342, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "5 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1484) },
                    { 1341, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "4 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1424) },
                    { 1340, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "3 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1376) },
                    { 1339, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "2 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1317) },
                    { 1338, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "1 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1032) },
                    { 1351, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "14 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(1986) },
                    { 1399, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "62 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4146) },
                    { 1367, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "30 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2718) },
                    { 1369, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "32 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2797) },
                    { 1397, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "60 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4069) },
                    { 1396, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "59 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(4030) },
                    { 1395, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "58 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3986) },
                    { 1394, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "57 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3797) },
                    { 1393, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "56 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3760) },
                    { 1392, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "55 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3723) },
                    { 1391, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "54 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3686) },
                    { 1390, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "53 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3648) },
                    { 1389, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "52 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3611) },
                    { 1388, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "51 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3574) },
                    { 1387, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "50 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3537) },
                    { 1386, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "49 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3500) },
                    { 1385, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "48 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3463) },
                    { 1368, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "31 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2758) },
                    { 1384, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "47 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3426) },
                    { 1382, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "45 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3352) },
                    { 1381, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "44 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3314) },
                    { 1380, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "43 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3274) },
                    { 1379, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "42 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3224) },
                    { 1378, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "41 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3141) },
                    { 1377, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "40 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3104) },
                    { 1376, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "39 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3066) },
                    { 1375, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "38 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3029) },
                    { 1374, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "37 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2992) },
                    { 1373, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "36 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2955) },
                    { 1372, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "35 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2917) },
                    { 1371, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "34 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2878) },
                    { 1370, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "33 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(2840) },
                    { 1383, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "46 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(3389) }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "ApplicationUserId", "CategoryId", "Comment", "Date" },
                values: new object[] { 1463, 13.37m, "9659f3cc-8531-4b6b-bba3-382c108b192c", 16, "126 automatically added expense", new DateTime(2021, 3, 16, 16, 53, 50, 999, DateTimeKind.Local).AddTicks(6939) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1463);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
