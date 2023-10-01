using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Calorie",
                table: "UserMeals");

            migrationBuilder.RenameColumn(
                name: "Protein",
                table: "UserMeals",
                newName: "TotalProtein");

            migrationBuilder.RenameColumn(
                name: "Portion",
                table: "UserMeals",
                newName: "TotalFat");

            migrationBuilder.RenameColumn(
                name: "Fat",
                table: "UserMeals",
                newName: "TotalCarbonhidrate");

            migrationBuilder.RenameColumn(
                name: "Carbonhidrate",
                table: "UserMeals",
                newName: "TotalCalorie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalProtein",
                table: "UserMeals",
                newName: "Protein");

            migrationBuilder.RenameColumn(
                name: "TotalFat",
                table: "UserMeals",
                newName: "Portion");

            migrationBuilder.RenameColumn(
                name: "TotalCarbonhidrate",
                table: "UserMeals",
                newName: "Fat");

            migrationBuilder.RenameColumn(
                name: "TotalCalorie",
                table: "UserMeals",
                newName: "Carbonhidrate");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<double>(
                name: "Calorie",
                table: "UserMeals",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
