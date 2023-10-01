using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmount",
                table: "FoodAmount");

            migrationBuilder.DropIndex(
                name: "IX_FoodAmount_FoodId",
                table: "FoodAmount");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FoodAmount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmount",
                table: "FoodAmount",
                columns: new[] { "FoodId", "UserMealId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodAmount",
                table: "FoodAmount");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FoodAmount",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodAmount",
                table: "FoodAmount",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmount_FoodId",
                table: "FoodAmount",
                column: "FoodId");
        }
    }
}
