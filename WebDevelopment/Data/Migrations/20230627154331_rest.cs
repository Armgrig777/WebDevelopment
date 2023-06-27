using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebDevelopment.Data.Migrations
{
    /// <inheritdoc />
    public partial class rest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Vout",
                table: "cars");

            migrationBuilder.AddColumn<int>(
                name: "Doors",
                table: "cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EngineSize",
                table: "cars",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_cars_MakeId",
                table: "cars",
                column: "MakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_makes_MakeId",
                table: "cars",
                column: "MakeId",
                principalTable: "makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_makes_MakeId",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_MakeId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "Doors",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "EngineSize",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "Seats",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "cars");

            migrationBuilder.AddColumn<string>(
                name: "Vout",
                table: "cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "makes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes" },
                    { 2, "Nissan" },
                    { 3, "Toyota" }
                });
        }
    }
}
