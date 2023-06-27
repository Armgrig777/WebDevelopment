using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDevelopment.Data.Migrations
{
    /// <inheritdoc />
    public partial class asf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_makes_MakeId",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_MakeId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "cars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
