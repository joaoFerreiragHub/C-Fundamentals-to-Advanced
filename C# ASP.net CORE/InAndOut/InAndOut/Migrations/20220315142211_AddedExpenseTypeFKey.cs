using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InAndOut.Migrations
{
    public partial class AddedExpenseTypeFKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseTypeId",
                table: "ExpensesList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesList_ExpenseTypeId",
                table: "ExpensesList",
                column: "ExpenseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesList_ExpenseTypes_ExpenseTypeId",
                table: "ExpensesList",
                column: "ExpenseTypeId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesList_ExpenseTypes_ExpenseTypeId",
                table: "ExpensesList");

            migrationBuilder.DropIndex(
                name: "IX_ExpensesList_ExpenseTypeId",
                table: "ExpensesList");

            migrationBuilder.DropColumn(
                name: "ExpenseTypeId",
                table: "ExpensesList");
        }
    }
}
