using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodUserMeals");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "UserMeals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FoodAmount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Gram = table.Column<int>(type: "int", nullable: false),
                    UserMealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAmount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodAmount_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAmount_UserMeals_UserMealId",
                        column: x => x.UserMealId,
                        principalTable: "UserMeals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMeals_FoodId",
                table: "UserMeals",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmount_FoodId",
                table: "FoodAmount",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAmount_UserMealId",
                table: "FoodAmount",
                column: "UserMealId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMeals_Foods_FoodId",
                table: "UserMeals",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMeals_Foods_FoodId",
                table: "UserMeals");

            migrationBuilder.DropTable(
                name: "FoodAmount");

            migrationBuilder.DropIndex(
                name: "IX_UserMeals_FoodId",
                table: "UserMeals");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "UserMeals");

            migrationBuilder.CreateTable(
                name: "FoodUserMeals",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    UserMealsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodUserMeals", x => new { x.FoodsId, x.UserMealsId });
                    table.ForeignKey(
                        name: "FK_FoodUserMeals_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodUserMeals_UserMeals_UserMealsId",
                        column: x => x.UserMealsId,
                        principalTable: "UserMeals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodUserMeals_UserMealsId",
                table: "FoodUserMeals",
                column: "UserMealsId");
        }
    }
}
