using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "value 101" });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "value 102" });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "value 103" });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "value 104" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
