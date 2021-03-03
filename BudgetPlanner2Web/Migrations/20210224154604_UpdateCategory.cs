using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetPlanner2Web.Migrations
{
    public partial class UpdateCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "isDefault",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDefault",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ApplicationUserId", "Description", "Name", "isDefault" },
                values: new object[] { 1, null, "Default category", "Default", true });
        }
    }
}
