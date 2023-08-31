using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuWF.Migrations
{
    /// <inheritdoc />
    public partial class recipeToDishInJournal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "Journals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Journals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Journals_RecipeId",
                table: "Journals",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Journals_Recipes_RecipeId",
                table: "Journals",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journals_Recipes_RecipeId",
                table: "Journals");

            migrationBuilder.DropIndex(
                name: "IX_Journals_RecipeId",
                table: "Journals");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Journals");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "Journals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
