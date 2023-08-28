using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuWF.Migrations
{
    /// <inheritdoc />
    public partial class DecimalProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Prots",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fats",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbs",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Calories",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 50m, 20m, 0m, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 80m, 15m, 0m, 2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 35m, 10m, 0m, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 250m, 0m, 15m, 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 130m, 30m, 1m, 3m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 70m, 1m, 5m, 6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 20m, 5m, 0m, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 180m, 0m, 10m, 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 150m, 2m, 15m, 10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 40m, 24m, 0m, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 50m, 26m, 0m, 1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 100m, 20m, 1m, 3m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Prots",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Fats",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Carbs",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 50, 20, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 80, 15, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 35, 10, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 250, 0, 15, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 130, 30, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 70, 1, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 20, 5, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 180, 0, 10, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 150, 2, 15, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 40, 24, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 50, 26, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Calories", "Carbs", "Fats", "Prots" },
                values: new object[] { 100, 20, 1, 3 });
        }
    }
}
